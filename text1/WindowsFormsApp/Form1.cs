using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
            MyTripleButton myTripleBtn = new MyTripleButton();
            myTripleBtn.dg += MyClick;
            //myTripleBtn.dg += null;
            this.Controls.Add(myTripleBtn);
        }

        void MyClick(DateTime time)
        {
            MessageBox.Show("三连击的时间是：" + time.ToString());
        }
    }
}
