using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace SHS_Performans
{
    public partial class SinavOlusturma : Form
    {
        List<olus_soru> sorular = new();


        public SinavOlusturma()
        {
            InitializeComponent();

        }
        public SinavOlusturma(string adi)
        {
            InitializeComponent();
        }


        private void SinavOlusturma_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void txtSoru_Click(object sender, EventArgs e)
        {

        }

        private void txtSoru_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoru_Click_1(object sender, EventArgs e)
        {
            txtSoru.Text = "";
        }
       


        private void button_SoruKaydet_Click(object sender, EventArgs e)
        {
            string dogruSecenek = "";
            if (rdA.Checked) dogruSecenek = "A";
            else if (rdB.Checked) dogruSecenek = "B";
            else if (rdC.Checked) dogruSecenek = "C";
            else if (rdD.Checked) dogruSecenek = "D";
            else if (rdE.Checked) dogruSecenek = "E";

            if (string.IsNullOrWhiteSpace(txtSoru.Text) || string.IsNullOrWhiteSpace(dogruSecenek))
            {
                MessageBox.Show("Soru metni ve doğru seçenek seçilmelidir.");
                return;
            }

            olus_soru soru = new olus_soru
            {
                SoruMetni = txtSoru.Text,
                SecenekA = txtA.Text,
                SecenekB = txtB.Text,
                SecenekC = txtC.Text,
                SecenekD = txtD.Text,
                SecenekE = txtE.Text,
                DogruCevap = dogruSecenek
            };

            sorular.Add(soru);
            lstSorular.Items.Add($"Soru {sorular.Count}");

            // Alanları temizle
            txtSoru.Clear();
            txtA.Clear(); txtB.Clear(); txtC.Clear(); txtD.Clear(); txtE.Clear();
            rdA.Checked = rdB.Checked = rdC.Checked = rdD.Checked = rdE.Checked = false;
        }

        private void Temizle()
        {
            txtSoru.Clear();
            txtA.Clear(); txtB.Clear(); txtC.Clear(); txtD.Clear(); txtE.Clear();
            rdA.Checked = false; rdB.Checked = false; rdC.Checked = false; rdD.Checked = false; rdE.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSinavAdi.Text))
            {
                MessageBox.Show("Lütfen test adı giriniz.");
                return;
            }

            string testAdi = txtSinavAdi.Text.Trim();
            string klasor = Path.Combine(Application.StartupPath, "testler");
            Directory.CreateDirectory(klasor);
            string dosyaYolu = Path.Combine(klasor, testAdi + ".xml");

            XmlSerializer serializer = new XmlSerializer(typeof(List<olus_soru>));
            using (StreamWriter writer = new StreamWriter(dosyaYolu))
            {
                serializer.Serialize(writer, sorular);
            }

            // Ana formdaki butonları güncelle
            if (this.Owner is fanamenu anaForm)
            {
                anaForm.TestEkle(testAdi);
            }

            MessageBox.Show("Test başarıyla kaydedildi.");
            this.Close();
        }
    }
    
}
