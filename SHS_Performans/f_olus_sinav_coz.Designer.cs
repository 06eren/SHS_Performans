namespace SHS_Performans
{
    partial class f_olus_sinav_coz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_olus_sinav_coz));
            lblSoru = new Label();
            rdA = new RadioButton();
            rdB = new RadioButton();
            rdC = new RadioButton();
            rdD = new RadioButton();
            rdE = new RadioButton();
            btnSonraki = new Button();
            SuspendLayout();
            // 
            // lblSoru
            // 
            lblSoru.BackColor = Color.Transparent;
            lblSoru.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSoru.ForeColor = Color.OldLace;
            lblSoru.Location = new Point(12, 9);
            lblSoru.Name = "lblSoru";
            lblSoru.Size = new Size(1023, 257);
            lblSoru.TabIndex = 2;
            lblSoru.Text = "Soru";
            // 
            // rdA
            // 
            rdA.BackColor = Color.Transparent;
            rdA.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdA.ForeColor = SystemColors.Info;
            rdA.Location = new Point(12, 269);
            rdA.Name = "rdA";
            rdA.Size = new Size(941, 95);
            rdA.TabIndex = 4;
            rdA.TabStop = true;
            rdA.Text = "radioButton1";
            rdA.UseVisualStyleBackColor = false;
            // 
            // rdB
            // 
            rdB.BackColor = Color.Transparent;
            rdB.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdB.ForeColor = SystemColors.Info;
            rdB.Location = new Point(12, 370);
            rdB.Name = "rdB";
            rdB.Size = new Size(941, 95);
            rdB.TabIndex = 5;
            rdB.TabStop = true;
            rdB.Text = "radioButton1";
            rdB.UseVisualStyleBackColor = false;
            // 
            // rdC
            // 
            rdC.BackColor = Color.Transparent;
            rdC.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdC.ForeColor = SystemColors.Info;
            rdC.Location = new Point(12, 471);
            rdC.Name = "rdC";
            rdC.Size = new Size(941, 95);
            rdC.TabIndex = 6;
            rdC.TabStop = true;
            rdC.Text = "radioButton1";
            rdC.UseVisualStyleBackColor = false;
            // 
            // rdD
            // 
            rdD.BackColor = Color.Transparent;
            rdD.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdD.ForeColor = SystemColors.Info;
            rdD.Location = new Point(12, 572);
            rdD.Name = "rdD";
            rdD.Size = new Size(941, 95);
            rdD.TabIndex = 7;
            rdD.TabStop = true;
            rdD.Text = "radioButton1";
            rdD.UseVisualStyleBackColor = false;
            // 
            // rdE
            // 
            rdE.BackColor = Color.Transparent;
            rdE.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdE.ForeColor = SystemColors.Info;
            rdE.Location = new Point(12, 673);
            rdE.Name = "rdE";
            rdE.Size = new Size(941, 95);
            rdE.TabIndex = 8;
            rdE.TabStop = true;
            rdE.Text = "radioButton1";
            rdE.UseVisualStyleBackColor = false;
            // 
            // btnSonraki
            // 
            btnSonraki.BackColor = Color.FromArgb(192, 0, 0);
            btnSonraki.FlatStyle = FlatStyle.Flat;
            btnSonraki.Location = new Point(897, 830);
            btnSonraki.Name = "btnSonraki";
            btnSonraki.Size = new Size(129, 33);
            btnSonraki.TabIndex = 9;
            btnSonraki.Text = "Sonraki Soru";
            btnSonraki.UseVisualStyleBackColor = false;
            btnSonraki.Click += btnSonraki_Click;
            // 
            // f_olus_sinav_coz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1063, 890);
            Controls.Add(btnSonraki);
            Controls.Add(rdE);
            Controls.Add(rdD);
            Controls.Add(rdC);
            Controls.Add(rdB);
            Controls.Add(rdA);
            Controls.Add(lblSoru);
            Name = "f_olus_sinav_coz";
            Text = "Kullanıcı Sınavı";
            Load += f_olus_sinav_coz_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblSoru;
        private RadioButton rdA;
        private RadioButton rdB;
        private RadioButton rdC;
        private RadioButton rdD;
        private RadioButton rdE;
        private Button btnSonraki;
    }
}