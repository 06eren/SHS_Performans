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
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;

namespace SHS_Performans
{
    public partial class SinavOlusturma : Form
    {
        List<olus_soru> sorular = new List<olus_soru>();
        public fanamenu AnaForm { get; set; }
        public string sinavAdi;

        public SinavOlusturma(string adi)
        {
            InitializeComponent();
            this.sinavAdi = sinavAdi;
            if (!string.IsNullOrWhiteSpace(sinavAdi))
                txtSinavAdi.Text = sinavAdi;
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
            if (string.IsNullOrWhiteSpace(txtSinavAdi.Text))
            {
                MessageBox.Show("Lütfen sınav adını giriniz.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSoru.Text) ||
                string.IsNullOrWhiteSpace(txtA.Text) ||
                string.IsNullOrWhiteSpace(txtB.Text) ||
                string.IsNullOrWhiteSpace(txtC.Text) ||
                string.IsNullOrWhiteSpace(txtD.Text) ||
                string.IsNullOrWhiteSpace(txtE.Text))
            {
                MessageBox.Show("Lütfen tüm şıkları ve soruyu doldurunuz.");
                return;
            }

            string dogruCevap = null;
            if (rdA.Checked) dogruCevap = "A";
            else if (rdB.Checked) dogruCevap = "B";
            else if (rdC.Checked) dogruCevap = "C";
            else if (rdD.Checked) dogruCevap = "D";
            else if (rdE.Checked) dogruCevap = "E";

            if (dogruCevap == null)
            {
                MessageBox.Show("Lütfen doğru cevabı seçiniz.");
                return;
            }

            olus_soru yeniSoru = new olus_soru()
            {
                SoruMetni = txtSoru.Text.Trim(),
                SecenekA = txtA.Text,
                SecenekB = txtB.Text,
                SecenekC = txtC.Text,
                SecenekD = txtD.Text,
                SecenekE = txtE.Text,
                DogruCevap = dogruCevap
            };

            sorular.Add(yeniSoru);

            lstSorular.Items.Add($"Soru {sorular.Count}: {yeniSoru.SoruMetni.Substring(0, Math.Min(30, yeniSoru.SoruMetni.Length))}...");
            Temizle();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSinavAdi.Text))
            {
                MessageBox.Show("Lütfen sınav adını giriniz.");
                return;
            }

            if (sorular.Count < 5)
            {
                MessageBox.Show("En az 5 soru girilmelidir.");
                return;
            }

            if (sorular.Count > 20)
            {
                MessageBox.Show("En fazla 20 soru girilebilir.");
                return;
            }

            string klasor = Path.Combine(Application.StartupPath, "testler");
            if (!Directory.Exists(klasor))
                Directory.CreateDirectory(klasor);

            string dosyaYolu = Path.Combine(klasor, txtSinavAdi.Text + ".xml");

            XElement sinavXml = new XElement("testler",
                new XElement("Ad", txtSinavAdi.Text),
                new XElement("Sorular",
                    new List<XElement>(
                        sorular.ConvertAll(s => new XElement("Soru",
                            new XElement("SoruMetni", s.SoruMetni),
                            new XElement("SecenekA", s.SecenekA),
                            new XElement("SecenekB", s.SecenekB),
                            new XElement("SecenekC", s.SecenekC),
                            new XElement("SecenekD", s.SecenekD),
                            new XElement("SecenekE", s.SecenekE),
                            new XElement("DogruCevap", s.DogruCevap)
                        ))
                    )
                )
            );

            sinavXml.Save(dosyaYolu);

            
            if (Owner is fanamenu anaForm)
                anaForm.TestEkle(txtSinavAdi.Text);

            MessageBox.Show("Sınav başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close(); ;
        }

        private void Temizle()
        {
            txtSoru.Clear();
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtD.Clear();
            txtE.Clear();
            rdA.Checked = false;
            rdB.Checked = false;
            rdC.Checked = false;
            rdD.Checked = false;
            rdE.Checked = false;
        }
    }
}
