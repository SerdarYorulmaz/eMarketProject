using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket
{
    class Kategori
    {
        public string Adi { get; set; }
        public List<Marka> Markalar { get; set; }

        public Kategori()
        {
            Markalar = new List<Marka>();
        }

        public bool MarkaEkle(Marka marka)
        {
            if (marka == null)
                return false;

            foreach (Marka mMarka in Markalar)
                if (marka.Adi.Equals(mMarka.Adi))
                {
                    return false;
                }

            Markalar.Add(marka);
            return true;
        }
    }
}
