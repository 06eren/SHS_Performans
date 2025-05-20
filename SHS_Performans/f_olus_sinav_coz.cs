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
            string dosyaYolu = Path.Combine(Application.StartupPath, "testler", $"{testAdi}.xml");

            if (!File.Exists(dosyaYolu))
            {
                MessageBox.Show("Test dosyası bulunamadı!");
                this.Close();
                return;
            }

            XDocument xdoc = XDocument.Load(dosyaYolu);

            var sorularElement = xdoc.Root.Element("Sorular");
            if (sorularElement == null)
            {
                MessageBox.Show("Sorular bölümü XML'de bulunamadı!");
                this.Close();
                return;
            }

            sorular = sorularElement.Elements("Soru")
                .Select(x => new olus_soru
                {
                    SoruMetni = x.Element("SoruMetni")?.Value ?? "",
                    SecenekA = x.Element("SecenekA")?.Value ?? "",
                    SecenekB = x.Element("SecenekB")?.Value ?? "",
                    SecenekC = x.Element("SecenekC")?.Value ?? "",
                    SecenekD = x.Element("SecenekD")?.Value ?? "",
                    SecenekE = x.Element("SecenekE")?.Value ?? "",
                    DogruCevap = x.Element("DogruCevap")?.Value ?? ""
                }).ToList();


        }

        private void SoruGoster()
        {
            if (soruIndex >= sorular.Count)
            {
                TestiBitir();
                return;
            }

            var olus_Soru = sorular[soruIndex];

            lblSoru.Text = olus_Soru.SoruMetni;
            rdA.Text = "A-) " + olus_Soru.SecenekA;
            rdB.Text = "B-) " + olus_Soru.SecenekB;
            rdC.Text = "C-) " + olus_Soru.SecenekC;
            rdD.Text = "D-) " + olus_Soru.SecenekD;
            rdE.Text = "E-) " + olus_Soru.SecenekE;

            rdA.Checked = rdB.Checked = rdC.Checked = rdD.Checked = rdE.Checked = false;
        }
        private void f_olus_sinav_coz_Load(object sender, EventArgs e)
        {
            CenterToScreen();
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
