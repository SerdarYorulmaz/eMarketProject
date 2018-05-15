using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket
{
   public class Musteri:Kisi
    {
        public uint ID { get; set; }
        public KrediKarti KrediKarti { get; set; }
        public Sepet Sepet  { get; set; }

        public Musteri()
        {
            Sepet = new Sepet();
            KrediKarti = new KrediKarti();
        }
        

        public virtual bool SiparisVer(Sepet sepet)
        {
            if(sepet.odemeTipi == Sepet.eOdemeTipi.KREDI_KARTI_ODEME)
            {
                if (KrediKarti.ParaCek(sepet.ToplamTutar))
                {
                    SiparisiTamamla(sepet);

                    return true;
                }
            }
            else if (sepet.odemeTipi == Sepet.eOdemeTipi.KAPIDA_ODEME)
            {
                SiparisiTamamla(sepet);
            }

            return false;
            
        }

        private void SiparisiTamamla(Sepet sepet)
        {
            foreach (Siparis siparis in sepet.SiparisListesi)
            {
                siparis.Urun.Stok -= siparis.Adet;
            }

            // Kapıda ödemenin gerçekleştiği varsayılıyor.
            GelirGider.HesapGetir().Gelir += sepet.ToplamTutar;
        }

        public virtual void SiparisIptalEt(Siparis siparis)
        {
            siparis.Urun.Stok += siparis.Adet;
            GelirGider.HesapGetir().Gelir -= siparis.Urun.Fiyat * siparis.Adet;

            //Bankaya iade işlemi için istek yapıldı varsayılıyor...

        }



    }
}
