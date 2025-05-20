using System.Diagnostics;

namespace SHS_Performans
{
    public partial class fgiris : Form
    {
        //Kulanıcıların Kayıtlı Oldugu Yer
        private Dictionary<string, string> kullanicilar = new Dictionary<string, string>(); //Veri Yapısı
        bool sifreGosteriliyor = false; //Sifre Gizleme
        bool sifre2Gosteriliyor = false;//**
        public fgiris()
        {
            InitializeComponent();
        }
        //Form Yuklenırken Şifre Gızlenıyor Lınkın rengı ve lınk gelıyor form ekranın ortasına gecıyor
        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Links.Add(24, 6, "https://github.com/06eren");
            txtRegPassword.UseSystemPasswordChar = true;
            txtSifre.UseSystemPasswordChar = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        //Link Olayı
        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = e.Link.LinkData as string;
            if (url != null)
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // NET 8 Destekler
                });
            }
        }
        //Giriş Yapma Olayı
        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text;
            string KarsilamaKullaniciAdi = txtKullaniciAdi.Text;

            if (kullanicilar.ContainsKey(kullaniciAdi) && kullanicilar[kullaniciAdi] == sifre)
            {
                MessageBox.Show("Login successful", "SHS Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fanamenu menu = new fanamenu(KarsilamaKullaniciAdi);
                menu.Show(this);
                this.Hide();

            }
            else
            {
                MessageBox.Show("Incorrect username or password", "SHS Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Kayıt Olma Olayı
        private void button2_Click(object sender, EventArgs e)
        {
            string yeniKullanici = txtRegUserName.Text.Trim();
            string yeniSifre = txtRegPassword.Text;

            if (kullanicilar.ContainsKey(yeniKullanici))
            {
                MessageBox.Show("This user is already registered!", "SHS Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(yeniKullanici) || string.IsNullOrWhiteSpace(yeniSifre))
            {
                MessageBox.Show("Please complete all fields", "SHS Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                kullanicilar.Add(yeniKullanici, yeniSifre);
                MessageBox.Show("Registration successful You can now log in.", "SHS Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);


                txtRegUserName.Text = "";
                txtRegPassword.Text = "";
            }
        }
        //Register Şifre Gizleme
        private void button3_Click(object sender, EventArgs e)
        {
            sifreGosteriliyor = !sifreGosteriliyor;

            txtRegPassword.UseSystemPasswordChar = !sifreGosteriliyor;
            button3.Text = sifreGosteriliyor ? "🙈" : "👁️";
        }
        //Login Şifre Gizleme
        private void button4_Click(object sender, EventArgs e)
        {
            sifre2Gosteriliyor = !sifre2Gosteriliyor;

            txtSifre.UseSystemPasswordChar = !sifre2Gosteriliyor;
            button4.Text = sifreGosteriliyor ? "🙈" : "👁️";
        }

        private void txtRegUserName_TextChanged(object sender, EventArgs e)
        {
            txtKullaniciAdi.Text = txtRegUserName.Text;
        }
    }
}

//Bu Alanda Girişi Yaptık Girişler Ramlarda Kayıtlı Kalır Çalıştığı Sure Boyunca Veriyi Saklar Yenıden Başlarsa Veri Kaybolur
//By Eren

