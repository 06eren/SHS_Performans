using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHS_Performans
{
    public partial class tyt_messagebox_turkce : Form
    {
        public tyt_messagebox_turkce()
        {
            InitializeComponent();
        }

        private void tyt_messagebox_turkce_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void tyt_messagebox_turkce_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void tyt_messagebox_turkce_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f_tyt_turkce turkce = new f_tyt_turkce();
            turkce.Show();
            this.Hide();

            var fanamenu = Application.OpenForms["fanamenu"];
            if (fanamenu != null)
            {
                fanamenu.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f_tyt_turkce5 turkce5 = new f_tyt_turkce5();
            turkce5.Show();
            this.Close();

            var fanamenu = Application.OpenForms["fanamenu"];
            if (fanamenu != null)
            {
                fanamenu.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f_tyt_turkce10 turkce10 = new f_tyt_turkce10();
            turkce10.Show();
            this.Close();

            var fanamenu = Application.OpenForms["fanamenu"];
            if (fanamenu != null)
            {
                fanamenu.Close();
            }
        }
    }
}
