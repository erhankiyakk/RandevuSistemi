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
    public partial class frmIslemler : Form
    {
        public frmIslemler()
        {
            InitializeComponent();
        }
        MyDatabase myDatabase = new MyDatabase();
        void listele()
        {
            try
            {

            myDatabase.baglanti.Open();
            myDatabase.Sorgu = "Select * from tblIsYeri";
            myDatabase.da = new SqlDataAdapter(myDatabase.Sorgu, myDatabase.baglanti);
            DataTable tablo = new DataTable();
            myDatabase.da.Fill(tablo);
            dgvIsYeri.DataSource = tablo;
            myDatabase.baglanti.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        IsYeri isYeri;
        Rapor Rapor = new Rapor();
        private void btnIsYeriEkle_Click(object sender, EventArgs e)
        {
            try
            {

            isYeri = new IsYeri();
            isYeri.Isim = txtIsYeriAdi.Text;
            isYeri.Adres = txtIsYeriAdres.Text;
            isYeri.TelefonNumarasi = mtxtTel.Text;
            Rapor.IsYeriEkle(isYeri);
            listele();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void dgvIsYeri_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            txtID.Text= dgvIsYeri.CurrentRow.Cells[0].Value.ToString();
            txtIsYeriAdi.Text = dgvIsYeri.CurrentRow.Cells[1].Value.ToString();
            txtIsYeriAdres.Text = dgvIsYeri.CurrentRow.Cells[2].Value.ToString();
            mtxtTel.Text = dgvIsYeri.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            { 
            isYeri = new IsYeri();
            isYeri.IsYeriID = Convert.ToInt32(txtID.Text);
            isYeri.Isim = txtIsYeriAdi.Text;
            isYeri.Adres = txtIsYeriAdres.Text;
            isYeri.TelefonNumarasi = mtxtTel.Text;
            Rapor.IsYeriGuncelle(isYeri);
            listele();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void frmIslemler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            try
            {
            myDatabase.baglanti.Open();
            DataTable tbl = new DataTable();
            myDatabase.Sorgu = "Select * " + "From tblIsYeri" +
                                                   " Where IsYeriIsmi like '%" + txtArama.Text + "%' " +
                                                   "Or Adres like '%" + txtArama.Text + "%' " +
                                                   " Or TelefonNumarasi like '%" + txtArama.Text + "%'";
            myDatabase.da = new SqlDataAdapter(myDatabase.Sorgu, myDatabase.baglanti);
            myDatabase.da.Fill(tbl);
            myDatabase.baglanti.Close();
            dgvIsYeri.DataSource = tbl;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
            isYeri = new IsYeri();
            isYeri.IsYeriID = Convert.ToInt32(txtID.Text);
            Rapor.IsYeriSilme(isYeri);
            listele();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}
