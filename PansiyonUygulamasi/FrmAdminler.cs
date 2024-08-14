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
    public partial class FrmAdminler : Form
    {
        public FrmAdminler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESTROYERM\\SQLEXPRESS;Initial Catalog=DB_PANSIYON;Integrated Security=True");

        private void adminleriListele()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLADMIN", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ADMINID"].ToString();
                ekle.SubItems.Add(oku["ADMINKULLANICIAD"].ToString());
                ekle.SubItems.Add(oku["ADMINSIFRE"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void FrmAdminler_Load(object sender, EventArgs e)
        {
            adminleriListele();
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
    }
}
