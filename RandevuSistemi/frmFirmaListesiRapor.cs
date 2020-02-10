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
    public partial class frmFirmaListesiRapor : Form
    {
        public frmFirmaListesiRapor()
        {
            InitializeComponent();
        }
        MyDatabase myDatabase = new MyDatabase();
        private void IsYeriLisTeleme()
        {
            try
            {

            myDatabase.baglanti.Open();
            myDatabase.da = new SqlDataAdapter("select * from ViewFirmaListeleme", myDatabase.baglanti);
            DataTable tablo = new DataTable();
            myDatabase.da.Fill(tablo);
            dgvIsYeriListe.DataSource = tablo;
            myDatabase.baglanti.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            //isyeri gösterir
        }

        private void frmFirmaListesiRapor_Load(object sender, EventArgs e)
        {
            try
            {

            IsYeriLisTeleme();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
