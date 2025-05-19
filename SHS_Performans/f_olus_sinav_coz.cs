using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace SHS_Performans
{
    public partial class f_olus_sinav_coz : Form
    {
        private string testAdi;

        private int soruIndex = 0;

        private List<olus_soru> sorular = new List<olus_soru>();
        private List<string> kullaniciCevaplari = new List<string>();
        public f_olus_sinav_coz(string testAdi)
        {
            InitializeComponent();
            this.testAdi = testAdi;

            TestYukle();
            SoruGoster();
        }

        private void TestYukle()
        {
            string dosyaYolu = $"{testAdi}.xml"; // Örn: "Matematik1.xml"

            if (!File.Exists(dosyaYolu))
            {
                MessageBox.Show("Test dosyası bulunamadı!");
                this.Close();
                return;
            }

            XDocument xdoc = XDocument.Load(dosyaYolu);

            sorular = xdoc.Descendants("Soru")
                .Select(x => new olus_soru
                {
                    SoruMetni = x.Element("Metin")?.Value,
                    SecenekA = x.Element("A")?.Value,
                    SecenekB = x.Element("B")?.Value,
                    SecenekC = x.Element("C")?.Value,
                    SecenekD = x.Element("D")?.Value,
                    SecenekE = x.Element("E")?.Value,
                    DogruCevap = x.Element("Dogru")?.Value
                }).ToList();
        }

        private void SoruGoster()
        {
            if (soruIndex >= sorular.Count)
            {
                TestiBitir();
                return;
            }

            var soru = sorular[soruIndex];
            lblSoru.Text = soru.SoruMetni;


            rdA.Text = soru.SecenekA;
            rdB.Text = soru.SecenekB;
            rdC.Text = soru.SecenekC;
            rdD.Text = soru.SecenekD;
            rdE.Text = soru.SecenekE;

            // Önceki seçimi temizle
            rdA.Checked = rdB.Checked = rdC.Checked = rdD.Checked = rdE.Checked = false;
        }
        private void f_olus_sinav_coz_Load(object sender, EventArgs e)
        {

        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            string secilen = "";

            if (rdA.Checked) secilen = "A";
            else if (rdB.Checked) secilen = "B";
            else if (rdC.Checked) secilen = "C";
            else if (rdD.Checked) secilen = "D";
            else if (rdE.Checked) secilen = "E";

            kullaniciCevaplari.Add(secilen);

            soruIndex++;
            SoruGoster();
        }

        private void TestiBitir()
        {
            int dogru = 0;
            for (int i = 0; i < sorular.Count; i++)
            {
                if (kullaniciCevaplari[i] == sorular[i].DogruCevap)
                    dogru++;
            }

            int yanlis = sorular.Count - dogru;

            MessageBox.Show($"Test Bitti!\nDoğru: {dogru}\nYanlış: {yanlis}", "Sonuç");

            this.Close();
        }
    }
}
