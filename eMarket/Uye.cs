using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket
{
    class Uye: Musteri
    {
        public DateTime KayıtTarihi { get; set; }
        public List<Siparis> YapilanSiparisler{ get; set; }

        public Uye()
        {
            YapilanSiparisler = new List<Siparis>();
        }

        

        public override bool SiparisVer(Sepet sepet)
        {
            if (base.SiparisVer(sepet))
            {
                foreach (Siparis siparis in sepet.SiparisListesi)
                {
                    YapilanSiparisler.Add(siparis);
                }
                return true;
            }

            return false;
        }

        public override void SiparisIptalEt(Siparis siparis)
        {
            base.SiparisIptalEt(siparis);

            foreach (Siparis _siparis in YapilanSiparisler)
            {
                if (siparis.SiparisID == _siparis.SiparisID)
                    YapilanSiparisler.Remove(siparis);
            }
        }

        public bool SiparisGuncelle(Siparis siparis)
        {
            foreach (Siparis _siparis in YapilanSiparisler)
            {
                if (siparis.SiparisID == _siparis.SiparisID)
                {
                    YapilanSiparisler.Remove(_siparis);
                    YapilanSiparisler.Add(siparis);

                    return true;
                }
            }

            return false;
        }

        public bool YorumYap(Urun urun, string uyeYorum)
        {
            if (urun != null)
            {
                urun.Yorum += Environment.NewLine
                             + Environment.NewLine
                             + Ad
                             + " "+ Soyad
                             + Environment.NewLine
                             + uyeYorum;
                return true;
            }

            return false;
        }
    }
}
