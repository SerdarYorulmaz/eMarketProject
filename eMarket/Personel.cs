using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket
{
  public  class Personel:Kisi
    {
        public string Departman { get; set; }
        public int PersonelID { get; set; }
        public DateTime IseBaslangicTrh { get; set; }
        public Decimal Maas { get; set; }
         
    }
}
