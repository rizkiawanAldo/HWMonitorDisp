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
            this.SuspendLayout();
            // 
            // comListText
            // 
            this.comListText.FormattingEnabled = true;
            this.comListText.Location = new System.Drawing.Point(89, 24);
            this.comListText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comListText.Name = "comListText";
            this.comListText.Size = new System.Drawing.Size(82, 21);
            this.comListText.TabIndex = 0;
            this.comListText.SelectedIndexChanged += new System.EventHandler(this.comListText_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port :";
            // 
            // portDesc
            // 
            this.portDesc.AutoSize = true;
            this.portDesc.Location = new System.Drawing.Point(19, 47);
            this.portDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.portDesc.Name = "portDesc";
            this.portDesc.Size = new System.Drawing.Size(66, 13);
            this.portDesc.TabIndex = 2;
            this.portDesc.Text = "Description :";
            // 
            // scanButton
            // 
            this.scanButton.Location = new System.Drawing.Point(179, 23);
            this.scanButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(50, 36);
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
            this.intervaText.Location = new System.Drawing.Point(305, 8);
            this.intervaText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.intervaText.Name = "intervaText";
            this.intervaText.Size = new System.Drawing.Size(68, 20);
            this.intervaText.TabIndex = 4;
            this.intervaText.TextChanged += new System.EventHandler(this.intervaText_TextChanged);
            // 
            // intervalLab
            // 
            this.intervalLab.AutoSize = true;
            this.intervalLab.Location = new System.Drawing.Point(255, 8);
            this.intervalLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.intervalLab.Name = "intervalLab";
            this.intervalLab.Size = new System.Drawing.Size(48, 13);
            this.intervalLab.TabIndex = 5;
            this.intervalLab.Text = "Interval :";
            // 
            // cpuLoad
            // 
            this.cpuLoad.AutoSize = true;
            this.cpuLoad.Location = new System.Drawing.Point(258, 33);
            this.cpuLoad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cpuLoad.Name = "cpuLoad";
            this.cpuLoad.Size = new System.Drawing.Size(75, 17);
            this.cpuLoad.TabIndex = 6;
            this.cpuLoad.Text = "CPU Load";
            this.cpuLoad.UseVisualStyleBackColor = true;
            // 
            // cpuTemp
            // 
            this.cpuTemp.AutoSize = true;
            this.cpuTemp.Location = new System.Drawing.Point(258, 53);
            this.cpuTemp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cpuTemp.Name = "cpuTemp";
            this.cpuTemp.Size = new System.Drawing.Size(78, 17);
            this.cpuTemp.TabIndex = 7;
            this.cpuTemp.Text = "CPU Temp";
            this.cpuTemp.UseVisualStyleBackColor = true;
            // 
            // gpuLoad
            // 
            this.gpuLoad.AutoSize = true;
            this.gpuLoad.Location = new System.Drawing.Point(258, 72);
            this.gpuLoad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpuLoad.Name = "gpuLoad";
            this.gpuLoad.Size = new System.Drawing.Size(76, 17);
            this.gpuLoad.TabIndex = 8;
            this.gpuLoad.Text = "GPU Load";
            this.gpuLoad.UseVisualStyleBackColor = true;
            // 
            // gpuTemp
            // 
            this.gpuTemp.AutoSize = true;
            this.gpuTemp.Location = new System.Drawing.Point(258, 92);
            this.gpuTemp.Margin = new System.Windows.Forms.Padding(2);
            this.gpuTemp.Name = "gpuTemp";
            this.gpuTemp.Size = new System.Drawing.Size(79, 17);
            this.gpuTemp.TabIndex = 9;
            this.gpuTemp.Text = "GPU Temp";
            this.gpuTemp.UseVisualStyleBackColor = true;
            // 
            // cpuLoadVal
            // 
            this.cpuLoadVal.AutoSize = true;
            this.cpuLoadVal.Location = new System.Drawing.Point(349, 34);
            this.cpuLoadVal.Name = "cpuLoadVal";
            this.cpuLoadVal.Size = new System.Drawing.Size(10, 13);
            this.cpuLoadVal.TabIndex = 11;
            this.cpuLoadVal.Text = "-";
            // 
            // cpuTempVal
            // 
            this.cpuTempVal.AutoSize = true;
            this.cpuTempVal.Location = new System.Drawing.Point(349, 54);
            this.cpuTempVal.Name = "cpuTempVal";
            this.cpuTempVal.Size = new System.Drawing.Size(10, 13);
            this.cpuTempVal.TabIndex = 12;
            this.cpuTempVal.Text = "-";
            // 
            // gpuLoadVal
            // 
            this.gpuLoadVal.AutoSize = true;
            this.gpuLoadVal.Location = new System.Drawing.Point(349, 73);
            this.gpuLoadVal.Name = "gpuLoadVal";
            this.gpuLoadVal.Size = new System.Drawing.Size(10, 13);
            this.gpuLoadVal.TabIndex = 13;
            this.gpuLoadVal.Text = "-";
            // 
            // gpuTempVal
            // 
            this.gpuTempVal.AutoSize = true;
            this.gpuTempVal.Location = new System.Drawing.Point(349, 93);
            this.gpuTempVal.Name = "gpuTempVal";
            this.gpuTempVal.Size = new System.Drawing.Size(10, 13);
            this.gpuTempVal.TabIndex = 14;
            this.gpuTempVal.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

