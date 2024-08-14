using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PansiyonUygulamasi
{
    public partial class FrmOdaDetay : Form
    {
        public FrmOdaDetay()
        {
            InitializeComponent();
        }

        private void FrmOdaDetay_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaForm fr = new FrmAnaForm();
            fr.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmOdalar fr=new FrmOdalar();
            fr.Show();
            this.Close();
        }
    }
}
