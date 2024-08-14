namespace PansiyonUygulamasi
{
    partial class FrmYeniMusteri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYeniMusteri));
            groupBox1 = new GroupBox();
            lblGunSayisi = new Label();
            txtUcret = new TextBox();
            label9 = new Label();
            btnMusteriEkle = new Button();
            dateTimePickerCikis = new DateTimePicker();
            dateTimePickerGiris = new DateTimePicker();
            maskedTCKimlik = new MaskedTextBox();
            maskedTelefon = new MaskedTextBox();
            txtOdaNo = new TextBox();
            txtMail = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnOda115 = new Button();
            btnOda114 = new Button();
            btnOda113 = new Button();
            btnOda112 = new Button();
            btnOda111 = new Button();
            btnOda110 = new Button();
            btnOda109 = new Button();
            btnOda108 = new Button();
            btnOda107 = new Button();
            btnOda106 = new Button();
            btnOda105 = new Button();
            btnOda104 = new Button();
            btnOda103 = new Button();
            btnOda102 = new Button();
            btnOda101 = new Button();
            button1 = new Button();
            button2 = new Button();
            button17 = new Button();
            button18 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblGunSayisi);
            groupBox1.Controls.Add(txtUcret);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(btnMusteriEkle);
            groupBox1.Controls.Add(dateTimePickerCikis);
            groupBox1.Controls.Add(dateTimePickerGiris);
            groupBox1.Controls.Add(maskedTCKimlik);
            groupBox1.Controls.Add(maskedTelefon);
            groupBox1.Controls.Add(txtOdaNo);
            groupBox1.Controls.Add(txtMail);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(515, 452);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Müşteri  Bilgiler";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lblGunSayisi
            // 
            lblGunSayisi.AutoSize = true;
            lblGunSayisi.Location = new Point(428, 382);
            lblGunSayisi.Name = "lblGunSayisi";
            lblGunSayisi.Size = new Size(56, 20);
            lblGunSayisi.TabIndex = 39;
            lblGunSayisi.Text = "label10";
            lblGunSayisi.Visible = false;
            // 
            // txtUcret
            // 
            txtUcret.BackColor = Color.BlanchedAlmond;
            txtUcret.Enabled = false;
            txtUcret.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUcret.Location = new Point(199, 327);
            txtUcret.Name = "txtUcret";
            txtUcret.Size = new Size(278, 25);
            txtUcret.TabIndex = 38;
            txtUcret.TextChanged += txtUcret_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(131, 328);
            label9.Name = "label9";
            label9.Size = new Size(62, 21);
            label9.TabIndex = 37;
            label9.Text = "Ücret : ";
            // 
            // btnMusteriEkle
            // 
            btnMusteriEkle.BackColor = SystemColors.HighlightText;
            btnMusteriEkle.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMusteriEkle.Location = new Point(199, 396);
            btnMusteriEkle.Name = "btnMusteriEkle";
            btnMusteriEkle.Size = new Size(148, 31);
            btnMusteriEkle.TabIndex = 36;
            btnMusteriEkle.Text = "Müşteri Ekle";
            btnMusteriEkle.UseVisualStyleBackColor = false;
            btnMusteriEkle.Click += btnMusteriEkle_Click;
            // 
            // dateTimePickerCikis
            // 
            dateTimePickerCikis.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerCikis.Location = new Point(199, 294);
            dateTimePickerCikis.Name = "dateTimePickerCikis";
            dateTimePickerCikis.Size = new Size(200, 27);
            dateTimePickerCikis.TabIndex = 35;
            dateTimePickerCikis.ValueChanged += dateTimePickerCikis_ValueChanged;
            // 
            // dateTimePickerGiris
            // 
            dateTimePickerGiris.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerGiris.Location = new Point(199, 257);
            dateTimePickerGiris.Name = "dateTimePickerGiris";
            dateTimePickerGiris.Size = new Size(200, 27);
            dateTimePickerGiris.TabIndex = 34;
            // 
            // maskedTCKimlik
            // 
            maskedTCKimlik.BackColor = Color.BlanchedAlmond;
            maskedTCKimlik.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTCKimlik.Location = new Point(199, 189);
            maskedTCKimlik.Mask = "00000000000";
            maskedTCKimlik.Name = "maskedTCKimlik";
            maskedTCKimlik.Size = new Size(278, 27);
            maskedTCKimlik.TabIndex = 33;
            maskedTCKimlik.ValidatingType = typeof(int);
            // 
            // maskedTelefon
            // 
            maskedTelefon.BackColor = Color.BlanchedAlmond;
            maskedTelefon.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTelefon.Location = new Point(199, 123);
            maskedTelefon.Mask = "(999) 000-0000";
            maskedTelefon.Name = "maskedTelefon";
            maskedTelefon.Size = new Size(278, 27);
            maskedTelefon.TabIndex = 32;
            // 
            // txtOdaNo
            // 
            txtOdaNo.BackColor = Color.BlanchedAlmond;
            txtOdaNo.Enabled = false;
            txtOdaNo.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtOdaNo.Location = new Point(199, 224);
            txtOdaNo.Name = "txtOdaNo";
            txtOdaNo.Size = new Size(278, 25);
            txtOdaNo.TabIndex = 31;
            // 
            // txtMail
            // 
            txtMail.BackColor = Color.BlanchedAlmond;
            txtMail.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtMail.Location = new Point(199, 158);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(278, 25);
            txtMail.TabIndex = 30;
            // 
            // txtSoyad
            // 
            txtSoyad.BackColor = Color.BlanchedAlmond;
            txtSoyad.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoyad.Location = new Point(199, 92);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(278, 25);
            txtSoyad.TabIndex = 29;
            // 
            // txtAd
            // 
            txtAd.BackColor = Color.BlanchedAlmond;
            txtAd.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtAd.Location = new Point(199, 62);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(278, 25);
            txtAd.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(96, 294);
            label8.Name = "label8";
            label8.Size = new Size(97, 21);
            label8.TabIndex = 27;
            label8.Text = "Çıkış Tarihi : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(97, 261);
            label7.Name = "label7";
            label7.Size = new Size(96, 21);
            label7.TabIndex = 26;
            label7.Text = "Giriş Tarihi : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(69, 228);
            label6.Name = "label6";
            label6.Size = new Size(124, 21);
            label6.TabIndex = 25;
            label6.Text = "Oda Numarası : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(63, 195);
            label5.Name = "label5";
            label5.Size = new Size(130, 21);
            label5.TabIndex = 24;
            label5.Text = "T.C. Kimlik No  :  ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(140, 162);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 23;
            label4.Text = "Mail : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(117, 129);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 22;
            label3.Text = "Telefon : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(122, 96);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 21;
            label2.Text = "Soyadı : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(146, 63);
            label1.Name = "label1";
            label1.Size = new Size(47, 21);
            label1.TabIndex = 20;
            label1.Text = "Adı : ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnOda115);
            groupBox2.Controls.Add(btnOda114);
            groupBox2.Controls.Add(btnOda113);
            groupBox2.Controls.Add(btnOda112);
            groupBox2.Controls.Add(btnOda111);
            groupBox2.Controls.Add(btnOda110);
            groupBox2.Controls.Add(btnOda109);
            groupBox2.Controls.Add(btnOda108);
            groupBox2.Controls.Add(btnOda107);
            groupBox2.Controls.Add(btnOda106);
            groupBox2.Controls.Add(btnOda105);
            groupBox2.Controls.Add(btnOda104);
            groupBox2.Controls.Add(btnOda103);
            groupBox2.Controls.Add(btnOda102);
            groupBox2.Controls.Add(btnOda101);
            groupBox2.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(543, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(382, 362);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Odalar";
            // 
            // btnOda115
            // 
            btnOda115.BackColor = Color.LimeGreen;
            btnOda115.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOda115.Location = new Point(286, 313);
            btnOda115.Name = "btnOda115";
            btnOda115.Size = new Size(63, 35);
            btnOda115.TabIndex = 14;
            btnOda115.Text = "115";
            btnOda115.UseVisualStyleBackColor = false;
            btnOda115.Click += btnOda115_Click;
            // 
            // btnOda114
            // 
            btnOda114.BackColor = Color.LimeGreen;
            btnOda114.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOda114.Location = new Point(162, 313);
            btnOda114.Name = "btnOda114";
            btnOda114.Size = new Size(63, 35);
            btnOda114.TabIndex = 13;
            btnOda114.Text = "114";
            btnOda114.UseVisualStyleBackColor = false;
            btnOda114.Click += btnOda114_Click;
            // 
            // btnOda113
            // 
            btnOda113.BackColor = Color.LimeGreen;
            btnOda113.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOda113.Location = new Point(38, 311);
            btnOda113.Name = "btnOda113";
            btnOda113.Size = new Size(63, 35);
            btnOda113.TabIndex = 12;
            btnOda113.Text = "113";
            btnOda113.UseVisualStyleBackColor = false;
            btnOda113.Click += btnOda113_Click;
            // 
            // btnOda112
            // 
            btnOda112.BackColor = Color.LimeGreen;
            btnOda112.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOda112.Location = new Point(286, 249);
            btnOda112.Name = "btnOda112";
            btnOda112.Size = new Size(63, 35);
            btnOda112.TabIndex = 11;
            btnOda112.Text = "112";
            btnOda112.UseVisualStyleBackColor = false;
            btnOda112.Click += btnOda112_Click;
            // 
            // btnOda111
            // 
            btnOda111.BackColor = Color.LimeGreen;
            btnOda111.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOda111.Location = new Point(162, 249);
            btnOda111.Name = "btnOda111";
            btnOda111.Size = new Size(63, 35);
            btnOda111.TabIndex = 10;
            btnOda111.Text = "111";
            btnOda111.UseVisualStyleBackColor = false;
            btnOda111.Click += btnOda111_Click;
            // 
            // btnOda110
            // 
            btnOda110.BackColor = Color.LimeGreen;
            btnOda110.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOda110.Location = new Point(38, 247);
            btnOda110.Name = "btnOda110";
            btnOda110.Size = new Size(63, 35);
            btnOda110.TabIndex = 9;
            btnOda110.Text = "110";
            btnOda110.UseVisualStyleBackColor = false;
            btnOda110.Click += btnOda110_Click;
            // 
            // btnOda109
            // 
            btnOda109.BackColor = Color.LimeGreen;
            btnOda109.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOda109.Location = new Point(286, 185);
            btnOda109.Name = "btnOda109";
            btnOda109.Size = new Size(63, 35);
            btnOda109.TabIndex = 8;
            btnOda109.Text = "109";
            btnOda109.UseVisualStyleBackColor = false;
            btnOda109.Click += btnOda109_Click;
            // 
            // btnOda108
            // 
            btnOda108.BackColor = Color.LimeGreen;
            btnOda108.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOda108.Location = new Point(162, 185);
            btnOda108.Name = "btnOda108";
            btnOda108.Size = new Size(63, 35);
            btnOda108.TabIndex = 7;
            btnOda108.Text = "108";
            btnOda108.UseVisualStyleBackColor = false;
            btnOda108.Click += btnOda108_Click;
            // 
            // btnOda107
            // 
            btnOda107.BackColor = Color.LimeGreen;
            btnOda107.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOda107.Location = new Point(38, 185);
            btnOda107.Name = "btnOda107";
            btnOda107.Size = new Size(63, 35);
            btnOda107.TabIndex = 6;
            btnOda107.Text = "107";
            btnOda107.UseVisualStyleBackColor = false;
            btnOda107.Click += btnOda107_Click;
            // 
            // btnOda106
            // 
            btnOda106.BackColor = Color.LimeGreen;
            btnOda106.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOda106.Location = new Point(286, 123);
            btnOda106.Name = "btnOda106";
            btnOda106.Size = new Size(63, 35);
            btnOda106.TabIndex = 5;
            btnOda106.Text = "106";
            btnOda106.UseVisualStyleBackColor = false;
            btnOda106.Click += btnOda106_Click;
            // 
            // btnOda105
            // 
            btnOda105.BackColor = Color.LimeGreen;
            btnOda105.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOda105.Location = new Point(162, 123);
            btnOda105.Name = "btnOda105";
            btnOda105.Size = new Size(63, 35);
            btnOda105.TabIndex = 4;
            btnOda105.Text = "105";
            btnOda105.UseVisualStyleBackColor = false;
            btnOda105.Click += btnOda105_Click;
            // 
            // btnOda104
            // 
            btnOda104.BackColor = Color.LimeGreen;
            btnOda104.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOda104.Location = new Point(38, 123);
            btnOda104.Name = "btnOda104";
            btnOda104.Size = new Size(63, 35);
            btnOda104.TabIndex = 3;
            btnOda104.Text = "104";
            btnOda104.UseVisualStyleBackColor = false;
            btnOda104.Click += btnOda104_Click;
            // 
            // btnOda103
            // 
            btnOda103.BackColor = Color.LimeGreen;
            btnOda103.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOda103.Location = new Point(286, 63);
            btnOda103.Name = "btnOda103";
            btnOda103.Size = new Size(63, 35);
            btnOda103.TabIndex = 2;
            btnOda103.Text = "103";
            btnOda103.UseVisualStyleBackColor = false;
            btnOda103.Click += btnOda103_Click;
            // 
            // btnOda102
            // 
            btnOda102.BackColor = Color.LimeGreen;
            btnOda102.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOda102.Location = new Point(162, 61);
            btnOda102.Name = "btnOda102";
            btnOda102.Size = new Size(63, 35);
            btnOda102.TabIndex = 1;
            btnOda102.Text = "102";
            btnOda102.UseVisualStyleBackColor = false;
            btnOda102.Click += btnOda102_Click;
            // 
            // btnOda101
            // 
            btnOda101.BackColor = Color.LimeGreen;
            btnOda101.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOda101.Location = new Point(38, 61);
            btnOda101.Name = "btnOda101";
            btnOda101.Size = new Size(63, 35);
            btnOda101.TabIndex = 0;
            btnOda101.Text = "101";
            btnOda101.UseVisualStyleBackColor = false;
            btnOda101.Click += btnOda101_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HighlightText;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(944, 12);
            button1.Name = "button1";
            button1.Size = new Size(33, 33);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HighlightText;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(993, 12);
            button2.Name = "button2";
            button2.Size = new Size(33, 33);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.LimeGreen;
            button17.Enabled = false;
            button17.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button17.Location = new Point(833, 433);
            button17.Name = "button17";
            button17.Size = new Size(59, 31);
            button17.TabIndex = 18;
            button17.Text = "Boş";
            button17.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            button18.BackColor = Color.OrangeRed;
            button18.Enabled = false;
            button18.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button18.Location = new Point(833, 396);
            button18.Name = "button18";
            button18.Size = new Size(59, 31);
            button18.TabIndex = 17;
            button18.Text = "Dolu";
            button18.UseVisualStyleBackColor = false;
            // 
            // FrmYeniMusteri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1036, 476);
            Controls.Add(button17);
            Controls.Add(button18);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmYeniMusteri";
            Text = "Yeni Müşteri Ekle";
            Load += FrmYeniMusteri_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnMusteriEkle;
        private DateTimePicker dateTimePickerCikis;
        private DateTimePicker dateTimePickerGiris;
        private MaskedTextBox maskedTCKimlik;
        private MaskedTextBox maskedTelefon;
        private TextBox txtOdaNo;
        private TextBox txtMail;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnOda115;
        private Button btnOda114;
        private Button btnOda113;
        private Button btnOda112;
        private Button btnOda111;
        private Button btnOda110;
        private Button btnOda109;
        private Button btnOda108;
        private Button btnOda107;
        private Button btnOda106;
        private Button btnOda105;
        private Button btnOda104;
        private Button btnOda103;
        private Button btnOda102;
        private Button btnOda101;
        private TextBox txtUcret;
        private Label label9;
        private Label lblGunSayisi;
        private Button button1;
        private Button button2;
        private Button button17;
        private Button button18;
    }
}