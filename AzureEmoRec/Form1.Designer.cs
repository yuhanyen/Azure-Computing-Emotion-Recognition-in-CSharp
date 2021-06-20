namespace AzureEmoRec
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lstDevices = new System.Windows.Forms.ListBox();
            this.btn_capture = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Detected = new System.Windows.Forms.TextBox();
            this.txt_Results = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pic_sadness = new System.Windows.Forms.PictureBox();
            this.pic_neutral = new System.Windows.Forms.PictureBox();
            this.pic_happiness = new System.Windows.Forms.PictureBox();
            this.pic_anger = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_sadness = new System.Windows.Forms.Label();
            this.lbl_neutral = new System.Windows.Forms.Label();
            this.lbl_happiness = new System.Windows.Forms.Label();
            this.lbl_anger = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chartConcentration = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.picSnap = new System.Windows.Forms.PictureBox();
            this.picWebCam = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_sadness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_neutral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_happiness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_anger)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartConcentration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSnap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWebCam)).BeginInit();
            this.SuspendLayout();
            // 
            // lstDevices
            // 
            this.lstDevices.FormattingEnabled = true;
            this.lstDevices.ItemHeight = 12;
            this.lstDevices.Location = new System.Drawing.Point(12, 282);
            this.lstDevices.Name = "lstDevices";
            this.lstDevices.Size = new System.Drawing.Size(178, 76);
            this.lstDevices.TabIndex = 2;
            // 
            // btn_capture
            // 
            this.btn_capture.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_capture.Location = new System.Drawing.Point(196, 258);
            this.btn_capture.Name = "btn_capture";
            this.btn_capture.Size = new System.Drawing.Size(150, 100);
            this.btn_capture.TabIndex = 3;
            this.btn_capture.Text = "Start";
            this.btn_capture.UseVisualStyleBackColor = true;
            this.btn_capture.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(352, 258);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 100);
            this.button3.TabIndex = 5;
            this.button3.Text = "Snapshot";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(8, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Choose a camera :";
            // 
            // btn_calculate
            // 
            this.btn_calculate.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.btn_calculate.Location = new System.Drawing.Point(508, 258);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(150, 100);
            this.btn_calculate.TabIndex = 5;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Detected Faces";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "API Response";
            // 
            // txt_Detected
            // 
            this.txt_Detected.Location = new System.Drawing.Point(19, 56);
            this.txt_Detected.Name = "txt_Detected";
            this.txt_Detected.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Detected.Size = new System.Drawing.Size(167, 33);
            this.txt_Detected.TabIndex = 9;
            // 
            // txt_Results
            // 
            this.txt_Results.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Results.Location = new System.Drawing.Point(19, 119);
            this.txt_Results.Multiline = true;
            this.txt_Results.Name = "txt_Results";
            this.txt_Results.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Results.Size = new System.Drawing.Size(167, 215);
            this.txt_Results.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pic_sadness);
            this.groupBox1.Controls.Add(this.pic_neutral);
            this.groupBox1.Controls.Add(this.pic_happiness);
            this.groupBox1.Controls.Add(this.pic_anger);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_sadness);
            this.groupBox1.Controls.Add(this.lbl_neutral);
            this.groupBox1.Controls.Add(this.lbl_happiness);
            this.groupBox1.Controls.Add(this.lbl_anger);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Results);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Detected);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(664, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 346);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recognition Results";
            // 
            // pic_sadness
            // 
            this.pic_sadness.Image = global::AzureEmoRec.Properties.Resources.sad;
            this.pic_sadness.Location = new System.Drawing.Point(213, 266);
            this.pic_sadness.Name = "pic_sadness";
            this.pic_sadness.Size = new System.Drawing.Size(64, 64);
            this.pic_sadness.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_sadness.TabIndex = 11;
            this.pic_sadness.TabStop = false;
            // 
            // pic_neutral
            // 
            this.pic_neutral.Image = global::AzureEmoRec.Properties.Resources.neutral;
            this.pic_neutral.Location = new System.Drawing.Point(213, 196);
            this.pic_neutral.Name = "pic_neutral";
            this.pic_neutral.Size = new System.Drawing.Size(64, 64);
            this.pic_neutral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_neutral.TabIndex = 11;
            this.pic_neutral.TabStop = false;
            // 
            // pic_happiness
            // 
            this.pic_happiness.Image = global::AzureEmoRec.Properties.Resources.happiness;
            this.pic_happiness.Location = new System.Drawing.Point(213, 126);
            this.pic_happiness.Name = "pic_happiness";
            this.pic_happiness.Size = new System.Drawing.Size(64, 64);
            this.pic_happiness.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_happiness.TabIndex = 11;
            this.pic_happiness.TabStop = false;
            // 
            // pic_anger
            // 
            this.pic_anger.Image = global::AzureEmoRec.Properties.Resources.anger;
            this.pic_anger.Location = new System.Drawing.Point(213, 56);
            this.pic_anger.Name = "pic_anger";
            this.pic_anger.Size = new System.Drawing.Size(64, 64);
            this.pic_anger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_anger.TabIndex = 11;
            this.pic_anger.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mood Index";
            // 
            // lbl_sadness
            // 
            this.lbl_sadness.AutoSize = true;
            this.lbl_sadness.Location = new System.Drawing.Point(305, 286);
            this.lbl_sadness.Name = "lbl_sadness";
            this.lbl_sadness.Size = new System.Drawing.Size(21, 24);
            this.lbl_sadness.TabIndex = 7;
            this.lbl_sadness.Text = "0";
            // 
            // lbl_neutral
            // 
            this.lbl_neutral.AutoSize = true;
            this.lbl_neutral.Location = new System.Drawing.Point(305, 216);
            this.lbl_neutral.Name = "lbl_neutral";
            this.lbl_neutral.Size = new System.Drawing.Size(21, 24);
            this.lbl_neutral.TabIndex = 7;
            this.lbl_neutral.Text = "0";
            // 
            // lbl_happiness
            // 
            this.lbl_happiness.AutoSize = true;
            this.lbl_happiness.Location = new System.Drawing.Point(305, 148);
            this.lbl_happiness.Name = "lbl_happiness";
            this.lbl_happiness.Size = new System.Drawing.Size(21, 24);
            this.lbl_happiness.TabIndex = 7;
            this.lbl_happiness.Text = "0";
            // 
            // lbl_anger
            // 
            this.lbl_anger.AutoSize = true;
            this.lbl_anger.Location = new System.Drawing.Point(305, 78);
            this.lbl_anger.Name = "lbl_anger";
            this.lbl_anger.Size = new System.Drawing.Size(21, 24);
            this.lbl_anger.TabIndex = 7;
            this.lbl_anger.Text = "0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chartConcentration);
            this.groupBox4.Controls.Add(this.pictureBox11);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(12, 364);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1003, 168);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "History";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // chartConcentration
            // 
            this.chartConcentration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chartConcentration.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.chartConcentration.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.chartConcentration.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            this.chartConcentration.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chartConcentration.BorderlineColor = System.Drawing.Color.Transparent;
            this.chartConcentration.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
            chartArea1.Name = "ChartArea1";
            this.chartConcentration.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartConcentration.Legends.Add(legend1);
            this.chartConcentration.Location = new System.Drawing.Point(56, 23);
            this.chartConcentration.Name = "chartConcentration";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.LabelBorderWidth = 5;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartConcentration.Series.Add(series1);
            this.chartConcentration.Size = new System.Drawing.Size(935, 133);
            this.chartConcentration.TabIndex = 11;
            this.chartConcentration.Text = "chart1";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::AzureEmoRec.Properties.Resources.analysis_bg;
            this.pictureBox11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox11.Location = new System.Drawing.Point(14, 23);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(35, 133);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 10;
            this.pictureBox11.TabStop = false;
            // 
            // picSnap
            // 
            this.picSnap.Location = new System.Drawing.Point(338, 12);
            this.picSnap.Name = "picSnap";
            this.picSnap.Size = new System.Drawing.Size(320, 240);
            this.picSnap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSnap.TabIndex = 1;
            this.picSnap.TabStop = false;
            // 
            // picWebCam
            // 
            this.picWebCam.Location = new System.Drawing.Point(12, 12);
            this.picWebCam.Name = "picWebCam";
            this.picWebCam.Size = new System.Drawing.Size(320, 240);
            this.picWebCam.TabIndex = 0;
            this.picWebCam.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 541);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_capture);
            this.Controls.Add(this.lstDevices);
            this.Controls.Add(this.picSnap);
            this.Controls.Add(this.picWebCam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_sadness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_neutral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_happiness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_anger)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartConcentration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSnap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWebCam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picWebCam;
        private System.Windows.Forms.PictureBox picSnap;
        private System.Windows.Forms.ListBox lstDevices;
        private System.Windows.Forms.Button btn_capture;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Detected;
        private System.Windows.Forms.TextBox txt_Results;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pic_anger;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pic_sadness;
        private System.Windows.Forms.PictureBox pic_neutral;
        private System.Windows.Forms.PictureBox pic_happiness;
        private System.Windows.Forms.Label lbl_sadness;
        private System.Windows.Forms.Label lbl_neutral;
        private System.Windows.Forms.Label lbl_happiness;
        private System.Windows.Forms.Label lbl_anger;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartConcentration;
        private System.Windows.Forms.PictureBox pictureBox11;
    }
}

