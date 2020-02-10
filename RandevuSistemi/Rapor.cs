using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RandevuSistemi
{
    public class Rapor : IIslemler
    {
        public List<IsYeri> isYerleri { get;private set; }
        public List<NormalKullanici> normalKullanicilar { get;private set; }
        public NormalKullanici normalKullanici { get; set; }
        public List<Kategori> kategoriler { get; set; }
        public MyDatabase myDatabase { get; set; }
        public string Sorgu { get; private set; }

        public Rapor()
        {
            kategoriler = new List<Kategori>();
            isYerleri = new List<IsYeri>();
            normalKullanicilar = new List<NormalKullanici>();
            myDatabase = new MyDatabase();
            
        }

        public void IsYeriEkle(IsYeri isYeri)
        {
            myDatabase.baglanti.Open();
            myDatabase.Sorgu = "Insert into tblIsYeri (IsYeriIsmi,Adres,TelefonNumarasi) values (@IsYeriIsmi,@Adres,@TelefonNumarasi)";
            myDatabase.komut = new SqlCommand(myDatabase.Sorgu, myDatabase.baglanti);
            myDatabase.komut.Parameters.AddWithValue("@IsYeriIsmi",isYeri.Isim);
            myDatabase.komut.Parameters.AddWithValue("@Adres", isYeri.Adres);
            myDatabase.komut.Parameters.AddWithValue("@TelefonNumarasi", isYeri.TelefonNumarasi);
            myDatabase.komut.ExecuteNonQuery();
            myDatabase.baglanti.Close();
            isYerleri.Add(isYeri);
        }
        public void NormalKullaniciEkle(NormalKullanici normalKullanici)
        {
            normalKullanicilar.Add(normalKullanici);
        }
        public void KategoriEkle()
        {
            myDatabase.baglanti.Open();
            myDatabase.Sorgu = "Select * From tblKategori";
            myDatabase.komut = new SqlCommand(myDatabase.Sorgu, myDatabase.baglanti);
            myDatabase.sqlDataReader = myDatabase.komut.ExecuteReader();
            while (myDatabase.sqlDataReader.Read())
            {
                Kategori kategori = new Kategori();
                kategori.KategoriIsmi = myDatabase.sqlDataReader["KategoriIsmi"].ToString();
                kategori.KategoriID = Convert.ToInt32(myDatabase.sqlDataReader["KategoriID"]);
                kategoriler.Add(kategori);
            }
            myDatabase.baglanti.Close();
        }

        public void IsYeriGuncelle(IsYeri isYeri)
        {
            myDatabase.Sorgu = "Update tblIsYeri Set IsYeriIsmi=@IsYeriIsmi,Adres=@Adres,TelefonNumarasi=@TelefonNumarasi Where IsYeriID=@IsYeriID";
            myDatabase.komut = new SqlCommand(myDatabase.Sorgu, myDatabase.baglanti);
            myDatabase.komut.Parameters.AddWithValue("@IsYeriID", Convert.ToInt32(isYeri.IsYeriID));
            myDatabase.komut.Parameters.AddWithValue("@IsYeriIsmi", isYeri.Isim);
            myDatabase.komut.Parameters.AddWithValue("@Adres", isYeri.Adres);
            myDatabase.komut.Parameters.AddWithValue("@TelefonNumarasi", isYeri.TelefonNumarasi);
            myDatabase.baglanti.Open();
            myDatabase.komut.ExecuteNonQuery();
            myDatabase.baglanti.Close();
            
            //todo database listeye bilgi gecişi
        }
        public List<Kategori> KategoriListesi()
        {
            return kategoriler;
        }
        public void IsYeriSilme(IsYeri isYeri)
        {
            myDatabase.Sorgu = "Delete from tblIsYeri Where IsYeriID=@IsYeriID";
            myDatabase.komut = new SqlCommand(myDatabase.Sorgu, myDatabase.baglanti);
            myDatabase.komut.Parameters.AddWithValue("@IsYeriID", isYeri.IsYeriID);
            myDatabase.baglanti.Open();
            myDatabase.komut.ExecuteNonQuery();
            myDatabase.baglanti.Close();


        }
        public List<IsYeri> IsYeriListesi()
        {
            return isYerleri;
        }

    }
}
