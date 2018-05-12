using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket
{
    class GelirGider
    {
        public decimal Kar { get; set; }
        private decimal gelir { get; set; }
        private decimal maliyet { get; set; }

        public decimal KarHesapla()
        {
            return this.gelir - this.maliyet;
        }

        public void HesapGuncelle(object urun)//todo
        {

        }

    }
}
