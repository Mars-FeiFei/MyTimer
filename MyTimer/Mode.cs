using System.Windows.Forms;

namespace 计时器
{
    internal  class Mode
    {
        protected int seconds = 0;

        Timer timer = new Timer();
        protected Form1 form;
        protected string display;
        public virtual void Init(Form1 form)
        {
            this.form = form;
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            form.btnStart.Enabled = true;
            form.btnReset.Enabled = false;
            form.btnStop.Enabled = false;
        }

        private void Timer_Tick(object sender, System.EventArgs e)
        {
            this.Update();
        }

        public virtual void Start()
        {
            timer?.Start();
        }
        public virtual void Stop()
        {
            timer?.Stop();
        }

        public virtual void Update()
        {
            this.form.lbTime.Text = display;
        }

        public virtual void Exit()
        {
            timer?.Stop();
            this.form.lbTime.Text = "00:00:00";
            seconds = 0;
        }
    }
}
