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
    public partial class tyt_messagebox_fenbil : Form
    {
        public tyt_messagebox_fenbil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // 5
        {


            var fanamenu = Application.OpenForms["fanamenu"];
            if (fanamenu != null)
            {
                fanamenu.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e) // 10
        {


            var fanamenu = Application.OpenForms["fanamenu"];
            if (fanamenu != null)
            {
                fanamenu.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e) //20
        {


            var fanamenu = Application.OpenForms["fanamenu"];
            if (fanamenu != null)
            {
                fanamenu.Close();
            }
        }

        private void tyt_messagebox_fenbil_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
