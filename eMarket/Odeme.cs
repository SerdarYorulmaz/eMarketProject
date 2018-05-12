using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket
{
    public class Odeme
    {
        public decimal Tutar { get; set; }
        public int OdemeID { get; set; }
        enum eOdemeTipi
            {nakit,
             taksitli,
             kapidaOdeme
            }

    }
}
