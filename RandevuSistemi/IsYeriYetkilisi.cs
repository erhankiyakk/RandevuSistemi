using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandevuSistemi
{
    public class IsYeriYetkilisi:TumKullanicilar
    {
        public int IsYeriYetkilisiID { get; set; }
        public DateTime DogumTarihi { get; set; }
        public ulong TCKimlikNumarasi { get; set; }
    }
}
