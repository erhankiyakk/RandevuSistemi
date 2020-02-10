using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandevuSistemi
{
    public partial class frmKategoriTanimlama : Form
    {
        public frmKategoriTanimlama()
        {
            InitializeComponent();
        }
        MyDatabase myDatabase = new MyDatabase();
        Rapor rapor = new Rapor();
        Kategori kategori = new Kategori();
        void listele()
        {
            myDatabase.baglanti.Open();
            myDatabase.Sorgu = "Select * from tblIsYeri where KategoriID=2";
            myDatabase.da = new SqlDataAdapter(myDatabase.Sorgu,myDatabase.baglanti);
            DataTable tablo = new DataTable();
            myDatabase.da.Fill(tablo);
            dgvIsYeri.DataSource = tablo;
            myDatabase.baglanti.Close();
        }
        IsYeri isYeri = new IsYeri();
        private void dgvIsYeri_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            isYeri.IsYeriID =Convert.ToInt32(dgvIsYeri.CurrentRow.Cells[0].Value);
            isYeri.Isim= dgvIsYeri.CurrentRow.Cells[1].Value.ToString();
            txtIsYeri.Text = isYeri.IsYeriID.ToString() + " ID'li " + isYeri.Isim.ToString() + " isimli iş yeri";

        }

        private void frmKategoriTanimlama_Load(object sender, EventArgs e)
        {
            rapor.KategoriEkle();
            foreach (Kategori k in rapor.KategoriListesi())
            {
                cmbKategori.Items.Add(k.KategoriIsmi);
            }
            listele();
        }

        private void cmbKategori_TextChanged(object sender, EventArgs e)
        {
            try
            {

            kategori.KategoriIsmi = cmbKategori.Text;
            foreach (Kategori k in rapor.KategoriListesi())
            {
                if (k.KategoriIsmi == kategori.KategoriIsmi)
                {
                    kategori.KategoriID = k.KategoriID;
                    isYeri.kategori = kategori;
                }
            }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            try
            {

            isYeri.IsYeriKategoriOnaylama();
            listele();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
