using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace 计时器
{
    public partial class Form1 : Form
    {
        Mode activeMode;

        public Form1()
        {
            InitializeComponent();
            activeMode = new StopwatchMode();
            activeMode.Init(this);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
           activeMode.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            activeMode.Stop();
        }

        private void rdoTimer_CheckedChanged(object sender, EventArgs e)
        {  if (rdoTimer.Checked)
            {
                activeMode = new TimerMode();
                activeMode.Init(this);
            }
            else
            {
                activeMode.Exit();
            }

            this.comboBox1.Visible = rdoTimer.Checked;
        }

        private void rdoTime_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTime.Checked)
            {
                activeMode = new TimeMode();
                activeMode.Init(this);
            }
            else
            {
                activeMode.Exit();
            }
        }

        private void rdoStopwatch_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoStopwatch.Checked)
            {
                activeMode = new StopwatchMode();
                activeMode.Init(this);
            }
            else
            {
                activeMode.Exit();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            activeMode.Exit();
        }
    }
}
