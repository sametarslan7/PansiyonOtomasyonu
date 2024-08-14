using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;


namespace PansiyonUygulamasi
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESTROYERM\\SQLEXPRESS;Initial Catalog=DB_PANSIYON;Integrated Security=True");
        private void verilerigoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLMUSTERI", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MUSTERIID"].ToString();
                ekle.SubItems.Add(oku["MUSTERIAD"].ToString());
                ekle.SubItems.Add(oku["MUSTERISOYAD"].ToString());
                ekle.SubItems.Add(oku["MUSTERITELEFON"].ToString());
                ekle.SubItems.Add(oku["MUSTERIMAIL"].ToString());
                ekle.SubItems.Add(oku["MUSTERITC"].ToString());
                ekle.SubItems.Add(oku["ODANO"].ToString());
                ekle.SubItems.Add(oku["GIRISTARIHI"].ToString());
                ekle.SubItems.Add(oku["CIKISTARIHI"].ToString());
                ekle.SubItems.Add(oku["UCRET"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();

        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaForm frm = new FrmAnaForm();
            frm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        int id = 0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtID.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            maskedTelefon.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtMail.Text = listView1.SelectedItems[0].SubItems[4].Text;
            maskedTCKimlik.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtOdaNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            dateTimePickerGiris.Text = listView1.SelectedItems[0].SubItems[7].Text;
            dateTimePickerCikis.Text = listView1.SelectedItems[0].SubItems[8].Text;
            txtUcret.Text = listView1.SelectedItems[0].SubItems[9].Text;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("delete from TBLMUSTERI where MUSTERIID=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1",txtID.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
