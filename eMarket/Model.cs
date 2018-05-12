using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket
{
    class Model: Urun
    {
        public string Renk { get; set; }
        public Decimal Fiyat { get; set; }
        public uint Stok { get; set; }
        public string ModelKod { get; set; }
    
    }
}
