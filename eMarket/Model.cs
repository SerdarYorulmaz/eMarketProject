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
        public Decimal ModelFiyatFarki { get; set; }
        public uint ModelStok { get; set; }
        public string ModelKod { get; set; }
    
    }
}
