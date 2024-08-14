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
    public partial class FrmOdaDetay : Form
    {
        private Button _odaButonu;

        public FrmOdaDetay(Button odaButonu)
        {
            InitializeComponent();
            _odaButonu = odaButonu;
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESTROYERM\\SQLEXPRESS;Initial Catalog=DB_PANSIYON;Integrated Security=True");

        private void FrmOdaDetay_Load(object sender, EventArgs e)
        {
            lblOdaNo.Text = _odaButonu.Text;
            OdaBilgileri();
        }
        public void OdaBilgileri()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select MUSTERIAD,MUSTERISOYAD,MUSTERITELEFON,MUSTERIMAIL,GIRISTARIHI,CIKISTARIHI,UCRET from TBLMUSTERI where ODANO=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", lblOdaNo.Text);

            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                lblAd.Text = oku["MUSTERIAD"].ToString();
                lblSoyad.Text = oku["MUSTERISOYAD"].ToString();
                lblTelefon.Text = oku["MUSTERITELEFON"].ToString();
                lblMail.Text = oku["MUSTERIMAIL"].ToString();
                lblGirisTarih.Text = oku["GIRISTARIHI"].ToString();
                lblCikisTarih.Text = oku["CIKISTARIHI"].ToString();
                lblUcret.Text = oku["UCRET"].ToString();
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaForm fr = new FrmAnaForm();
            fr.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmOdalar fr = new FrmOdalar();
            fr.Show();
            this.Close();
        }

        private void lblOdaNo_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
