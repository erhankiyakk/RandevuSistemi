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
    public partial class frmIsYeriYetkiliTanımlama : Form
    {
        public frmIsYeriYetkiliTanımlama()
        {
            InitializeComponent();
        }
        IsYeri isYeri = new IsYeri();
        IsYeriYetkilisi isYeriYetkilisi = new IsYeriYetkilisi();
        MyDatabase myDatabase = new MyDatabase();

        private void dgvIsYeri2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            isYeri.IsYeriID= Convert.ToInt32( dgvIsYeri.CurrentRow.Cells[0].Value);
            txtIsYeriAdi.Text = dgvIsYeri.CurrentRow.Cells[0].Value.ToString()+" ID 'li " + dgvIsYeri.CurrentRow.Cells[1].Value.ToString() +" İsimli İş Yeri ";
           
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }
        private void dgvIsYeriYetkili_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            isYeriYetkilisi.IsYeriYetkilisiID= Convert.ToInt32(dgvIsYeriYetkili.CurrentRow.Cells[0].Value);
            txtIsYeriYetkiliAdi.Text = dgvIsYeriYetkili.CurrentRow.Cells[0].Value.ToString()+ " ID 'li " + dgvIsYeriYetkili.CurrentRow.Cells[6].Value.ToString() + " İsimli İş Yeri Yetkilisi ";
      
            }
            catch (Exception ex)
            {

                throw ex;
            }
              }
        private void IsYeriGoster()
        {
            try
            {
            //isyeri gösterir
            myDatabase.baglanti.Open();
            myDatabase.da = new SqlDataAdapter("Select * from tblIsYeri where YetkiliTanimlamaDurum=0", myDatabase.baglanti);
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
        private void YetkiliGoster()
        {
            try
            {
            myDatabase.baglanti.Open();
            myDatabase.da = new SqlDataAdapter("Select * from tblIsYeriYetkilileri where IsYeriTanimlamaDurum=0", myDatabase.baglanti);
            DataTable tablo = new DataTable();
            myDatabase.da.Fill(tablo);
            dgvIsYeriYetkili.DataSource = tablo;
            myDatabase.baglanti.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            //isyeri yetkilisi gösterir
            
        }

        private void IsYerininYetkilisiniGoster()
        {
            //3.dgvyi gösterir
            myDatabase.baglanti.Open();
            myDatabase.da = new SqlDataAdapter("Select IsYeriIsmi As 'Is Yeri Ismi',Isim as 'Is Yeri Yetkili Ismi' from tblIsYeri I inner join tblIsYeriYetkilileri IY ON I.IsYeriYetkiliID=IY.IsYeriYetkiliID where IsYeriTanimlamaDurum=1", myDatabase.baglanti);
            DataTable tablo = new DataTable();
            myDatabase.da.Fill(tablo);
            dgvIsYeriYetkiliTanımlama.DataSource = tablo;
            myDatabase.baglanti.Close();
        }
        
        
        
        private void frmIsYeriYetkiliTanımlama_Load(object sender, EventArgs e)
        {
            IsYeriGoster();
            YetkiliGoster();
            IsYerininYetkilisiniGoster();
            
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
             
            IsYeriYetkiliTanimlama isYeriYetkiliTanimlama = new IsYeriYetkiliTanimlama();

            isYeriYetkiliTanimlama.isYeri= isYeri;
            isYeriYetkiliTanimlama.isYeriYetkilisi = isYeriYetkilisi;
            isYeriYetkiliTanimlama.tanımla();
         

            IsYerininYetkilisiniGoster();
            isYeriYetkiliTanimlama.YetkiliGuncelle();
            isYeriYetkiliTanimlama.IsYeriGuncelle();
            IsYeriGoster();
            YetkiliGoster();
 




        }

        private void txtIsYeriYetkiliAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
