using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandevuSistemi
{
    public abstract class TumKullanicilar
    {
        public string İsim { get; set; }
        public string KullaniciAdi { get; set; }
        public string Eposta { get; set; }
        public string Soyisim { get; set; }
        public string Adres { get; set; }
        public ulong TelefonNumarasi { get; set; }
    }
}
