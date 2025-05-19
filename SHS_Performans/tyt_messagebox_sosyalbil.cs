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
    public partial class tyt_messagebox_sosyalbil : Form
    {
        public tyt_messagebox_sosyalbil()
        {
            InitializeComponent();
        }

        private void tyt_messagebox_sosyalbil_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f_tyt_sosyalbil5 sos5 = new f_tyt_sosyalbil5();
            sos5.Show();
            this.Close();

            var fanamenu = Application.OpenForms["fanamenu"];
            if (fanamenu != null)
            {
                fanamenu.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f_tyt_sosyalbil10 sos10 = new f_tyt_sosyalbil10();
            sos10.Show();
            this.Close();

            var fanamenu = Application.OpenForms["fanamenu"];
            if (fanamenu != null)
            {
                fanamenu.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f_tyt_sosyalbil sos = new f_tyt_sosyalbil();
            sos.Show();
            this.Close();

            var fanamenu = Application.OpenForms["fanamenu"];
            if (fanamenu != null)
            {
                fanamenu.Close();
            }
        }
    }
}
