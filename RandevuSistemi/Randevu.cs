using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandevuSistemi
{
    public class Randevu
    {
        public NormalKullanici normalKullanici { get; set; }
        public IsYeri isYeri { get; set; }
        public IsYeriYetkilisi isYeriYetkilisi { get; set; }
        public byte BaslamaSaati { get; set; }
        public DateTime Tarih { get; set; }
    }
}
