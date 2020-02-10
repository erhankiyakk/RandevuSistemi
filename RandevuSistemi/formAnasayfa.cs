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

namespace RandevuSistemi
{


    public partial class formAnasayfa : Form
    {
        
        public formAnasayfa()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-4S51J92\SQLEXPRESS;Initial Catalog=Randevu;Integrated Security=True");


        

        private void btnListele_Click(object sender, EventArgs e)
        {
            formListele formListele = new formListele();
            formListele.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            formEkle ekle = new formEkle();
            ekle.Show();
            this.Hide();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }
    }
}
