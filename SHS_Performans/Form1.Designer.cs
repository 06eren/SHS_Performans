namespace SHS_Performans
{
    partial class fgiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fgiris));
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            linkLabel1 = new LinkLabel();
            groupBox3 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            label4 = new Label();
            label3 = new Label();
            txtRegPassword = new TextBox();
            txtRegUserName = new TextBox();
            groupBox2 = new GroupBox();
            button4 = new Button();
            button1 = new Button();
            txtKullaniciAdi = new TextBox();
            label2 = new Label();
            txtSifre = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(822, 185);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(12, 203);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(822, 260);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login Or Register";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Brown;
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(297, 23);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(215, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Projemin GitHub Linki İçin Tıkla";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked_1;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.AppWorkspace;
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txtRegPassword);
            groupBox3.Controls.Add(txtRegUserName);
            groupBox3.Location = new Point(489, 51);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(304, 189);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sign Up";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.AppWorkspace;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(254, 75);
            button3.Name = "button3";
            button3.Size = new Size(25, 27);
            button3.TabIndex = 8;
            button3.Text = "👁️";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(185, 115);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 78);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 5;
            label4.Text = "Password :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 45);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 5;
            label3.Text = "User Name :";
            // 
            // txtRegPassword
            // 
            txtRegPassword.Location = new Point(123, 75);
            txtRegPassword.Name = "txtRegPassword";
            txtRegPassword.Size = new Size(156, 27);
            txtRegPassword.TabIndex = 6;
            // 
            // txtRegUserName
            // 
            txtRegUserName.Location = new Point(123, 38);
            txtRegUserName.Name = "txtRegUserName";
            txtRegUserName.Size = new Size(156, 27);
            txtRegUserName.TabIndex = 5;
            txtRegUserName.TextChanged += txtRegUserName_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.AppWorkspace;
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(txtKullaniciAdi);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtSifre);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(22, 51);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(304, 189);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Login";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.AppWorkspace;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(248, 71);
            button4.Name = "button4";
            button4.Size = new Size(25, 27);
            button4.TabIndex = 9;
            button4.Text = "👁️";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(157, 113);
            button1.Name = "button1";
            button1.Size = new Size(116, 31);
            button1.TabIndex = 4;
            button1.Text = "Entry";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(117, 38);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(156, 27);
            txtKullaniciAdi.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 78);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 3;
            label2.Text = "Password :";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(117, 71);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(156, 27);
            txtSifre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 2;
            label1.Text = "User Name :";
            // 
            // fgiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(852, 476);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "fgiris";
            Text = "Giriş";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
        private GroupBox groupBox3;
        private Label label3;
        private TextBox txtRegPassword;
        private TextBox txtRegUserName;
        private GroupBox groupBox2;
        private Button button1;
        private Button button2;
        private Label label4;
        private LinkLabel linkLabel1;
        private Button button3;
        private Button button4;
    }
}
