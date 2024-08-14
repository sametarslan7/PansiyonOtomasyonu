using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PansiyonUygulamasi
{
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESTROYERM\\SQLEXPRESS;Initial Catalog=DB_PANSIYON;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaForm fr = new FrmAnaForm();
            fr.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void KontrolButonlar()
        {
            // Veritabanı bağlantısını aç
            baglanti.Open();

            // Belirli bir paneldeki butonları kontrol et
            foreach (Control control in groupBox1.Controls)
            {
                if (control is Button btn && btn.Name.StartsWith("btnOda"))
                {
                    string odaNo = new string(btn.Text.Where(char.IsDigit).ToArray());

                    // SQL komutunu oluştur
                    SqlCommand komut2 = new SqlCommand("SELECT COUNT(*) FROM TBLMUSTERI WHERE ODANO = @p1", baglanti);
                    komut2.Parameters.AddWithValue("@p1", odaNo);

                    // Sorguyu çalıştır ve müşteri sayısını kontrol et
                    int customerCount = (int)komut2.ExecuteScalar();

                    // Eğer müşteri yoksa butonu devre dışı bırak ve rengini kırmızı yap
                    if (customerCount == 0)
                    {
                        btn.BackColor = Color.Red;
                        btn.Enabled = false;
                    }
                    else
                    {
                        btn.BackColor = Color.Green;
                        btn.Enabled = true;
                    }
                }
            }

            // Bağlantıyı kapat
            baglanti.Close();
        }


        private void btnOda101_Click(object sender, EventArgs e)
        {
            FrmOdaDetay fr = new FrmOdaDetay(btnOda101);
            fr.Show();
            this.Close();
        }

        private void btnOda102_Click(object sender, EventArgs e)
        {
            FrmOdaDetay fr = new FrmOdaDetay(btnOda102);
            fr.Show();
            this.Close();
        }

        private void btnOda103_Click(object sender, EventArgs e)
        {
            FrmOdaDetay fr = new FrmOdaDetay(btnOda103);
            fr.Show();
            this.Close();
        }

        private void btnOda104_Click(object sender, EventArgs e)
        {
            FrmOdaDetay fr = new FrmOdaDetay(btnOda104);
            fr.Show();
            this.Close();
        }

        private void btnOda105_Click(object sender, EventArgs e)
        {
            FrmOdaDetay fr = new FrmOdaDetay(btnOda105);
            fr.Show();
            this.Close();
        }

        private void btnOda106_Click(object sender, EventArgs e)
        {
            FrmOdaDetay fr = new FrmOdaDetay(btnOda106);
            fr.Show();
            this.Close();
        }

        private void btnOda107_Click(object sender, EventArgs e)
        {
            FrmOdaDetay fr = new FrmOdaDetay(btnOda107);
            fr.Show();
            this.Close();
        }

        private void btnOda108_Click(object sender, EventArgs e)
        {
            FrmOdaDetay fr = new FrmOdaDetay(btnOda108);
            fr.Show();
            this.Close();
        }

        private void btnOda109_Click(object sender, EventArgs e)
        {
            FrmOdaDetay fr = new FrmOdaDetay(btnOda109);
            fr.Show();
            this.Close();
        }

        private void btnOda110_Click(object sender, EventArgs e)
        {
            FrmOdaDetay fr = new FrmOdaDetay(btnOda110);
            fr.Show();
            this.Close();
        }

        private void btnOda111_Click(object sender, EventArgs e)
        {
            FrmOdaDetay fr = new FrmOdaDetay(btnOda111);
            fr.Show();
            this.Close();
        }

        private void btnOda112_Click(object sender, EventArgs e)
        {
            FrmOdaDetay fr = new FrmOdaDetay(btnOda112);
            fr.Show();
            this.Close();
        }

        private void btnOda113_Click(object sender, EventArgs e)
        {
            FrmOdaDetay fr = new FrmOdaDetay(btnOda113);
            fr.Show();
            this.Close();
        }

        private void btnOda114_Click(object sender, EventArgs e)
        {
            FrmOdaDetay fr = new FrmOdaDetay(btnOda114);
            fr.Show();
            this.Close();
        }

        private void btnOda115_Click(object sender, EventArgs e)
        {
            FrmOdaDetay fr = new FrmOdaDetay(btnOda115);
            fr.Show();
            this.Close();
        }

        private void FrmOdalar_Load(object sender, EventArgs e)
        {
            KontrolButonlar();
        }
    }
}
