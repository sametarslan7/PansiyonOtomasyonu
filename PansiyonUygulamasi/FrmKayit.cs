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
    public partial class FrmKayit : Form
    {
        public FrmKayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESTROYERM\\SQLEXPRESS;Initial Catalog=DB_PANSIYON;Integrated Security=True");


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text != "" && txtSifre.Text != "" && txtKullaniciAdi.Text != null && txtSifre.Text != null)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TBLADMIN values(@p1,@p2)",baglanti);

                komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@p2", txtSifre.Text.ToString());
                komut.ExecuteNonQuery();
                MessageBox.Show("Yeni Yönetici Kaydı Oluşturuldu");

                FrmAdminGiris fr=new FrmAdminGiris();
                fr.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen kullanıcı adı veya şifreyi tekrar kontrol ediniz.");
            }
        }
    }
}
