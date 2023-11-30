using System;

namespace 计时器
{
    internal class TimerMode : Mode
    {
        public override void Init(Form1 form)
        {
            form.btnStart.Visible = true;
            form.btnStop.Visible = true;
            form.btnReset.Visible = true;
            form.comboBox1.Enabled = true;
            base.Init(form);
            Update();
            form.comboBox1.SelectedIndexChanged -= ComboBox1_SelectedIndexChanged;
            form.comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitSeconds();
            Update();
        }

        public override void Start()
        {
            this.form.comboBox1.Enabled = false;
            this.form.btnStop.Enabled = true;
            this.form.btnStart.Enabled = false;
            this.form.btnReset.Enabled = true;
            this. InitSeconds();
            this.Update();
            base.Start();
        }

        private void InitSeconds()
        {
            if (this.form.comboBox1.SelectedIndex < 0)
            {
                this.form.comboBox1.SelectedIndex = 0;
            }
            var selected = this.form.comboBox1.SelectedItem.ToString();
            seconds = Convert.ToInt32(selected.Split('m')[0]) * 60;
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
            if (seconds <= 0)
            {
                this.Exit();
                return;
            }
            string hours = (seconds / 3600).ToString().PadLeft(2, '0');
            int leftMinutes = seconds % 3600;

            string minutes = (leftMinutes / 60).ToString().PadLeft(2, '0');
            string secondsStr = (leftMinutes % 60).ToString().PadLeft(2, '0');

            this.display = $"{hours}:{minutes}:{secondsStr}";
            
            
            
            seconds--;

            base.Update();
            
        }

        public override void Exit()
        {
            base.Exit();
            InitSeconds();
            this.form.btnStart.Enabled = true;
            Update();
            this.form.comboBox1.Enabled = true;
            seconds = 0;
        }
    }
}
