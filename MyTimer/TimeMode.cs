using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计时器
{
    internal class TimeMode: Mode
    {
        public override void Init(Form1 form)
        {
            form.btnStart.Visible = false;
            form.btnStop.Visible = false;
            form.btnReset.Visible = false;
            base.Init(form);
            this.Start();
        }

        public override void Update() 
        {
            this.display = DateTime.Now.ToString().Split(' ')[1];
            base.Update();
        }
    }
}
