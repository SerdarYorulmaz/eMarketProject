using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket
{
    public class Urun
    {
        public uint ID { get; set; }
        public Decimal Fiyat { get; set; }
        public string Adi { get; set; }
        public string Aciklama { get; set; }
        public string Yorum { get; set; }
        public uint Stok { get; set; }
    }
}
