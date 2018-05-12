using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket
{
    class Uye // TODO:  --> :Musteri
    {
        public DateTime KayıtTarihi { get; set; }
        public List<Object> YapilanSiparisler { get; set; } //TODO: object --> Siparis

        public Uye()
        {
            YapilanSiparisler = new List<object>(); //TODO: object --> Siparis
        }

        public bool YorumYap(Urun urun, string uyeYorum)
        {
            if (urun != null)
            {
                urun.Yorum += Environment.NewLine
                             + Environment.NewLine
                             + ""// Adi
                             + " "// Soyadi
                             + Environment.NewLine
                             + uyeYorum;
                return true;
            }

            return false;
        }
    }
}
