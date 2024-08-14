using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace PansiyonUygulamasi
{
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESTROYERM\\SQLEXPRESS;Initial Catalog=DB_PANSIYON;Integrated Security=True");

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnOda101_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "101";
        }

        private void btnOda102_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "102";
        }

        private void btnOda103_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "103";
        }

        private void btnOda104_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "104";
        }

        private void btnOda105_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "105";
        }

        private void btnOda106_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "106";
        }

        private void btnOda107_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "107";
        }

        private void btnOda108_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "108";
        }

        private void btnOda109_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "109";
        }

        private void btnOda110_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "110";
        }

        private void btnOda111_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "111";
        }

        private void btnOda112_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "112";
        }

        private void btnOda113_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "113";
        }

        private void btnOda114_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "114";
        }

        private void btnOda115_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "115";
        }

        private void dateTimePickerCikis_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime giristarih = Convert.ToDateTime(dateTimePickerGiris.Text);
            DateTime cikistarih = Convert.ToDateTime(dateTimePickerCikis.Text);

            TimeSpan fark = cikistarih - giristarih;


            txtUcret.Text = (Convert.ToInt32(fark.TotalDays.ToString()) * 1000).ToString() + " TL";
        }

        private void txtUcret_TextChanged(object sender, EventArgs e)
        {

        }

        //ana sayaaya dönme butonu
        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaForm fr = new FrmAnaForm();
            fr.Show();
            this.Close();
        }

        //uygulamadan çıkma butonu
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //müşteri ekleme butonu
        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLMUSTERI values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", maskedTelefon.Text);
            komut.Parameters.AddWithValue("@p4", txtMail.Text);
            komut.Parameters.AddWithValue("@p5", maskedTCKimlik.Text);
            komut.Parameters.AddWithValue("@p6", txtOdaNo.Text);
            komut.Parameters.AddWithValue("@p7", Convert.ToDateTime(dateTimePickerGiris.Text));
            komut.Parameters.AddWithValue("@p8", Convert.ToDateTime(dateTimePickerCikis.Text));
            komut.Parameters.AddWithValue("@p9", txtUcret.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Müşteri Kaydı Başarıyla Yapıldı.");

        }

        public void OdaDoluluk()
        {
            // Veritabanı bağlantısını aç
            baglanti.Open();

            // Butonların tümünü kontrol et
            foreach (Control control in groupBox2.Controls)
            {
                if (control is Button)
                {
                    Button btn = (Button)control;
                    string odaNo = new string(btn.Text.Where(char.IsDigit).ToArray());

                    // SQL komutunu oluştur
                    SqlCommand komut2 = new SqlCommand("SELECT COUNT(*) FROM TBLMUSTERI WHERE ODANO = @p1", baglanti);
                    komut2.Parameters.AddWithValue("@p1", odaNo);

                    // Sorguyu çalıştır ve müşteri sayısını kontrol et
                    int customerCount = (int)komut2.ExecuteScalar();

                    // Eğer müşteri yoksa butonu devre dışı bırak
                    if (customerCount == 0 || customerCount < 0)
                    {
                        btn.Enabled = true;
                        btn.BackColor = Color.Green;
                        //btn.Text += " - Boş ";
                    }
                    else
                    {
                        btn.Enabled = false;
                        btn.BackColor = Color.Red;
                        //btn.Text += " - Dolu "; 
                    }
                }
            }

            // Bağlantıyı kapat
            baglanti.Close();
        }

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {
            OdaDoluluk();
        }
    }
}
