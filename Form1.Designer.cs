namespace HWMonitorDisp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comListText = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.portDesc = new System.Windows.Forms.Label();
            this.scanButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.intervaText = new System.Windows.Forms.TextBox();
            this.intervalLab = new System.Windows.Forms.Label();
            this.cpuLoad = new System.Windows.Forms.CheckBox();
            this.cpuTemp = new System.Windows.Forms.CheckBox();
            this.gpuLoad = new System.Windows.Forms.CheckBox();
            this.gpuTemp = new System.Windows.Forms.CheckBox();
            this.cpuLoadVal = new System.Windows.Forms.Label();
            this.cpuTempVal = new System.Windows.Forms.Label();
            this.gpuLoadVal = new System.Windows.Forms.Label();
            this.gpuTempVal = new System.Windows.Forms.Label();
            this.valInter = new System.Windows.Forms.Label();
            this.ramUsed = new System.Windows.Forms.CheckBox();
            this.ramUsedVal = new System.Windows.Forms.Label();
            this.debugLabel = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.DisconnButton = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // comListText
            // 
            this.comListText.FormattingEnabled = true;
            this.comListText.Location = new System.Drawing.Point(134, 37);
            this.comListText.Name = "comListText";
            this.comListText.Size = new System.Drawing.Size(121, 28);
            this.comListText.TabIndex = 0;
            this.comListText.SelectedIndexChanged += new System.EventHandler(this.comListText_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port :";
            // 
            // portDesc
            // 
            this.portDesc.AutoSize = true;
            this.portDesc.Location = new System.Drawing.Point(28, 72);
            this.portDesc.Name = "portDesc";
            this.portDesc.Size = new System.Drawing.Size(97, 20);
            this.portDesc.TabIndex = 2;
            this.portDesc.Text = "Description :";
            // 
            // scanButton
            // 
            this.scanButton.Location = new System.Drawing.Point(260, 35);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(104, 41);
            this.scanButton.TabIndex = 3;
            this.scanButton.Text = "Scan";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // intervaText
            // 
            this.intervaText.Location = new System.Drawing.Point(458, 12);
            this.intervaText.Name = "intervaText";
            this.intervaText.Size = new System.Drawing.Size(100, 26);
            this.intervaText.TabIndex = 4;
            this.intervaText.TextChanged += new System.EventHandler(this.intervaText_TextChanged);
            // 
            // intervalLab
            // 
            this.intervalLab.AutoSize = true;
            this.intervalLab.Location = new System.Drawing.Point(382, 12);
            this.intervalLab.Name = "intervalLab";
            this.intervalLab.Size = new System.Drawing.Size(69, 20);
            this.intervalLab.TabIndex = 5;
            this.intervalLab.Text = "Interval :";
            // 
            // cpuLoad
            // 
            this.cpuLoad.AutoSize = true;
            this.cpuLoad.Location = new System.Drawing.Point(387, 51);
            this.cpuLoad.Name = "cpuLoad";
            this.cpuLoad.Size = new System.Drawing.Size(108, 24);
            this.cpuLoad.TabIndex = 6;
            this.cpuLoad.Text = "CPU Load";
            this.cpuLoad.UseVisualStyleBackColor = true;
            this.cpuLoad.CheckedChanged += new System.EventHandler(this.cpuLoad_CheckedChanged);
            // 
            // cpuTemp
            // 
            this.cpuTemp.AutoSize = true;
            this.cpuTemp.Location = new System.Drawing.Point(387, 82);
            this.cpuTemp.Name = "cpuTemp";
            this.cpuTemp.Size = new System.Drawing.Size(112, 24);
            this.cpuTemp.TabIndex = 7;
            this.cpuTemp.Text = "CPU Temp";
            this.cpuTemp.UseVisualStyleBackColor = true;
            this.cpuTemp.CheckedChanged += new System.EventHandler(this.cpuTemp_CheckedChanged);
            // 
            // gpuLoad
            // 
            this.gpuLoad.AutoSize = true;
            this.gpuLoad.Location = new System.Drawing.Point(387, 111);
            this.gpuLoad.Name = "gpuLoad";
            this.gpuLoad.Size = new System.Drawing.Size(110, 24);
            this.gpuLoad.TabIndex = 8;
            this.gpuLoad.Text = "GPU Load";
            this.gpuLoad.UseVisualStyleBackColor = true;
            // 
            // gpuTemp
            // 
            this.gpuTemp.AutoSize = true;
            this.gpuTemp.Location = new System.Drawing.Point(387, 142);
            this.gpuTemp.Name = "gpuTemp";
            this.gpuTemp.Size = new System.Drawing.Size(114, 24);
            this.gpuTemp.TabIndex = 9;
            this.gpuTemp.Text = "GPU Temp";
            this.gpuTemp.UseVisualStyleBackColor = true;
            // 
            // cpuLoadVal
            // 
            this.cpuLoadVal.AutoSize = true;
            this.cpuLoadVal.Location = new System.Drawing.Point(524, 52);
            this.cpuLoadVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cpuLoadVal.Name = "cpuLoadVal";
            this.cpuLoadVal.Size = new System.Drawing.Size(14, 20);
            this.cpuLoadVal.TabIndex = 11;
            this.cpuLoadVal.Text = "-";
            // 
            // cpuTempVal
            // 
            this.cpuTempVal.AutoSize = true;
            this.cpuTempVal.Location = new System.Drawing.Point(524, 83);
            this.cpuTempVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cpuTempVal.Name = "cpuTempVal";
            this.cpuTempVal.Size = new System.Drawing.Size(14, 20);
            this.cpuTempVal.TabIndex = 12;
            this.cpuTempVal.Text = "-";
            // 
            // gpuLoadVal
            // 
            this.gpuLoadVal.AutoSize = true;
            this.gpuLoadVal.Location = new System.Drawing.Point(524, 112);
            this.gpuLoadVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gpuLoadVal.Name = "gpuLoadVal";
            this.gpuLoadVal.Size = new System.Drawing.Size(14, 20);
            this.gpuLoadVal.TabIndex = 13;
            this.gpuLoadVal.Text = "-";
            // 
            // gpuTempVal
            // 
            this.gpuTempVal.AutoSize = true;
            this.gpuTempVal.Location = new System.Drawing.Point(524, 143);
            this.gpuTempVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gpuTempVal.Name = "gpuTempVal";
            this.gpuTempVal.Size = new System.Drawing.Size(14, 20);
            this.gpuTempVal.TabIndex = 14;
            this.gpuTempVal.Text = "-";
            // 
            // valInter
            // 
            this.valInter.AutoSize = true;
            this.valInter.ForeColor = System.Drawing.Color.Firebrick;
            this.valInter.Location = new System.Drawing.Point(567, 17);
            this.valInter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valInter.Name = "valInter";
            this.valInter.Size = new System.Drawing.Size(157, 20);
            this.valInter.TabIndex = 16;
            this.valInter.Text = "Masukan angka valid";
            this.valInter.Visible = false;
            // 
            // ramUsed
            // 
            this.ramUsed.AutoSize = true;
            this.ramUsed.Location = new System.Drawing.Point(639, 52);
            this.ramUsed.Name = "ramUsed";
            this.ramUsed.Size = new System.Drawing.Size(113, 24);
            this.ramUsed.TabIndex = 19;
            this.ramUsed.Text = "RAM Used";
            this.ramUsed.UseVisualStyleBackColor = true;
            // 
            // ramUsedVal
            // 
            this.ramUsedVal.AutoSize = true;
            this.ramUsedVal.Location = new System.Drawing.Point(778, 54);
            this.ramUsedVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ramUsedVal.Name = "ramUsedVal";
            this.ramUsedVal.Size = new System.Drawing.Size(14, 20);
            this.ramUsedVal.TabIndex = 20;
            this.ramUsedVal.Text = "-";
            // 
            // debugLabel
            // 
            this.debugLabel.AutoSize = true;
            this.debugLabel.Location = new System.Drawing.Point(658, 167);
            this.debugLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(51, 20);
            this.debugLabel.TabIndex = 18;
            this.debugLabel.Text = "label2";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(68, 190);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(684, 300);
            this.chart1.TabIndex = 21;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(260, 82);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(104, 41);
            this.ConnectButton.TabIndex = 22;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // DisconnButton
            // 
            this.DisconnButton.Location = new System.Drawing.Point(260, 129);
            this.DisconnButton.Name = "DisconnButton";
            this.DisconnButton.Size = new System.Drawing.Size(104, 41);
            this.DisconnButton.TabIndex = 23;
            this.DisconnButton.Text = "Disconnect";
            this.DisconnButton.UseVisualStyleBackColor = true;
            this.DisconnButton.Click += new System.EventHandler(this.DisconnButton_Click);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.ForeColor = System.Drawing.Color.Firebrick;
            this.Status.Location = new System.Drawing.Point(90, 115);
            this.Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(49, 20);
            this.Status.TabIndex = 24;
            this.Status.Text = "STAT";
            this.Status.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Status :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(908, 214);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.DisconnButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.ramUsedVal);
            this.Controls.Add(this.ramUsed);
            this.Controls.Add(this.debugLabel);
            this.Controls.Add(this.valInter);
            this.Controls.Add(this.gpuTempVal);
            this.Controls.Add(this.gpuLoadVal);
            this.Controls.Add(this.cpuTempVal);
            this.Controls.Add(this.cpuLoadVal);
            this.Controls.Add(this.gpuTemp);
            this.Controls.Add(this.gpuLoad);
            this.Controls.Add(this.cpuTemp);
            this.Controls.Add(this.cpuLoad);
            this.Controls.Add(this.intervalLab);
            this.Controls.Add(this.intervaText);
            this.Controls.Add(this.scanButton);
            this.Controls.Add(this.portDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comListText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "HWMonitorDisp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comListText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label portDesc;
        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox intervaText;
        private System.Windows.Forms.Label intervalLab;
        private System.Windows.Forms.CheckBox cpuLoad;
        private System.Windows.Forms.CheckBox cpuTemp;
        private System.Windows.Forms.CheckBox gpuLoad;
        private System.Windows.Forms.CheckBox gpuTemp;
        private System.Windows.Forms.Label cpuLoadVal;
        private System.Windows.Forms.Label cpuTempVal;
        private System.Windows.Forms.Label gpuLoadVal;
        private System.Windows.Forms.Label gpuTempVal;
        private System.Windows.Forms.Label valInter;
        private System.Windows.Forms.CheckBox ramUsed;
        private System.Windows.Forms.Label ramUsedVal;
        private System.Windows.Forms.Label debugLabel;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button DisconnButton;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label label3;
    }
}

