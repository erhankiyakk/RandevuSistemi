using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RandevuSistemi
{
    public class MyDatabase
    {
        public SqlCommand komut { get; set; }
        public SqlConnection baglanti { get;private set; }
        public SqlDataAdapter da { get; set; }
        public SqlDataReader sqlDataReader { get; set; }
        public string Sorgu { get; set; }
        public MyDatabase()
        {
            
            baglanti = new SqlConnection(@"Data Source=DESKTOP-4S51J92\SQLEXPRESS;Initial Catalog=Randevu;Integrated Security=True");
        }
    }
}
