namespace 计时器
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.rdoStopwatch = new System.Windows.Forms.RadioButton();
            this.rdoTimer = new System.Windows.Forms.RadioButton();
            this.rdoTime = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(36, 163);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(77, 42);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(155, 163);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(77, 42);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Pause";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(98, 116);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(80, 18);
            this.lbTime.TabIndex = 2;
            this.lbTime.Text = "00:00:00";
            // 
            // rdoStopwatch
            // 
            this.rdoStopwatch.AutoSize = true;
            this.rdoStopwatch.Checked = true;
            this.rdoStopwatch.Location = new System.Drawing.Point(-1, 27);
            this.rdoStopwatch.Name = "rdoStopwatch";
            this.rdoStopwatch.Size = new System.Drawing.Size(114, 22);
            this.rdoStopwatch.TabIndex = 4;
            this.rdoStopwatch.TabStop = true;
            this.rdoStopwatch.Text = "Stopwatch";
            this.rdoStopwatch.UseVisualStyleBackColor = true;
            this.rdoStopwatch.CheckedChanged += new System.EventHandler(this.rdoStopwatch_CheckedChanged);
            // 
            // rdoTimer
            // 
            this.rdoTimer.AutoSize = true;
            this.rdoTimer.Location = new System.Drawing.Point(119, 27);
            this.rdoTimer.Name = "rdoTimer";
            this.rdoTimer.Size = new System.Drawing.Size(78, 22);
            this.rdoTimer.TabIndex = 5;
            this.rdoTimer.Text = "Timer";
            this.rdoTimer.UseVisualStyleBackColor = true;
            this.rdoTimer.CheckedChanged += new System.EventHandler(this.rdoTimer_CheckedChanged);
            // 
            // rdoTime
            // 
            this.rdoTime.AutoSize = true;
            this.rdoTime.Location = new System.Drawing.Point(203, 27);
            this.rdoTime.Name = "rdoTime";
            this.rdoTime.Size = new System.Drawing.Size(69, 22);
            this.rdoTime.TabIndex = 6;
            this.rdoTime.Text = "Time";
            this.rdoTime.UseVisualStyleBackColor = true;
            this.rdoTime.CheckedChanged += new System.EventHandler(this.rdoTime_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1min",
            "3min",
            "5min",
            "10min",
            "20min",
            "30min",
            "60min",
            "90min"});
            this.comboBox1.Location = new System.Drawing.Point(78, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 26);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(101, 233);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(77, 42);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 307);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rdoTime);
            this.Controls.Add(this.rdoTimer);
            this.Controls.Add(this.rdoStopwatch);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnStart;
        internal System.Windows.Forms.Button btnStop;
        internal System.Windows.Forms.Label lbTime;
        internal System.Windows.Forms.RadioButton rdoStopwatch;
        internal System.Windows.Forms.RadioButton rdoTimer;
        internal System.Windows.Forms.RadioButton rdoTime;
        internal System.Windows.Forms.ComboBox comboBox1;
        internal System.Windows.Forms.Button btnReset;
    }
}

