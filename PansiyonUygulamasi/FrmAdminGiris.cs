namespace PansiyonUygulamasi
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmKayit fr = new FrmKayit();
            fr.Show();
            this.Hide();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            FrmAdminGiris fradmin=new FrmAdminGiris();
            FrmAnaForm fr = new FrmAnaForm();
            fradmin.Close();
            fr.Show();
            
        }
    }
}
