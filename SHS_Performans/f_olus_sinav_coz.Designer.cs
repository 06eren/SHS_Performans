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
            rbA = new RadioButton();
            rbB = new RadioButton();
            rbC = new RadioButton();
            rbD = new RadioButton();
            rbE = new RadioButton();
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
            // rbA
            // 
            rbA.BackColor = Color.Transparent;
            rbA.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbA.ForeColor = SystemColors.Info;
            rbA.Location = new Point(12, 269);
            rbA.Name = "rbA";
            rbA.Size = new Size(941, 95);
            rbA.TabIndex = 4;
            rbA.TabStop = true;
            rbA.Text = "radioButton1";
            rbA.UseVisualStyleBackColor = false;
            // 
            // rbB
            // 
            rbB.BackColor = Color.Transparent;
            rbB.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbB.ForeColor = SystemColors.Info;
            rbB.Location = new Point(12, 370);
            rbB.Name = "rbB";
            rbB.Size = new Size(941, 95);
            rbB.TabIndex = 5;
            rbB.TabStop = true;
            rbB.Text = "radioButton1";
            rbB.UseVisualStyleBackColor = false;
            // 
            // rbC
            // 
            rbC.BackColor = Color.Transparent;
            rbC.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbC.ForeColor = SystemColors.Info;
            rbC.Location = new Point(12, 471);
            rbC.Name = "rbC";
            rbC.Size = new Size(941, 95);
            rbC.TabIndex = 6;
            rbC.TabStop = true;
            rbC.Text = "radioButton1";
            rbC.UseVisualStyleBackColor = false;
            // 
            // rbD
            // 
            rbD.BackColor = Color.Transparent;
            rbD.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbD.ForeColor = SystemColors.Info;
            rbD.Location = new Point(12, 572);
            rbD.Name = "rbD";
            rbD.Size = new Size(941, 95);
            rbD.TabIndex = 7;
            rbD.TabStop = true;
            rbD.Text = "radioButton1";
            rbD.UseVisualStyleBackColor = false;
            // 
            // rbE
            // 
            rbE.BackColor = Color.Transparent;
            rbE.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbE.ForeColor = SystemColors.Info;
            rbE.Location = new Point(12, 673);
            rbE.Name = "rbE";
            rbE.Size = new Size(941, 95);
            rbE.TabIndex = 8;
            rbE.TabStop = true;
            rbE.Text = "radioButton1";
            rbE.UseVisualStyleBackColor = false;
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
            // 
            // f_olus_sinav_coz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1063, 890);
            Controls.Add(btnSonraki);
            Controls.Add(rbE);
            Controls.Add(rbD);
            Controls.Add(rbC);
            Controls.Add(rbB);
            Controls.Add(rbA);
            Controls.Add(lblSoru);
            Name = "f_olus_sinav_coz";
            Text = "f_olus_sinav_coz";
            Load += f_olus_sinav_coz_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblSoru;
        private RadioButton rbA;
        private RadioButton rbB;
        private RadioButton rbC;
        private RadioButton rbD;
        private RadioButton rbE;
        private Button btnSonraki;
    }
}