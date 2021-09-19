
namespace dasPIDLab
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartPID = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxManAuto = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.labelMan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSek = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.labelI = new System.Windows.Forms.Label();
            this.labelP = new System.Windows.Forms.Label();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.textBoxI = new System.Windows.Forms.TextBox();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.labelAuto = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxDataReceived = new System.Windows.Forms.CheckBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.textBoxReceived = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxSerialSend = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelComport = new System.Windows.Forms.Label();
            this.textBoxComPort = new System.Windows.Forms.TextBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.textBoxMan = new System.Windows.Forms.TextBox();
            this.textBoxSetpoint = new System.Windows.Forms.TextBox();
            this.checkBoxResolution = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerControlLoop = new System.Windows.Forms.Timer(this.components);
            this.labelResolution = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartPID)).BeginInit();
            this.groupBoxManAuto.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartPID
            // 
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.Maximum = 500D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.AxisY.Maximum = 24D;
            chartArea1.AxisY.Minimum = 22D;
            chartArea1.AxisY2.Maximum = 100D;
            chartArea1.AxisY2.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chartPID.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPID.Legends.Add(legend1);
            this.chartPID.Location = new System.Drawing.Point(12, 22);
            this.chartPID.Name = "chartPID";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Temperatur";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series2.Legend = "Legend1";
            series2.Name = "Settpunkt";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Padrag";
            series3.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chartPID.Series.Add(series1);
            this.chartPID.Series.Add(series2);
            this.chartPID.Series.Add(series3);
            this.chartPID.Size = new System.Drawing.Size(920, 249);
            this.chartPID.TabIndex = 0;
            this.chartPID.Text = "PID";
            // 
            // groupBoxManAuto
            // 
            this.groupBoxManAuto.Controls.Add(this.radioButton2);
            this.groupBoxManAuto.Controls.Add(this.radioButton1);
            this.groupBoxManAuto.Location = new System.Drawing.Point(14, 280);
            this.groupBoxManAuto.Name = "groupBoxManAuto";
            this.groupBoxManAuto.Size = new System.Drawing.Size(103, 77);
            this.groupBoxManAuto.TabIndex = 1;
            this.groupBoxManAuto.TabStop = false;
            this.groupBoxManAuto.Text = "Modus";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 54);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(92, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Automatisk";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Manuell";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // labelMan
            // 
            this.labelMan.AutoSize = true;
            this.labelMan.Location = new System.Drawing.Point(123, 290);
            this.labelMan.Name = "labelMan";
            this.labelMan.Size = new System.Drawing.Size(102, 16);
            this.labelMan.TabIndex = 2;
            this.labelMan.Text = "Manuelt pådrag";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(582, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sekunder";
            // 
            // labelSek
            // 
            this.labelSek.AutoSize = true;
            this.labelSek.Location = new System.Drawing.Point(582, 313);
            this.labelSek.Name = "labelSek";
            this.labelSek.Size = new System.Drawing.Size(66, 16);
            this.labelSek.TabIndex = 11;
            this.labelSek.Text = "Sekunder";
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Location = new System.Drawing.Point(449, 339);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(25, 16);
            this.labelD.TabIndex = 9;
            this.labelD.Text = "Td";
            // 
            // labelI
            // 
            this.labelI.AutoSize = true;
            this.labelI.Location = new System.Drawing.Point(449, 313);
            this.labelI.Name = "labelI";
            this.labelI.Size = new System.Drawing.Size(20, 16);
            this.labelI.TabIndex = 8;
            this.labelI.Text = "Ti";
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Location = new System.Drawing.Point(449, 287);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(24, 16);
            this.labelP.TabIndex = 7;
            this.labelP.Text = "Kp";
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(476, 336);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(100, 22);
            this.textBoxD.TabIndex = 2;
            this.textBoxD.Text = "20.0";
            // 
            // textBoxI
            // 
            this.textBoxI.Location = new System.Drawing.Point(475, 310);
            this.textBoxI.Name = "textBoxI";
            this.textBoxI.Size = new System.Drawing.Size(100, 22);
            this.textBoxI.TabIndex = 1;
            this.textBoxI.Text = "10.0";
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(475, 284);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(100, 22);
            this.textBoxP.TabIndex = 0;
            this.textBoxP.Text = "1.0";
            // 
            // labelAuto
            // 
            this.labelAuto.AutoSize = true;
            this.labelAuto.Location = new System.Drawing.Point(123, 334);
            this.labelAuto.Name = "labelAuto";
            this.labelAuto.Size = new System.Drawing.Size(63, 16);
            this.labelAuto.TabIndex = 5;
            this.labelAuto.Text = "Settpunkt";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxDataReceived);
            this.groupBox1.Controls.Add(this.buttonDisconnect);
            this.groupBox1.Controls.Add(this.textBoxReceived);
            this.groupBox1.Controls.Add(this.buttonSend);
            this.groupBox1.Controls.Add(this.textBoxSerialSend);
            this.groupBox1.Controls.Add(this.buttonConnect);
            this.groupBox1.Controls.Add(this.labelComport);
            this.groupBox1.Controls.Add(this.textBoxComPort);
            this.groupBox1.Location = new System.Drawing.Point(13, 367);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 117);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seriell Kommunikasjon Oppsett";
            // 
            // checkBoxDataReceived
            // 
            this.checkBoxDataReceived.AutoSize = true;
            this.checkBoxDataReceived.Location = new System.Drawing.Point(152, 86);
            this.checkBoxDataReceived.Name = "checkBoxDataReceived";
            this.checkBoxDataReceived.Size = new System.Drawing.Size(116, 20);
            this.checkBoxDataReceived.TabIndex = 19;
            this.checkBoxDataReceived.Text = "Ny data mottatt";
            this.checkBoxDataReceived.UseVisualStyleBackColor = true;
            this.checkBoxDataReceived.CheckedChanged += new System.EventHandler(this.checkBoxDataReceived_CheckedChanged);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Enabled = false;
            this.buttonDisconnect.Location = new System.Drawing.Point(229, 26);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(74, 22);
            this.buttonDisconnect.TabIndex = 18;
            this.buttonDisconnect.Text = "Koble fra";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // textBoxReceived
            // 
            this.textBoxReceived.Location = new System.Drawing.Point(77, 82);
            this.textBoxReceived.Name = "textBoxReceived";
            this.textBoxReceived.Size = new System.Drawing.Size(69, 22);
            this.textBoxReceived.TabIndex = 17;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(152, 53);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(55, 23);
            this.buttonSend.TabIndex = 16;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxSerialSend
            // 
            this.textBoxSerialSend.Location = new System.Drawing.Point(77, 54);
            this.textBoxSerialSend.Name = "textBoxSerialSend";
            this.textBoxSerialSend.Size = new System.Drawing.Size(69, 22);
            this.textBoxSerialSend.TabIndex = 15;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(149, 26);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(74, 22);
            this.buttonConnect.TabIndex = 14;
            this.buttonConnect.Text = "Koble til";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // labelComport
            // 
            this.labelComport.AutoSize = true;
            this.labelComport.Location = new System.Drawing.Point(6, 29);
            this.labelComport.Name = "labelComport";
            this.labelComport.Size = new System.Drawing.Size(65, 16);
            this.labelComport.TabIndex = 13;
            this.labelComport.Text = "COM Port";
            // 
            // textBoxComPort
            // 
            this.textBoxComPort.Location = new System.Drawing.Point(77, 26);
            this.textBoxComPort.Name = "textBoxComPort";
            this.textBoxComPort.Size = new System.Drawing.Size(69, 22);
            this.textBoxComPort.TabIndex = 13;
            this.textBoxComPort.Text = "COM3";
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // textBoxMan
            // 
            this.textBoxMan.Location = new System.Drawing.Point(231, 287);
            this.textBoxMan.Name = "textBoxMan";
            this.textBoxMan.Size = new System.Drawing.Size(79, 22);
            this.textBoxMan.TabIndex = 13;
            this.textBoxMan.Text = "50.0";
            // 
            // textBoxSetpoint
            // 
            this.textBoxSetpoint.Location = new System.Drawing.Point(231, 329);
            this.textBoxSetpoint.Name = "textBoxSetpoint";
            this.textBoxSetpoint.Size = new System.Drawing.Size(79, 22);
            this.textBoxSetpoint.TabIndex = 14;
            this.textBoxSetpoint.Text = "22.31";
            // 
            // checkBoxResolution
            // 
            this.checkBoxResolution.AutoSize = true;
            this.checkBoxResolution.Checked = true;
            this.checkBoxResolution.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxResolution.Location = new System.Drawing.Point(316, 289);
            this.checkBoxResolution.Name = "checkBoxResolution";
            this.checkBoxResolution.Size = new System.Drawing.Size(51, 20);
            this.checkBoxResolution.TabIndex = 15;
            this.checkBoxResolution.Text = "8 bit";
            this.checkBoxResolution.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerControlLoop
            // 
            this.timerControlLoop.Tick += new System.EventHandler(this.timerControlLoop_Tick);
            // 
            // labelResolution
            // 
            this.labelResolution.Location = new System.Drawing.Point(228, 310);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(185, 16);
            this.labelResolution.TabIndex = 16;
            this.labelResolution.Text = "01111111";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 488);
            this.Controls.Add(this.labelSek);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelResolution);
            this.Controls.Add(this.checkBoxResolution);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.textBoxSetpoint);
            this.Controls.Add(this.labelI);
            this.Controls.Add(this.textBoxMan);
            this.Controls.Add(this.labelP);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxD);
            this.Controls.Add(this.labelAuto);
            this.Controls.Add(this.textBoxI);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.labelMan);
            this.Controls.Add(this.groupBoxManAuto);
            this.Controls.Add(this.chartPID);
            this.Name = "Main";
            this.Text = "PID Temperaturregulator";
            ((System.ComponentModel.ISupportInitialize)(this.chartPID)).EndInit();
            this.groupBoxManAuto.ResumeLayout(false);
            this.groupBoxManAuto.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartPID;
        private System.Windows.Forms.GroupBox groupBoxManAuto;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label labelMan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSek;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelI;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.TextBox textBoxI;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.Label labelAuto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxReceived;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxSerialSend;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelComport;
        private System.Windows.Forms.TextBox textBoxComPort;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.TextBox textBoxMan;
        private System.Windows.Forms.TextBox textBoxSetpoint;
        private System.Windows.Forms.CheckBox checkBoxResolution;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Timer timerControlLoop;
        private System.Windows.Forms.Label labelResolution;
        private System.Windows.Forms.CheckBox checkBoxDataReceived;
    }
}

