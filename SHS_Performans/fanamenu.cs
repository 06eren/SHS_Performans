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
using System.IO;

namespace SHS_Performans
{
    public partial class fanamenu : Form
    {
        List<Button> testButonlari;
        public fanamenu(string KarsilamaKullaniciAdi)
        {
            InitializeComponent();
            girisUserName.Text = KarsilamaKullaniciAdi;


            // Butonları listeye al
            testButonlari = new List<Button> { olus_1, olus_2, olus_3, olus_4, olus_5 };

            // Hepsini gizle
            foreach (var btn in testButonlari)
            {
                btn.Visible = false;
            }

            // Daha önce oluşturulmuş testleri yükle
            TestleriYukle();
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
            olus_label.Visible = false;
            //SHS
            olus_1.Click += btnSinav_Click;
            olus_2.Click += btnSinav_Click;
            olus_3.Click += btnSinav_Click;
            olus_4.Click += btnSinav_Click;
            olus_5.Click += btnSinav_Click;



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

        private void btnSinav_Click(object sender, EventArgs e)
        {
            Button tiklananButon = sender as Button;

            if (tiklananButon != null && tiklananButon.Visible)
            {
                string sinavAdi = tiklananButon.Text;

                SinavOlusturma cozForm = new SinavOlusturma(sinavAdi);
                cozForm.ShowDialog();
            }
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
            tyt_messagebox_turkce mesaj = new tyt_messagebox_turkce();
            mesaj.ShowDialog(); 
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
                var forms = new SinavOlusturma();
                forms.Owner = this;
                forms.ShowDialog();
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi", "SHS System", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void ayt_sosyal_button_Click(object sender, EventArgs e)
        {
            f_ayt_sosyalbil sosyalbil = new f_ayt_sosyalbil();
            sosyalbil.Show();
            this.Hide();
        }

        private void ayt_mat_button_Click(object sender, EventArgs e)
        {
            f_ayt_matematik mat = new f_ayt_matematik();
            mat.Show();
            this.Hide();
        }

        private void ayt_fen_button_Click(object sender, EventArgs e)
        {
            f_ayt_fenBil fen = new f_ayt_fenBil();
            fen.Show();
            this.Hide();

        }

        public void TestEkle(string testAdi)
        {
            // İlk boş butonu bul
            var bosButon = testButonlari.FirstOrDefault(b => !b.Visible);

            if (bosButon != null)
            {
                bosButon.Text = testAdi;
                bosButon.Visible = true;
            }
            else
            {
                MessageBox.Show("Maksimum 5 test sınırı var.");
            }
        }

        private void TestleriYukle()
        {
            string klasor = Path.Combine(Application.StartupPath, "testler");
            if (!Directory.Exists(klasor)) return;

            string[] dosyalar = Directory.GetFiles(klasor, "*.xml");

            for (int i = 0; i < Math.Min(dosyalar.Length, testButonlari.Count); i++)
            {
                string testAdi = Path.GetFileNameWithoutExtension(dosyalar[i]);
                testButonlari[i].Text = testAdi;
                testButonlari[i].Visible = true;
            }
        }

        private void olus_1_Click(object sender, EventArgs e) => TestCoz(olus_1.Text);
        private void olus_2_Click(object sender, EventArgs e) => TestCoz(olus_2.Text);
        private void olus_3_Click(object sender, EventArgs e) => TestCoz(olus_3.Text);
        private void olus_4_Click(object sender, EventArgs e) => TestCoz(olus_4.Text);
        private void olus_5_Click(object sender, EventArgs e) => TestCoz(olus_5.Text);

        private void TestCoz(string testAdi)
        {
            var frm = new f_olus_sinav_coz(testAdi); // çözülecek sınav formu
            frm.ShowDialog();
        }
    }
}
