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
    public partial class frmRapor : Form
    {
        public frmRapor()
        {
            InitializeComponent();
        }
        MyDatabase myDatabase = new MyDatabase();

        private void KullaniciListeleme()
        {
            try
            {
            myDatabase.baglanti.Open();
            myDatabase.da = new SqlDataAdapter("select * from ViewKullaniciListeleme", myDatabase.baglanti);
            DataTable tablo = new DataTable();
            myDatabase.da.Fill(tablo);
            dgvKullanicilar.DataSource = tablo;
            myDatabase.baglanti.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            //isyeri gösterir
            

        }
        
        private void frmRapor_Load(object sender, EventArgs e)
        {
            try
            {

            KullaniciListeleme();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void dgvKullanicilar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
