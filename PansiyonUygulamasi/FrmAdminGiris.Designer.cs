namespace PansiyonUygulamasi
{
    partial class FrmAdminGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminGiris));
            label1 = new Label();
            label2 = new Label();
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            btnGirisYap = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(136, 236);
            label1.Name = "label1";
            label1.Size = new Size(111, 21);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(191, 278);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 1;
            label2.Text = "Şifre : ";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.BackColor = SystemColors.Info;
            txtKullaniciAdi.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtKullaniciAdi.Location = new Point(274, 234);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(174, 27);
            txtKullaniciAdi.TabIndex = 2;
            // 
            // txtSifre
            // 
            txtSifre.BackColor = SystemColors.Info;
            txtSifre.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtSifre.Location = new Point(274, 278);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(174, 27);
            txtSifre.TabIndex = 3;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.MediumSeaGreen;
            btnGirisYap.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGirisYap.Location = new Point(191, 333);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(156, 30);
            btnGirisYap.TabIndex = 4;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(482, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Jokerman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(27, 102);
            label3.Name = "label3";
            label3.Size = new Size(440, 31);
            label3.TabIndex = 6;
            label3.Text = "Pansiyon Kayıt Sistemi'ne Hoşgeldiniz";
            label3.Click += label3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HighlightText;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(27, 12);
            button2.Name = "button2";
            button2.Size = new Size(43, 37);
            button2.TabIndex = 8;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(432, 333);
            button3.Name = "button3";
            button3.Size = new Size(156, 30);
            button3.TabIndex = 9;
            button3.Text = "Kayıt Ol";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // FrmAdminGiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(722, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(btnGirisYap);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAdminGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Giriş";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Button btnGirisYap;
        private PictureBox pictureBox1;
        private Label label3;
        private Button button2;
        private Button button3;
    }
}
