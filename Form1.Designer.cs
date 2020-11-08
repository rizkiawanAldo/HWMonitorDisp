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
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comListText
            // 
            this.comListText.FormattingEnabled = true;
            this.comListText.Location = new System.Drawing.Point(133, 37);
            this.comListText.Name = "comListText";
            this.comListText.Size = new System.Drawing.Size(121, 28);
            this.comListText.TabIndex = 0;
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
            this.scanButton.Location = new System.Drawing.Point(269, 36);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(75, 56);
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
            // 
            // intervalLab
            // 
            this.intervalLab.AutoSize = true;
            this.intervalLab.Location = new System.Drawing.Point(383, 12);
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
            // 
            // cpuTemp
            // 
            this.cpuTemp.AutoSize = true;
            this.cpuTemp.Location = new System.Drawing.Point(387, 81);
            this.cpuTemp.Name = "cpuTemp";
            this.cpuTemp.Size = new System.Drawing.Size(112, 24);
            this.cpuTemp.TabIndex = 7;
            this.cpuTemp.Text = "CPU Temp";
            this.cpuTemp.UseVisualStyleBackColor = true;
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
            this.gpuTemp.Location = new System.Drawing.Point(387, 141);
            this.gpuTemp.Name = "gpuTemp";
            this.gpuTemp.Size = new System.Drawing.Size(114, 24);
            this.gpuTemp.TabIndex = 9;
            this.gpuTemp.Text = "GPU Temp";
            this.gpuTemp.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
    }
}

