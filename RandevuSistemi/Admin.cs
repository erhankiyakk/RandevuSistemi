using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandevuSistemi
{
    public class Admin
    {
        public string KullaniciAdi { get;private set; }
        public string Sifre { get;private set; }
        public Admin()
        {
            KullaniciAdi = "Admin";
            Sifre = "1234";
        }
    }
}
