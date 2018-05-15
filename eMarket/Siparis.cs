using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket
{
    public class Siparis
    {
        public DateTime VerilisTarihi { get; set; }
        public Urun Urun { get; set; } 
        public uint Adet { get; set; }
        public uint SiparisID { get; set; }

        public Siparis()
        {
            Urun = new Urun();
        }

    }
}
