using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 计时器
{
    internal class StopwatchMode: Mode
    {
        public override void Init(Form1 form)
        {
            form.btnStart.Visible = true;
            form.btnStop.Visible = true;
            form.btnReset.Visible = true;
            base.Init(form);
        }

        public override void Start()
        {
            this.form.btnStop.Enabled = true;
            this.form.btnStart.Enabled = false;
            this.form.btnReset.Enabled = false;
            base.Start();
        }

        public override void Stop()
        {
            this.form.btnStop.Enabled = false;
            this.form.btnStart.Enabled = true;
            this.form.btnReset.Enabled = true;
            base.Stop();
        }

        public override void Update()
        {
            seconds++;
            string hours = (seconds / 3600).ToString().PadLeft(2, '0');
            int leftMinutes = seconds % 3600;

            string minutes = (leftMinutes / 60).ToString().PadLeft(2, '0');
            string secondsStr = (leftMinutes % 60).ToString().PadLeft(2, '0');

            this.display = $"{hours}:{minutes}:{secondsStr}";
            base.Update();
        }

        
    }
}
