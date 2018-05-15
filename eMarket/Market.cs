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
        public Iletisim Iletisim { get; set; }
        public List<Uye> UyeListesi { get; set; }
        public List<Personel> PersonelListesi { get; set; }
        public List<Kategori> KategoriListesi { get; set; }
        public VeriTabani veriTabani;
        public GelirGider gelirGider;

        public Market()
        {
            Iletisim = new Iletisim();
            UyeListesi = new List<Uye>();
            PersonelListesi = new List<Personel>();
            KategoriListesi = new List<Kategori>();
        }

        public bool UyeEkle(Uye uye)
        {
            foreach (Uye _uye in UyeListesi)
            {
                if (uye.ID == _uye.ID)
                    return false;
            }

            UyeListesi.Add(uye);
            return true;
        }

        public void UyeSil(Uye uye)
        {
            foreach (Uye _uye in UyeListesi)
            {
                if (uye.ID == _uye.ID)
                {
                    UyeListesi.Remove(_uye);
                }
            }
        }

        public void UyeGuncelle(Uye uye)
        {
            foreach (Uye _uye in UyeListesi)
            {
                if (uye.ID == _uye.ID)
                {
                    UyeListesi.Remove(_uye);
                    UyeListesi.Add(uye);
                }
            }
        }

        public bool PersonelEkle(Personel personel)
        {
            foreach (Personel _personel in PersonelListesi)
            {
                if (personel.ID == _personel.ID)
                    return false;
            }

            PersonelListesi.Add(personel);
            return true;
        }

        public void PersonelSil(Personel personel)
        {
            foreach (Personel _personel in PersonelListesi)
            {
                if (personel.ID == _personel.ID)
                {
                    PersonelListesi.Remove(_personel);
                }
            }
        }

        public void PersonelGuncelle(Personel personel)
        {
            foreach (Personel _personel in PersonelListesi)
            {
                if (personel.ID == _personel.ID)
                {
                    PersonelListesi.Remove(_personel);
                    PersonelListesi.Add(personel);
                }
            }
        }

        public bool KategoriEkle(Kategori kategori)
        {
            foreach (Kategori _kategori in KategoriListesi)
            {
                if (kategori.Adi.Equals(_kategori.Adi))
                    return false;
                    
            }

            KategoriListesi.Add(kategori);
            return true;
        }

        public void KategoriSil(Kategori kategori)
        {
            foreach (Kategori _kategori in KategoriListesi)
            {
                if (kategori.Adi.Equals(_kategori.Adi))
                    KategoriListesi.Remove(kategori);

            }
        }

        public bool KategoriGüncelle(Kategori kategori)
        {
            foreach (Kategori _kategori in KategoriListesi)
            {
                if (kategori.Adi.Equals(_kategori.Adi))
                {
                    KategoriListesi.Remove(_kategori);
                    KategoriListesi.Add(kategori);

                    return true;
                }
                    
            }

            return false;
        }

        public bool UrunEkle(Urun urun, Marka marka)
        {
            return marka.UrunEkle(urun);
        }

        public bool UrunSil(Urun urun, Marka marka)
        {
            return marka.UrunSil(urun);
        }


        public bool UrunGuncelle(Urun urun, Marka marka)
        {
            return marka.UrunGuncelle(urun);
        }

        public List<Urun> BelirliFiyatIleAra(Kategori kategori, Decimal fiyat)
        {
            List<Urun> bulunanUrunler = new List<Urun>();

            foreach (Kategori _kategori in KategoriListesi)
            {
                foreach (Marka _marka in _kategori.Markalar)
                {
                    foreach (Urun urun in _marka.Urunller)
                    {
                        if (urun.Fiyat <= fiyat)
                        {
                            bulunanUrunler.Add(urun);
                        }
                    }

                    foreach (Model model in _marka.Modeller)
                    {
                        if (model.Fiyat <= fiyat)
                        {
                            bulunanUrunler.Add(model);
                        }
                    }
                }
            }

            return bulunanUrunler;
        }

        public void FiyataGoreArtanListele(Kategori kategori, uint Adet)
        {
            //TODO with heap ...
        }

        public void GenelUrunArama(string arananUrun)
        {
            //TODO with tree
        }



    }
}
