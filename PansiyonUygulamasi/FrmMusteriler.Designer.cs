namespace PansiyonUygulamasi
{
    partial class FrmMusteriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusteriler));
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            button2 = new Button();
            button1 = new Button();
            btnGuncelle = new Button();
            btnAra = new Button();
            btnSil = new Button();
            txtUcret = new TextBox();
            label9 = new Label();
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
            txtAra = new TextBox();
            label10 = new Label();
            txtID = new TextBox();
            label11 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
            listView1.Location = new Point(14, 366);
            listView1.Name = "listView1";
            listView1.Size = new Size(836, 267);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.DoubleClick += listView1_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Adı";
            columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Soyadı";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Telefon Numarası";
            columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Mail";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "TC Kimlik No";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Oda No";
            columnHeader7.Width = 70;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Giriş Tarihi";
            columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Çıkış Tarihi";
            columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Ücret";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HighlightText;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(813, 12);
            button2.Name = "button2";
            button2.Size = new Size(35, 34);
            button2.TabIndex = 35;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HighlightText;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(764, 12);
            button1.Name = "button1";
            button1.Size = new Size(35, 34);
            button1.TabIndex = 34;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuncelle.Location = new Point(608, 148);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(191, 34);
            btnGuncelle.TabIndex = 37;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnAra
            // 
            btnAra.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnAra.Location = new Point(608, 256);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(191, 34);
            btnAra.TabIndex = 38;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnSil.Location = new Point(608, 204);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(191, 34);
            btnSil.TabIndex = 39;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // txtUcret
            // 
            txtUcret.BackColor = Color.BlanchedAlmond;
            txtUcret.Enabled = false;
            txtUcret.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUcret.Location = new Point(136, 326);
            txtUcret.Name = "txtUcret";
            txtUcret.Size = new Size(278, 25);
            txtUcret.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(68, 327);
            label9.Name = "label9";
            label9.Size = new Size(60, 21);
            label9.TabIndex = 56;
            label9.Text = "Ücret : ";
            // 
            // dateTimePickerCikis
            // 
            dateTimePickerCikis.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerCikis.Location = new Point(136, 293);
            dateTimePickerCikis.Name = "dateTimePickerCikis";
            dateTimePickerCikis.Size = new Size(200, 27);
            dateTimePickerCikis.TabIndex = 9;
            // 
            // dateTimePickerGiris
            // 
            dateTimePickerGiris.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerGiris.Location = new Point(136, 256);
            dateTimePickerGiris.Name = "dateTimePickerGiris";
            dateTimePickerGiris.Size = new Size(200, 27);
            dateTimePickerGiris.TabIndex = 8;
            // 
            // maskedTCKimlik
            // 
            maskedTCKimlik.BackColor = Color.BlanchedAlmond;
            maskedTCKimlik.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTCKimlik.Location = new Point(136, 188);
            maskedTCKimlik.Mask = "00000000000";
            maskedTCKimlik.Name = "maskedTCKimlik";
            maskedTCKimlik.Size = new Size(278, 27);
            maskedTCKimlik.TabIndex = 6;
            maskedTCKimlik.ValidatingType = typeof(int);
            // 
            // maskedTelefon
            // 
            maskedTelefon.BackColor = Color.BlanchedAlmond;
            maskedTelefon.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTelefon.Location = new Point(136, 122);
            maskedTelefon.Mask = "(999) 000-0000";
            maskedTelefon.Name = "maskedTelefon";
            maskedTelefon.Size = new Size(278, 27);
            maskedTelefon.TabIndex = 4;
            // 
            // txtOdaNo
            // 
            txtOdaNo.BackColor = Color.BlanchedAlmond;
            txtOdaNo.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtOdaNo.Location = new Point(136, 223);
            txtOdaNo.Name = "txtOdaNo";
            txtOdaNo.Size = new Size(278, 25);
            txtOdaNo.TabIndex = 7;
            // 
            // txtMail
            // 
            txtMail.BackColor = Color.BlanchedAlmond;
            txtMail.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtMail.Location = new Point(136, 157);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(278, 25);
            txtMail.TabIndex = 5;
            // 
            // txtSoyad
            // 
            txtSoyad.BackColor = Color.BlanchedAlmond;
            txtSoyad.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoyad.Location = new Point(136, 91);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(278, 25);
            txtSoyad.TabIndex = 3;
            // 
            // txtAd
            // 
            txtAd.BackColor = Color.BlanchedAlmond;
            txtAd.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtAd.Location = new Point(136, 61);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(278, 25);
            txtAd.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(33, 293);
            label8.Name = "label8";
            label8.Size = new Size(110, 21);
            label8.TabIndex = 47;
            label8.Text = "Çıkış Tarihi : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(34, 260);
            label7.Name = "label7";
            label7.Size = new Size(107, 21);
            label7.TabIndex = 46;
            label7.Text = "Giriş Tarihi : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(6, 227);
            label6.Name = "label6";
            label6.Size = new Size(128, 21);
            label6.TabIndex = 45;
            label6.Text = "Oda Numarası : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(0, 194);
            label5.Name = "label5";
            label5.Size = new Size(142, 21);
            label5.TabIndex = 44;
            label5.Text = "T.C. Kimlik No  :  ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(77, 161);
            label4.Name = "label4";
            label4.Size = new Size(56, 21);
            label4.TabIndex = 43;
            label4.Text = "Mail : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(54, 128);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 42;
            label3.Text = "Telefon : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(59, 95);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 41;
            label2.Text = "Soyadı : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(83, 62);
            label1.Name = "label1";
            label1.Size = new Size(49, 21);
            label1.TabIndex = 40;
            label1.Text = "Adı : ";
            // 
            // txtAra
            // 
            txtAra.BackColor = Color.BlanchedAlmond;
            txtAra.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtAra.Location = new Point(570, 323);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(278, 25);
            txtAra.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(502, 324);
            label10.Name = "label10";
            label10.Size = new Size(54, 21);
            label10.TabIndex = 58;
            label10.Text = "İsim : ";
            label10.Click += label10_Click;
            // 
            // txtID
            // 
            txtID.BackColor = Color.BlanchedAlmond;
            txtID.Enabled = false;
            txtID.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(136, 30);
            txtID.Name = "txtID";
            txtID.Size = new Size(278, 25);
            txtID.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(92, 34);
            label11.Name = "label11";
            label11.Size = new Size(41, 21);
            label11.TabIndex = 60;
            label11.Text = "ID : ";
            // 
            // FrmMusteriler
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.InactiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(862, 645);
            Controls.Add(txtID);
            Controls.Add(label11);
            Controls.Add(txtAra);
            Controls.Add(label10);
            Controls.Add(txtUcret);
            Controls.Add(label9);
            Controls.Add(dateTimePickerCikis);
            Controls.Add(dateTimePickerGiris);
            Controls.Add(maskedTCKimlik);
            Controls.Add(maskedTelefon);
            Controls.Add(txtOdaNo);
            Controls.Add(txtMail);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSil);
            Controls.Add(btnAra);
            Controls.Add(btnGuncelle);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMusteriler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşteriler";
            Load += FrmMusteriler_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private Button button2;
        private Button button1;
        private Button btnGuncelle;
        private Button btnAra;
        private Button btnSil;
        private TextBox txtUcret;
        private Label label9;
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
        private TextBox txtAra;
        private Label label10;
        private TextBox txtID;
        private Label label11;
    }
}