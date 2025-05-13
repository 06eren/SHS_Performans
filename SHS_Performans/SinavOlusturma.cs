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

namespace SHS_Performans
{
    public partial class SinavOlusturma : Form
    {
        List<Question> sorular = new List<Question>();
        int soruIndex = 0;

        public SinavOlusturma()
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
        public class Question
        {
            public string SoruMetni { get; set; }
            public string CevapA { get; set; }
            public string CevapB { get; set; }
            public string CevapC { get; set; }
            public string CevapD { get; set; }
            public string CevapE { get; set; }
            public string DogruCevap { get; set; }
        }

        private void button_SoruKaydet_Click(object sender, EventArgs e)
        {
            string soru = txtSoru.Text.Trim();
            string A = txtA.Text.Trim();
            string B = txtB.Text.Trim();
            string C = txtC.Text.Trim();
            string D = txtD.Text.Trim();
            string E = txtE.Text.Trim();

            string dogru = "";
            if (rdA.Checked) dogru = "A";
            if (rdB.Checked) dogru = "B";
            if (rdC.Checked) dogru = "C";
            if (rdD.Checked) dogru = "D";
            if (rdE.Checked) dogru = "E";

            if (string.IsNullOrEmpty(soru) || string.IsNullOrEmpty(dogru))
            {
                MessageBox.Show("Soru ve doğru cevap boş olamaz.");
                return;
            }

            var q = new Question
            {
                SoruMetni = soru,
                CevapA = A,
                CevapB = B,
                CevapC = C,
                CevapD = D,
                CevapE = E,
                DogruCevap = dogru
            };

            sorular.Add(q);
            lstSorular.Items.Add($"Soru {soruIndex + 1}: {soru} ({dogru})");
            soruIndex++;
            Temizle();
        }

        private void Temizle()
        {
            txtSoru.Clear();
            txtA.Clear(); txtB.Clear(); txtC.Clear(); txtD.Clear(); txtE.Clear();
            rdA.Checked = false; rdB.Checked = false; rdC.Checked = false; rdD.Checked = false; rdE.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sorular.Count < 5)
            {
                MessageBox.Show("En az 5 soru girmelisiniz.");
                return;
            }

            string sinavAdi = txtSinavAdi.Text.Trim();
            if (string.IsNullOrEmpty(sinavAdi))
            {
                MessageBox.Show("Sınav adı girin.");
                return;
            }

            string path = Path.Combine("Sinavlar", $"{sinavAdi}.xml");
            Directory.CreateDirectory("Sinavlar");

            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("sinav");
            doc.AppendChild(root);

            XmlElement sinavAdEl = doc.CreateElement("sinavAdi");
            sinavAdEl.InnerText = sinavAdi;
            root.AppendChild(sinavAdEl);

            foreach (var q in sorular)
            {
                XmlElement soruEl = doc.CreateElement("soru");
                soruEl.AppendChild(Yap("metin", q.SoruMetni));
                soruEl.AppendChild(Yap("cevapA", q.CevapA));
                soruEl.AppendChild(Yap("cevapB", q.CevapB));
                soruEl.AppendChild(Yap("cevapC", q.CevapC));
                soruEl.AppendChild(Yap("cevapD", q.CevapD));
                soruEl.AppendChild(Yap("cevapE", q.CevapE));
                soruEl.AppendChild(Yap("dogru", q.DogruCevap));
                root.AppendChild(soruEl);
            }

            XmlElement Yap(string ad, string deger)
            {
                XmlElement el = doc.CreateElement(ad);
                el.InnerText = deger;
                return el;
            }

            doc.Save(path);

            // Ana menüde buton göster
            

            MessageBox.Show("Sınav kaydedildi!");
            this.Close();
        }
    }
}
