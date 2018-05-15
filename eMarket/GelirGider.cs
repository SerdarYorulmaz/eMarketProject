using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket
{
    public class GelirGider
    {
        private decimal kar { get; set; }
        public decimal Gelir { get; set; }
        public decimal Maliyet { get; set; }

        private static GelirGider gelirGider;

        private GelirGider()
        {

        }

        public decimal KarHesapla()
        {
            kar = Gelir - Maliyet;
            return kar;
        }

        public static GelirGider HesapGetir()
        {
            lock (gelirGider)
            {
                if (gelirGider == null)
                {
                    gelirGider = new GelirGider();

                }

                return gelirGider;
            }
        }

    }
}
