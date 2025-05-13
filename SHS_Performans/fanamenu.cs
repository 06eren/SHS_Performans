using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHS_Performans
{
    public partial class fanamenu : Form
    {
        public fanamenu(string KarsilamaKullaniciAdi)
        {
            InitializeComponent();
            girisUserName.Text = KarsilamaKullaniciAdi;
        }

        public fanamenu()
        {
        }

        private void fanamenu_Load(object sender, EventArgs e)
        {
            pictureBoxGiris.Visible = true;
            pictureBoxArka.Visible = false;
            label1_tyt_baslik.Visible = false;
            tyt_button1.Visible = false;
            tyt_button2.Visible = false;
            tyt_button3.Visible = false;
            tyt_button4.Visible = false;
            ayt_edebiyat_button.Visible = false;
            ayt_fen_button.Visible = false;
            ayt_label.Visible = false;
            ayt_mat_button.Visible = false;
            ayt_sosyal_button.Visible = false;
            tyt_button6.Visible = false;
            olus_1.Visible = false;
            olus_2.Visible = false;
            olus_3.Visible = false;
            olus_4.Visible = false;
            olus_5.Visible = false;
            olus_cikis.Visible = false;
            olus_label.Visible=false;

            label1_tyt_baslik.BackColor = Color.Transparent;
            ayt_label.BackColor = Color.Transparent;


            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            girisUserName.BackColor = Color.Transparent;
            CenterToScreen();
            LinkLabekBattalgazi.LinkColor = Color.Black; LinkLabekBattalgazi.Links.Add(0, LinkLabekBattalgazi.Text.Length, "https://battalgazieml.meb.k12.tr/");
            LinkLabelGit.LinkColor = Color.Black; LinkLabelGit.Links.Add(0, LinkLabelGit.Text.Length, "https://github.com/06eren");
            LinkLabelInsta.LinkColor = Color.Black; LinkLabelInsta.Links.Add(0, LinkLabelInsta.Text.Length, "https://www.instagram.com/0adwen?igsh=MTh5bmVkbzBnNmltYg%3D%3D");
        }

        private void LinkLabelGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo(e.Link.LinkData.ToString()) { UseShellExecute = true });
        }

        private void LinkLabelInsta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo(e.Link.LinkData.ToString()) { UseShellExecute = true });
        }

        private void LinkLabekBattalgazi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo(e.Link.LinkData.ToString()) { UseShellExecute = true });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBoxGiris.Visible = false;
            pictureBoxArka.Visible = true;
            label1_tyt_baslik.Visible = true;
            tyt_button1.Visible = true;
            tyt_button2.Visible = true;
            tyt_button3.Visible = true;
            tyt_button4.Visible = true;
            tyt_button6.Visible = true;
            ayt_edebiyat_button.Visible = false;
            ayt_fen_button.Visible = false;
            ayt_label.Visible = false;
            ayt_mat_button.Visible = false;
            ayt_sosyal_button.Visible = false;
            olus_1.Visible = false;
            olus_2.Visible = false;
            olus_3.Visible = false;
            olus_4.Visible = false;
            olus_5.Visible = false;
            olus_cikis.Visible = false;
            olus_label.Visible = false;
        }

        private void tyt_button6_Click(object sender, EventArgs e)
        {
            pictureBoxGiris.Visible = true;
            pictureBoxArka.Visible = false;
            label1_tyt_baslik.Visible = false;
            tyt_button1.Visible = false;
            tyt_button2.Visible = false;
            tyt_button3.Visible = false;
            tyt_button4.Visible = false;
            tyt_button6.Visible = false;
            ayt_edebiyat_button.Visible = false;
            ayt_fen_button.Visible = false;
            ayt_label.Visible = false;
            ayt_mat_button.Visible = false;
            ayt_sosyal_button.Visible = false;
            olus_1.Visible = false;
            olus_2.Visible = false;
            olus_3.Visible = false;
            olus_4.Visible = false;
            olus_5.Visible = false;
            olus_cikis.Visible = false;
            olus_label.Visible = false;
        }

        private void tyt_button1_Click(object sender, EventArgs e)
        {
            f_tyt_turkce turkce = new f_tyt_turkce();
            turkce.Show();
            this.Hide();
        }

        private void tyt_button2_Click(object sender, EventArgs e)
        {
            f_tyt_temelmat mat = new f_tyt_temelmat();
            mat.Show();
            this.Hide();

        }

        private void tyt_button3_Click(object sender, EventArgs e)
        {
            f_tyt_sosyalbil bil = new f_tyt_sosyalbil();
            bil.Show();
            this.Hide();

        }

        private void tyt_button4_Click(object sender, EventArgs e)
        {
            f_tyt_fenbil fen = new f_tyt_fenbil();
            fen.Show();
            this.Hide();
        }

        private void tyt_button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBoxGiris.Visible = false;
            pictureBoxArka.Visible = true;
            tyt_button1.Visible = false;
            tyt_button2.Visible = false;
            tyt_button3.Visible = false;
            tyt_button4.Visible = false;
            tyt_button6.Visible = true;
            label1_tyt_baslik.Visible = false;
            ayt_edebiyat_button.Visible = true;
            ayt_fen_button.Visible = true;
            ayt_label.Visible = true;
            ayt_mat_button.Visible = true;
            ayt_sosyal_button.Visible = true;
            olus_1.Visible = false;
            olus_2.Visible = false;
            olus_3.Visible = false;
            olus_4.Visible = false;
            olus_5.Visible = false;
            olus_cikis.Visible = false;
            olus_label.Visible = false;
        }

        private void ayt_edebiyat_button_Click(object sender, EventArgs e)
        {
            f_ayt_edebiyat edebi = new f_ayt_edebiyat();
            edebi.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBoxGiris.Visible = false;
            pictureBoxArka.Visible = true;
            tyt_button1.Visible = false;
            tyt_button2.Visible = false;
            tyt_button3.Visible = false;
            tyt_button4.Visible = false;
            tyt_button6.Visible = true;
            label1_tyt_baslik.Visible = false;
            ayt_edebiyat_button.Visible = false;
            ayt_fen_button.Visible = false;
            ayt_label.Visible = false;
            ayt_mat_button.Visible = false;
            ayt_sosyal_button.Visible = false;
            olus_1.Visible = true;
            olus_2.Visible = true;
            olus_3.Visible = true;
            olus_4.Visible = true;
            olus_5.Visible = true;
            olus_cikis.Visible = true;
            olus_label.Visible = true;

            DialogResult = MessageBox.Show("Sınav oluşturmak için 'Evet' tuşuna basınız", "SHS System", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DialogResult == DialogResult.Yes)
            {
                SinavOlusturma sinav = new SinavOlusturma();
                sinav.Owner = this;
                sinav.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi","SHS System",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


        }

        private void olus_cikis_Click(object sender, EventArgs e)
        {
            pictureBoxGiris.Visible = true;
            pictureBoxArka.Visible = false;
            label1_tyt_baslik.Visible = false;
            tyt_button1.Visible = false;
            tyt_button2.Visible = false;
            tyt_button3.Visible = false;
            tyt_button4.Visible = false;
            ayt_edebiyat_button.Visible = false;
            ayt_fen_button.Visible = false;
            ayt_label.Visible = false;
            ayt_mat_button.Visible = false;
            ayt_sosyal_button.Visible = false;
            tyt_button6.Visible = false;
            olus_1.Visible = false;
            olus_2.Visible = false;
            olus_3.Visible = false;
            olus_4.Visible = false;
            olus_5.Visible = false;
            olus_cikis.Visible = false;
            olus_label.Visible = false;
        }
    }
}
