using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket
{
    public class Sepet
    {
        public Odeme odeme;
        public List<Siparis> SiparisListesi { get; set; }

        public Sepet()
        {
                    this.SiparisListesi = new List<Siparis>();

        }
        public void SiparisEkle(Siparis siparis)
        {
            this.SiparisListesi.Add(siparis);

        }
        public void SiparisSil(Siparis siparis)
        {
            this.SiparisListesi.Remove(siparis);
        }
        public void SiparisGuncelle(Siparis siparis)
        {
            foreach (Siparis arananSiparis in this.SiparisListesi)
            {
                if (arananSiparis.SiparisID == siparis.SiparisID)
                {
                    arananSiparis.Urun = siparis.Urun;
                    arananSiparis.UrunSayisi = siparis.UrunSayisi;
                    arananSiparis.VerilisTarihi = siparis.VerilisTarihi;
                }
                    
            }
        }
    }
}
