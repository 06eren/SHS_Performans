namespace SHS_Performans
{
    partial class f_tyt_turkce
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_tyt_turkce));
            pictureBox1 = new PictureBox();
            lblSoru = new Label();
            button1 = new Button();
            rbOption1 = new RadioButton();
            rbOption2 = new RadioButton();
            rbOption3 = new RadioButton();
            rbOption4 = new RadioButton();
            rbOption5 = new RadioButton();
            lblTimer = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(-1, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1073, 885);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblSoru
            // 
            lblSoru.BackColor = Color.Transparent;
            lblSoru.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSoru.ForeColor = Color.OldLace;
            lblSoru.Location = new Point(12, 52);
            lblSoru.Name = "lblSoru";
            lblSoru.Size = new Size(1023, 257);
            lblSoru.TabIndex = 1;
            lblSoru.Text = "Soru";
            lblSoru.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(906, 832);
            button1.Name = "button1";
            button1.Size = new Size(129, 33);
            button1.TabIndex = 2;
            button1.Text = "Sonraki Soru";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // rbOption1
            // 
            rbOption1.BackColor = Color.Transparent;
            rbOption1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbOption1.ForeColor = Color.Black;
            rbOption1.Location = new Point(44, 323);
            rbOption1.Name = "rbOption1";
            rbOption1.Size = new Size(941, 95);
            rbOption1.TabIndex = 3;
            rbOption1.TabStop = true;
            rbOption1.Text = "radioButton1";
            rbOption1.UseVisualStyleBackColor = false;
            // 
            // rbOption2
            // 
            rbOption2.BackColor = Color.Transparent;
            rbOption2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbOption2.Location = new Point(44, 424);
            rbOption2.Name = "rbOption2";
            rbOption2.Size = new Size(941, 93);
            rbOption2.TabIndex = 4;
            rbOption2.TabStop = true;
            rbOption2.Text = "radioButton2";
            rbOption2.UseVisualStyleBackColor = false;
            // 
            // rbOption3
            // 
            rbOption3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbOption3.Location = new Point(44, 523);
            rbOption3.Name = "rbOption3";
            rbOption3.Size = new Size(941, 93);
            rbOption3.TabIndex = 5;
            rbOption3.TabStop = true;
            rbOption3.Text = "radioButton3";
            rbOption3.UseVisualStyleBackColor = true;
            // 
            // rbOption4
            // 
            rbOption4.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbOption4.Location = new Point(44, 622);
            rbOption4.Name = "rbOption4";
            rbOption4.Size = new Size(941, 93);
            rbOption4.TabIndex = 6;
            rbOption4.TabStop = true;
            rbOption4.Text = "radioButton4";
            rbOption4.UseVisualStyleBackColor = true;
            // 
            // rbOption5
            // 
            rbOption5.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbOption5.Location = new Point(44, 721);
            rbOption5.Name = "rbOption5";
            rbOption5.Size = new Size(941, 93);
            rbOption5.TabIndex = 7;
            rbOption5.TabStop = true;
            rbOption5.Text = "radioButton5";
            rbOption5.UseVisualStyleBackColor = true;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.BackColor = Color.Transparent;
            lblTimer.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTimer.Location = new Point(433, 9);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(64, 28);
            lblTimer.TabIndex = 8;
            lblTimer.Text = "Süre : ";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // f_tyt_turkce
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1068, 880);
            Controls.Add(lblTimer);
            Controls.Add(rbOption5);
            Controls.Add(rbOption4);
            Controls.Add(rbOption3);
            Controls.Add(rbOption2);
            Controls.Add(rbOption1);
            Controls.Add(button1);
            Controls.Add(lblSoru);
            Controls.Add(pictureBox1);
            Name = "f_tyt_turkce";
            Text = "Temel Yeterlilik Testi Türkçe Sınavı";
            Load += f_tyt_turkce_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblSoru;
        private Button button1;
        private RadioButton rbOption1;
        private RadioButton rbOption2;
        private RadioButton rbOption3;
        private RadioButton rbOption4;
        private RadioButton rbOption5;
        private Label lblTimer;
        private System.Windows.Forms.Timer timer1;
    }
}