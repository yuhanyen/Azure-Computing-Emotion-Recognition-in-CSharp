using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Web;
using System.Linq; //Linq tolist
using System.Windows.Forms.DataVisualization.Charting;

namespace AzureEmoRec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            WebCamera.LoadAllDevices(lstDevices);

            var backImage = new NamedImage("BackImage", Properties.Resources.analysis_bg);
            chartConcentration.Images.Add(backImage);
            chartConcentration.BackImage = "BackImage";

            chartConcentration.ChartAreas[0].AxisX.Maximum = 100;
            chartConcentration.ChartAreas[0].AxisX.Minimum = 0;
            chartConcentration.ChartAreas[0].AxisX.LineWidth = 1;
            chartConcentration.ChartAreas[0].AxisY.Maximum = 1.0F;
            chartConcentration.ChartAreas[0].AxisY.Minimum = -1.0F;
            chartConcentration.ChartAreas[0].AxisY.LineWidth = 1;
            chartConcentration.ChartAreas[0].AxisY.Interval = 1.0F;
            chartConcentration.ChartAreas[0].AxisY.IsStartedFromZero = true;
            chartConcentration.ChartAreas[0].BackColor = System.Drawing.Color.Transparent;
            chartConcentration.Series[0].Color = System.Drawing.Color.White;
            double[] yValues1 = { 0.0F };
            chartConcentration.Series[0].Points.DataBindXY(null, yValues1);
        }
        WebCamera d;
        string Filename = "";
        int CounterCStatus = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (btn_capture.Text == "Start")
            {
                if (lstDevices.SelectedIndex < 0)
                {
                    MessageBox.Show(this, "Please select a device");
                    return;
                }
                d = (WebCamera)lstDevices.SelectedItem;
                d.DisplayWebCam(picWebCam, lstDevices.SelectedIndex);
                btn_capture.Text = "Close";
            }
            else
            {
                d.StopWebCam(lstDevices.SelectedIndex);
                btn_capture.Text = "Start";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            picSnap.Image = d.GetImage();
            Filename = DateTime.Now.ToString("yyyyMMddHHmmss");
            picSnap.Image.Save(@""+ Filename + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        static async Task<List<Face>> MakeRequest(string imageFilePath)
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);
            var face_status = new List<Face>();

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "818afed105d344fd9647d52d956fd2d1");

            // Request parameters
            queryString["returnFaceId"] = "false";
            queryString["returnFaceLandmarks"] = "false";
            queryString["returnFaceAttributes"] = "emotion";
            queryString["recognitionModel"] = "recognition_04";
            queryString["returnRecognitionModel"] = "false";
            //queryString["detectionModel"] = "detection_03";
            queryString["faceIdTimeToLive"] = "86400";
            //string queryString = "returnFaceId=true&returnFaceLandmarks=false&returnFaceAttributes=headPose,emotion";
            var uri = "https://southeastasia.api.cognitive.microsoft.com/face/v1.0/detect?" + queryString;

            HttpResponseMessage response;
            string responseContent;

            // Request body
            byte[] byteData = GetImageAsByteArray(imageFilePath);

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                response = await client.PostAsync(uri, content);
                responseContent = response.Content.ReadAsStringAsync().Result;
                if ((int)response.StatusCode == 200)
                {
                    face_status = JsonConvert.DeserializeObject<List<Face>>(responseContent);
                    return face_status;
                }
                else
                    return null;
            }
        }

        /*public async Task<string> Calculate(string imageFilePath)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "918afed105d344fd9647d52d956fd2d2");
            string queryString = "returnFaceId=false&returnFaceLandmarks=false&returnFaceAttributes=emotion";
            string uri = "https://southeastasia.api.cognitive.microsoft.com/face/v1.0/detect?" + queryString;
            HttpResponseMessage response;
            string responseContent;
            byte[] byteData = GetImageAsByteArray(imageFilePath);

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                response = await client.PostAsync(uri, content);
                responseContent = response.Content.ReadAsStringAsync().Result;
                if ((int)response.StatusCode == 200)
                {
                    List<Face> face_status = JsonConvert.DeserializeObject<List<Face>>(responseContent);
                }
            }
            return response.StatusCode.ToString();
        }*/

        static byte[] GetImageAsByteArray(string imageFilePath)
        {
            FileStream fileStream = new FileStream(imageFilePath, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            return binaryReader.ReadBytes((int)fileStream.Length);
        }

        public class Face
        {
            //public string faceId { get; set; }
            //public string recognitionModel { get; set; }
            //public FaceRectangle faceRectangle { get; set; }
            //public FaceLandmarks faceLandmarks { get; set; }
            public FaceAttributes faceAttributes { get; set; }
        }

        public class FaceRectangle
        {
            public int width { get; set; }
            public int height { get; set; }
            public int left { get; set; }
            public int top { get; set; }
        }

        public class PupilLeft
        {
            public double x { get; set; }
            public double y { get; set; }
        }

        public class PupilRight
        {
            public double x { get; set; }
            public double y { get; set; }
        }

        public class NoseTip
        {
            public double x { get; set; }
            public double y { get; set; }
        }

        public class MouthLeft
        {
            public double x { get; set; }
            public double y { get; set; }
        }

        public class MouthRight
        {
            public double x { get; set; }
            public double y { get; set; }
        }

        public class EyebrowLeftOuter
        {
            public double x { get; set; }
            public double y { get; set; }
        }

        public class EyebrowLeftInner
        {
            public double x { get; set; }
            public double y { get; set; }
        }

        public class EyeLeftOuter
        {
            public double x { get; set; }
            public double y { get; set; }
        }

        public class EyeLeftTop
        {
            public double x { get; set; }
            public double y { get; set; }
        }

        public class EyeLeftBottom
        {
            public double x { get; set; }
            public double y { get; set; }
        }

        public class EyeLeftInner
        {
            public double x { get; set; }
            public double y { get; set; }
        }

        public class EyebrowRightInner
        {
            public double x { get; set; }
            public double y { get; set; }
        }

        public class EyebrowRightOuter
        {
            public double x { get; set; }
            public double y { get; set; }
        }

        public class EyeRightInner
        {
            public double x { get; set; }
            public double y { get; set; }
        }

        public class EyeRightTop
        {
            public double x { get; set; }
            public double y { get; set; }
        }

        public class EyeRightBottom
        {
            public double x { get; set; }
            public double y { get; set; }
        }

        public class EyeRightOuter
        {
            public double x { get; set; }
            public double y { get; set; }
        }

        public class NoseRootLeft
        {
            public double x { get; set; }
            public double y { get; set; }
        }

        public class NoseRootRight
        {
            public double x { get; set; }
            public double y { get; set; }
        }

        public class NoseLeftAlarTop
        {
            public double x { get; set; }
            public double y { get; set; }
        }

        public class NoseRightAlarTop
        {
            public double x { get; set; }
            public double y { get; set; }
        }

        public class NoseLeftAlarOutTip
        {
            public double x { get; set; }
            public double y { get; set; }
        }

        public class NoseRightAlarOutTip
        {
            public double x { get; set; }
            public double y { get; set; }
        }

        public class UpperLipTop
        {
            public double x { get; set; }
            public double y { get; set; }
        }

        public class UpperLipBottom
        {
            public double x { get; set; }
            public double y { get; set; }
        }

        public class UnderLipTop
        {
            public double x { get; set; }
            public double y { get; set; }
        }

        public class UnderLipBottom
        {
            public double x { get; set; }
            public double y { get; set; }
        }

        public class FaceLandmarks
        {
            public PupilLeft pupilLeft { get; set; }
            public PupilRight pupilRight { get; set; }
            public NoseTip noseTip { get; set; }
            public MouthLeft mouthLeft { get; set; }
            public MouthRight mouthRight { get; set; }
            public EyebrowLeftOuter eyebrowLeftOuter { get; set; }
            public EyebrowLeftInner eyebrowLeftInner { get; set; }
            public EyeLeftOuter eyeLeftOuter { get; set; }
            public EyeLeftTop eyeLeftTop { get; set; }
            public EyeLeftBottom eyeLeftBottom { get; set; }
            public EyeLeftInner eyeLeftInner { get; set; }
            public EyebrowRightInner eyebrowRightInner { get; set; }
            public EyebrowRightOuter eyebrowRightOuter { get; set; }
            public EyeRightInner eyeRightInner { get; set; }
            public EyeRightTop eyeRightTop { get; set; }
            public EyeRightBottom eyeRightBottom { get; set; }
            public EyeRightOuter eyeRightOuter { get; set; }
            public NoseRootLeft noseRootLeft { get; set; }
            public NoseRootRight noseRootRight { get; set; }
            public NoseLeftAlarTop noseLeftAlarTop { get; set; }
            public NoseRightAlarTop noseRightAlarTop { get; set; }
            public NoseLeftAlarOutTip noseLeftAlarOutTip { get; set; }
            public NoseRightAlarOutTip noseRightAlarOutTip { get; set; }
            public UpperLipTop upperLipTop { get; set; }
            public UpperLipBottom upperLipBottom { get; set; }
            public UnderLipTop underLipTop { get; set; }
            public UnderLipBottom underLipBottom { get; set; }
        }

        public class FacialHair
        {
            public double moustache { get; set; }
            public double beard { get; set; }
            public double sideburns { get; set; }
        }

        public class HeadPose
        {
            public double roll { get; set; }
            public double yaw { get; set; }
            public double pitch { get; set; }
        }

        public class Emotion
        {
            public double anger { get; set; }
            public double contempt { get; set; }
            public double disgust { get; set; }
            public double fear { get; set; }
            public double happiness { get; set; }
            public double neutral { get; set; }
            public double sadness { get; set; }
            public double surprise { get; set; }
        }

        public class HairColor
        {
            public string color { get; set; }
            public double confidence { get; set; }
        }

        public class Hair
        {
            public double bald { get; set; }
            public bool invisible { get; set; }
            public List<HairColor> hairColor { get; set; }
        }

        public class Makeup
        {
            public bool eyeMakeup { get; set; }
            public bool lipMakeup { get; set; }
        }

        public class Occlusion
        {
            public bool foreheadOccluded { get; set; }
            public bool eyeOccluded { get; set; }
            public bool mouthOccluded { get; set; }
        }

        public class Accessory
        {
            public string type { get; set; }
            public double confidence { get; set; }
        }

        public class Blur
        {
            public string blurLevel { get; set; }
            public double value { get; set; }
        }

        public class Exposure
        {
            public string exposureLevel { get; set; }
            public double value { get; set; }
        }

        public class Noise
        {
            public string noiseLevel { get; set; }
            public double value { get; set; }
        }

        public class FaceAttributes
        {
            //public double age { get; set; }
            //public string gender { get; set; }
            //public double smile { get; set; }
            //public FacialHair facialHair { get; set; }
            //public string glasses { get; set; }
            //public HeadPose headPose { get; set; }
            public Emotion emotion { get; set; }
            //public Hair hair { get; set; }
            //public Makeup makeup { get; set; }
            //public Occlusion occlusion { get; set; }
            //public List<Accessory> accessories { get; set; }
            //public Blur blur { get; set; }
            //public Exposure exposure { get; set; }
            //public Noise noise { get; set; }
        }

        private async void btn_calculate_Click(object sender, EventArgs e)
        {
            List<Face> face_status = await MakeRequest(@""+Filename+".jpg");
            //List<Face> face_status = await MakeRequest(@"mood.jpg");
            txt_Detected.Text = face_status.Count.ToString();
            txt_Results.Text = JsonConvert.SerializeObject(face_status);

            int[] mood = new int[] { 0, 0, 0, 0 };

            for (int i = 0; i < face_status.Count; i++)
            {
                double[] array = new double[] { face_status[i].faceAttributes.emotion.anger, face_status[i].faceAttributes.emotion.happiness, face_status[i].faceAttributes.emotion.neutral, face_status[i].faceAttributes.emotion.sadness };
                mood[array.ToList().IndexOf(array.Max())]++;
            }

            lbl_anger.Text = mood[0].ToString();
            lbl_happiness.Text = mood[1].ToString();
            lbl_neutral.Text = mood[2].ToString();
            lbl_sadness.Text = mood[3].ToString();

            if (CounterCStatus++ % 100 == 0)
                chartConcentration.Series[0].Points.Clear();
            double score = (mood[1] * 1 + mood[2] * 0.3 - mood[3] * 0.3 - mood[0] * 1) / (mood[1] * 1 + mood[2] * 1 + mood[3] * 1 + mood[0] * 1);
            chartConcentration.Series[0].Points.AddY(score);
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
