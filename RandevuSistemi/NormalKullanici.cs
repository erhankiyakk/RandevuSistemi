using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandevuSistemi
{
    public class NormalKullanici :TumKullanicilar
    {
        public int KullaniciID { get; set; }
        public byte KullaniciOnayDurum { get; set; }
        public DateTime SonGirisZamani { get; set; }
        private MyDatabase myDatabase { get; set; }
        
        public NormalKullanici()
        {
            myDatabase = new MyDatabase();
            KullaniciOnayDurum = 1;
        }

        public void KullaniciOnaylama()
        {


            myDatabase.Sorgu = "Update tblNormalKullanici Set KullaniciOnayDurum=@KullaniciOnayDurum Where NormalKullaniciID=@NormalKullaniciID";
            myDatabase.komut = new SqlCommand(myDatabase.Sorgu, myDatabase.baglanti);
            myDatabase.komut.Parameters.AddWithValue("@NormalKullaniciID", KullaniciID);
            myDatabase.komut.Parameters.AddWithValue("@KullaniciOnayDurum", 1);
            myDatabase.baglanti.Open();
            myDatabase.komut.ExecuteNonQuery();
            myDatabase.baglanti.Close();
            KullaniciOnayDurum = 1;


        }

    }
}
