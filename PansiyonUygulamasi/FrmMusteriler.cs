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
    }
}
