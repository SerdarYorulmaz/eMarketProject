using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket
{
   public class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Iletisim Iletisim { get; set; }
        public ulong TC { get; set; }
        public DateTime DogumTarihi { get; set; }

        public Kisi()
        {
            Iletisim = new Iletisim();
        }
    }
}
