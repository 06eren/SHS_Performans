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
    public partial class tyt_messagebox_temelmat : Form
    {
        public tyt_messagebox_temelmat()
        {
            InitializeComponent();
        }

        private void tyt_messagebox_temelmat_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f_tyt_temelmat5 mat5 = new f_tyt_temelmat5();
            mat5.Show();
            this.Close();

            var fanamenu = Application.OpenForms["fanamenu"];
            if (fanamenu != null)
            {
                fanamenu.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f_tyt_temelmat10 mat10 = new f_tyt_temelmat10();
            mat10.Show();
            this.Close();

            var fanamenu = Application.OpenForms["fanamenu"];
            if (fanamenu != null)
            {
                fanamenu.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f_tyt_temelmat mat = new f_tyt_temelmat();
            mat.Show();
            this.Close();

            var fanamenu = Application.OpenForms["fanamenu"];
            if (fanamenu != null)
            {
                fanamenu.Close();
            }
        }
    }
}
