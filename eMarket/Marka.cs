using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket
{
    class Marka
    {
        public string Adi { get; set; }
        public List<Model> Modeller { get; set; }
        public List<Urun> Urunller { get; set; }

        public Marka()
        {
            Modeller = new List<Model>();
            Urunller = new List<Urun>();
        }
        
        public bool ModelEkle(Model model)
        {

            foreach (Model mModel in Modeller)
                if (model.ID == mModel.ID)
                {
                    return false;
                }

            // Her yeni eklenen model için Otomatik olarak ModelKod üretiliyor...
            model.ModelKod = (Adi[0] + Adi[1]).ToString() + 100 + Modeller.Count + 1;
            Modeller.Add(model);
            return true;
        }

        public bool ModelSil(Model model)
        {

            foreach (Model mModel in Modeller)
                if (model.ID == mModel.ID)
                {
                    Modeller.Remove(model);
                    return true;
                }

            return false;
        }

        public bool ModelGuncelle(Model model)
        {

            foreach (Model mModel in Modeller)
                if (model.ID == mModel.ID)
                {
                    Modeller.Remove(mModel);
                    Modeller.Add(model);
                    return true;
                }

            return false;
        }

        public bool UrunEkle(Urun urun)
        {
            foreach (Urun _urun in Urunller)
            {
                if (urun.ID == _urun.ID)
                    return false;
            }

            Urunller.Add(urun);
            return false;
        }

        public bool UrunSil(Urun urun)
        {
            foreach (Urun _urun in Urunller)
            {
                if (urun.ID == _urun.ID)
                {
                    Urunller.Remove(urun);
                    return true;
                }
                   
            }
            
            return false;
        }

        public bool UrunGuncelle(Urun urun)
        {
            foreach (Urun _urun in Urunller)
            {
                if (urun.ID == _urun.ID)
                {
                    Urunller.Remove(_urun);
                    Urunller.Add(urun);
                }
                    return true;
            }
            
            return false;
        }
    }
}
