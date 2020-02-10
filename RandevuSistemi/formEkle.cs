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
    public partial class formEkle : Form
    {
        public formEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-4S51J92\SQLEXPRESS;Initial Catalog=Randevu;Integrated Security=True");

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Insert into tblIsYeri(IsYeriIsmi)");

        }

        private void formEkle_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * From tblKategori", baglan);
            SqlDataReader sqlDataReader = komut.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cmbKategori.Items.Add(sqlDataReader["KategoriIsmi"]);
            }
            baglan.Close();
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
