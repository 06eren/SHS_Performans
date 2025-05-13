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
    public partial class f_tyt_sosyalbil : Form
    {
        private List<Question> questions;
        private int soruIndexTut = 0;
        private int DCevapTut = 0;
        private int Zamanlayici = 0;
        public f_tyt_sosyalbil()
        {
            InitializeComponent();
            SorulariBaslat();
            EkranaSoruGoster();

            timer1.Interval = 1000;
            timer1.Start();
        }

        private void SorulariBaslat()
        {
            questions = new List<Question>();
            XmlDocument doc = new XmlDocument();
            doc.Load("tytSosyalBilSorulari.xml");

            foreach (XmlNode node in doc.SelectNodes("//Question"))
            {
                string text = node.SelectSingleNode("Text").InnerText;
                string[] options = new string[5];
                int i = 0;


                foreach (XmlNode opt in node.SelectNodes("Option"))
                {
                    options[i++] = opt.InnerText;
                }


                int correctIndex = int.Parse(node.SelectSingleNode("CorrectIndex").InnerText);


                questions.Add(new Question(text, options, correctIndex));
            }
        }

        private void EkranaSoruGoster()
        {
            if (soruIndexTut >= questions.Count)
            {
                EndTest();
                return;
            }
            //Soruları Yazdırma
            var q = questions[soruIndexTut];
            lblSoru.Text = $"Soru {soruIndexTut + 1}: {q.Text}";
            rbOption1.Text = q.Options[0];
            rbOption2.Text = q.Options[1];
            rbOption3.Text = q.Options[2];
            rbOption4.Text = q.Options[3];
            rbOption5.Text = q.Options[4];


            rbOption1.Checked = false;
            rbOption2.Checked = false;
            rbOption3.Checked = false;
            rbOption4.Checked = false;
            rbOption5.Checked = false;
        }

        private void f_tyt_sosyalbil_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            Control[] controls = { rbOption1, rbOption2, rbOption3, rbOption4, rbOption5, lblTimer, lblSoru };

            foreach (Control ctrl in controls)
            {
                ctrl.Parent = pictureBox1;
                ctrl.BackColor = Color.Transparent;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selected = -1;
            if (rbOption1.Checked) selected = 0;
            else if (rbOption2.Checked) selected = 1;
            else if (rbOption3.Checked) selected = 2;
            else if (rbOption4.Checked) selected = 3;
            else if (rbOption5.Checked) selected = 4;

            if (selected == -1)
            {
                MessageBox.Show("Lütfen bir seçenek seçin.");
                return;
            }

            if (selected == questions[soruIndexTut].CorrectIndex)
                DCevapTut++;

            soruIndexTut++;  // Sonraki soruya geç
            EkranaSoruGoster(); // Yeni soruyu göster
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Zamanlayici++;
            int minutes = Zamanlayici / 60;
            int seconds = Zamanlayici % 60;
            lblTimer.Text = $"Geçen Süre: {minutes:D2}:{seconds:D2}";
        }

        private void EndTest()
        {
            timer1.Stop();

            int wrong = questions.Count - DCevapTut;
            string speedMessage;

            if (Zamanlayici <= 120)
                speedMessage = "Harika, çok hızlı bitirdin!";
            else if (Zamanlayici <= 600)
                speedMessage = "İyi iş!";
            else
                speedMessage = "Çok yavaştın.";


            MessageBox.Show(
                $"Test Bitti!\n\nDoğru: {DCevapTut}\nYanlış: {wrong}\nSüre: {Zamanlayici / 60:D2}:{Zamanlayici % 60:D2}\n\n{speedMessage}",
                "Sonuç",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            fanamenu fanamenu = new fanamenu("");
            fanamenu.Show();
            this.Close();


        }

        public class Question
        {
            public string Text { get; set; }
            public string[] Options { get; set; }
            public int CorrectIndex { get; set; }

            public Question(string text, string[] options, int correctIndex)
            {
                Text = text;
                Options = options;
                CorrectIndex = correctIndex;
            }
        }
    }
}
