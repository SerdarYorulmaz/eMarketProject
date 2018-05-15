using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket
{
    public class Sepet
    {
        public eOdemeTipi odemeTipi { get; set;}
        public List<Siparis> SiparisListesi { get; set; }
        public Decimal ToplamTutar { get; set;}

       public enum eOdemeTipi
        {
            KREDI_KARTI_ODEME,
            KAPIDA_ODEME
        }

        public Sepet()
        {
            SiparisListesi = new List<Siparis>();
            ToplamTutar = 0;

        }
        public void SiparisEkle(Siparis siparis)
        {
            SiparisListesi.Add(siparis);
            ToplamTutar += siparis.Urun.Fiyat * siparis.Adet;

        }
        public void SiparisSil(Siparis siparis)
        {
            SiparisListesi.Remove(siparis);
        }
        public void SiparisGuncelle(Siparis siparis)
        {
            foreach (Siparis _siparis in SiparisListesi)
            {
                if (siparis.SiparisID == _siparis.SiparisID)
                {
                    SiparisListesi.Remove(_siparis);
                    SiparisListesi.Add(siparis);
                }
                    
            }
        }

        public void IndirimHesapla()
        {
            // Çeşitli günlerde indirim yapıldığı varsayılıyor...
        }
    }
}
