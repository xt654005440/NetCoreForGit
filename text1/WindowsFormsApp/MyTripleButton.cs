using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public class MyTripleButton : System.Windows.Forms.Button
    {
        //计数变量
        int times = 0;
        //设置计时器
        Timer time = new Timer();

        //public DGTripleClick dg
        public event DGTripleClick dg;

        public MyTripleButton()
        {
            this.Text = "三击按钮";
            time.Interval = 1000;
            time.Tick += Time_Tick;
            time.Start();
            base.Click += MyTripleButton_Click;
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            //清空计数
            times = 0;
        }

        private void MyTripleButton_Click(object sender, EventArgs e)
        {
            if (times < 2)
            {
                if (times == 0)
                {
                    //第一次点击，同时启动计时器
                    time.Start();
                }

                times++;
            }
            else
            {
                //执行业务代码
                if (dg != null)
                {
                    dg.Invoke(DateTime.Now);
                }
                //清空计数
                times = 0;
                //当完成三连击的时候，应该及时停止计时器，防止计数器进入下一个时段循环使得再次触发三连的次数小于三次
                time.Stop();
            }
        }




    }
}
