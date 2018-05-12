using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket
{
    class Market
    {
        public string Ad { get; set; }
        public List<object> UyeListesi { get; set; }//todo
        public List<object> PersonelListesi { get; set; }//todo
        public List<object> MusteriListesi { get; set; }//todo

        public Market()
        {
            this.UyeListesi = new List<object>();
            this.PersonelListesi = new List<object>();
            this.MusteriListesi = new List<object>();
        }

        public void UyeEkle(object uye)//todo
        {
            this.UyeListesi.Add(uye);
        }
        public void MusteriEkle(object musteri)//todo
        {
            this.MusteriListesi.Add(musteri);
        }
        public void PersonelEkle(object personel)//todo
        {
            this.PersonelListesi.Add(personel);
        }

    }
}
