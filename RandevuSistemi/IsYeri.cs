using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RandevuSistemi
{
    public class IsYeri:IOnaylama
    {
        public int IsYeriID { get; set; }
        public string Isim { get; set; }
        public Kategori kategori { get; set; }
        public string Adres { get; set; }
        public string TelefonNumarasi { get; set; }
        public MyDatabase myDatabase { get; set; }
        public IsYeri()
        {
            myDatabase = new MyDatabase();
            kategori = new Kategori();
        }
        public void IsYeriKategoriOnaylama()
        {
            myDatabase.Sorgu = "Update tblIsYeri Set KategoriID=@KategoriID Where IsYeriID=@IsYeriID";
            myDatabase.komut = new SqlCommand(myDatabase.Sorgu, myDatabase.baglanti);
            myDatabase.komut.Parameters.AddWithValue("@IsYeriID", IsYeriID);
            myDatabase.komut.Parameters.AddWithValue("@KategoriID", kategori.KategoriID);
            myDatabase.baglanti.Open();
            myDatabase.komut.ExecuteNonQuery();
            myDatabase.baglanti.Close();
            
        }
    }
}
