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
    public partial class frmIsYeriYetkilisiRapor : Form
    {

        public frmIsYeriYetkilisiRapor()
        {
            InitializeComponent();
        }
        MyDatabase myDatabase = new MyDatabase();
       private void IsYeriYetkiliListele()
        {
            try
            {
            myDatabase.baglanti.Open();
           myDatabase.da = new SqlDataAdapter("select * from ViewIsYeriYetkiliListesi", myDatabase.baglanti);
            DataTable tablo = new DataTable();
            myDatabase.da.Fill(tablo);
            dgvİsYeriYetkilileri.DataSource = tablo;
            myDatabase.baglanti.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            //isyeri yetkili gösterir
            

        }
        private void frmIsYeriYetkilisiRapor_Load(object sender, EventArgs e)
        {
            try
            {

            IsYeriYetkiliListele();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
