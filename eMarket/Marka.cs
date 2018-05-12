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

        public Marka()
        {
            Modeller = new List<Model>();
        }
        
        public bool ModelEkle(Model model)
        {
            if (model == null)
                return false;

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
    }
}
