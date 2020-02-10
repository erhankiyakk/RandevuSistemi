using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandevuSistemi
{
    interface IIslemler
    {
        void IsYeriEkle(IsYeri isYeri);
        void NormalKullaniciEkle(NormalKullanici normalKullanici);
        void KategoriEkle();
        void IsYeriGuncelle(IsYeri isYeri);
        List<Kategori> KategoriListesi();
        void IsYeriSilme(IsYeri isYeri);
    }

}
