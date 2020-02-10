using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandevuSistemi
{
    public class IsYeriYetkiliTanimlama:IYetkiliTanimlama
    {
        public IsYeri isYeri { get; set; }
        public IsYeriYetkilisi isYeriYetkilisi { get; set; }
        public byte TanimlamaDurum { get; set; }
        private MyDatabase myDatabase { get; set; }
        

        public IsYeriYetkiliTanimlama()
        {
            myDatabase = new MyDatabase();
        }
       public void tanımla()
        {
            myDatabase.Sorgu = "update tblIsYeri set IsYeriYetkiliID=@isyeriYetkili,YetkiliTanimlamaDurum=@durum where IsYeriID=@isyeri";
            myDatabase.komut= new SqlCommand(myDatabase.Sorgu,myDatabase.baglanti);
            myDatabase.komut.Parameters.AddWithValue("@isyeri", isYeri.IsYeriID);
            myDatabase.komut.Parameters.AddWithValue("@isyeriYetkili", isYeriYetkilisi.IsYeriYetkilisiID);
            myDatabase.komut.Parameters.AddWithValue("@durum", 1);
            myDatabase.baglanti.Open();
            myDatabase.komut.ExecuteNonQuery();
            myDatabase.baglanti.Close();

        }
        public void YetkiliGuncelle()
        {
            myDatabase.Sorgu = "Update tblIsYeriYetkilileri Set IsYeriTanimlamaDurum=@IsYeriDurum Where IsYeriYetkiliID=@IsYeriYetkiliID";
            myDatabase.komut = new SqlCommand(myDatabase.Sorgu, myDatabase.baglanti);
            myDatabase.komut.Parameters.AddWithValue("@IsYeriYetkiliID", isYeriYetkilisi.IsYeriYetkilisiID);
            myDatabase.komut.Parameters.AddWithValue("@IsYeriDurum", 1);
            myDatabase.baglanti.Open();
            myDatabase.komut.ExecuteNonQuery();
            myDatabase.baglanti.Close();
        }
        public void IsYeriGuncelle()
        {

            myDatabase.Sorgu = "Update tblIsYeri Set YetkiliTanimlamaDurum=@YetkiliDurum Where IsYeriID=@IsYeriID";
            myDatabase.komut = new SqlCommand(myDatabase.Sorgu, myDatabase.baglanti);
            myDatabase.komut.Parameters.AddWithValue("@IsYeriID", isYeri.IsYeriID);
            myDatabase.komut.Parameters.AddWithValue("@YetkiliDurum", 1);
            myDatabase.baglanti.Open();
            myDatabase.komut.ExecuteNonQuery();
            myDatabase.baglanti.Close();
        }
    }
}
