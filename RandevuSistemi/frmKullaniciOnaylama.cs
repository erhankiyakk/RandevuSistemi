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
    public partial class frmKullaniciOnaylama : Form
    {
        public frmKullaniciOnaylama()
        {
            InitializeComponent();
        }
        MyDatabase myDatabase = new MyDatabase();
        NormalKullanici normalKullanici = new NormalKullanici();


        void KullaniciGoster()
        {

            //isyeri gösterir

            myDatabase.baglanti.Open();
            myDatabase.da = new SqlDataAdapter("Select * from tblNormalKullanici  where KullaniciOnayDurum=0", myDatabase.baglanti);
            DataTable tablo = new DataTable();
            myDatabase.da.Fill(tablo);
            dgvKullanici.DataSource = tablo;
            myDatabase.baglanti.Close();
        }
        private void KullaniciOnaylama_Load(object sender, EventArgs e)
        {
            try
            {

            KullaniciGoster();
            }
            catch (Exception ex)
            {

                throw ex;
            }
             
        }

        private void btnKullaniciOnayla_Click(object sender, EventArgs e)
        {

            try
            {
            if (normalKullanici.KullaniciOnayDurum==0){
  
            normalKullanici.KullaniciOnaylama();
            MessageBox.Show(normalKullanici.KullaniciID + " ID 'li"+normalKullanici.İsim+" "+normalKullanici.Soyisim+" adlı kullanıcı onaylandı...");
              KullaniciGoster();
            }
            else
            {
                MessageBox.Show("Onaylanabilir Kullanici Bulunamadi...");
            }
            }
            catch (Exception ex)
            {

                throw ex;
            }
             
        }

        private void dgvKullanici_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            normalKullanici.KullaniciOnayDurum = Convert.ToByte(dgvKullanici.CurrentRow.Cells[9].Value);
             normalKullanici.KullaniciID = Convert.ToInt32(dgvKullanici.CurrentRow.Cells[0].Value);
             normalKullanici.İsim = dgvKullanici.CurrentRow.Cells[5].Value.ToString();
             normalKullanici.Soyisim = dgvKullanici.CurrentRow.Cells[6].Value.ToString();

            }
            catch (Exception ex)
            {

                throw ex;
            }
               
            
        }

        private void dgvKullanici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

