namespace PansiyonUygulamasi
{
    partial class FrmKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKayit));
            button2 = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            txtSifre = new TextBox();
            txtKullaniciAdi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnKayitOl = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HighlightText;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(30, 29);
            button2.Name = "button2";
            button2.Size = new Size(43, 37);
            button2.TabIndex = 10;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(547, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Jokerman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(49, 96);
            label3.Name = "label3";
            label3.Size = new Size(440, 31);
            label3.TabIndex = 12;
            label3.Text = "Pansiyon Kayıt Sistemi'ne Hoşgeldiniz";
            // 
            // txtSifre
            // 
            txtSifre.BackColor = SystemColors.Info;
            txtSifre.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtSifre.Location = new Point(262, 255);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(174, 27);
            txtSifre.TabIndex = 16;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.BackColor = SystemColors.Info;
            txtKullaniciAdi.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtKullaniciAdi.Location = new Point(262, 211);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(174, 27);
            txtKullaniciAdi.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(179, 255);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 14;
            label2.Text = "Şifre : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(124, 213);
            label1.Name = "label1";
            label1.Size = new Size(111, 21);
            label1.TabIndex = 13;
            label1.Text = "Kullanıcı Adı : ";
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = Color.MediumSeaGreen;
            btnKayitOl.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnKayitOl.Location = new Point(209, 326);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(156, 30);
            btnKayitOl.TabIndex = 17;
            btnKayitOl.Text = "Kayıt Ol";
            btnKayitOl.UseVisualStyleBackColor = false;
            btnKayitOl.Click += btnGirisYap_Click;
            // 
            // FrmKayit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 403);
            Controls.Add(btnKayitOl);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmKayit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmKayit";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
        private Label label2;
        private Label label1;
        private Button btnKayitOl;
    }
}