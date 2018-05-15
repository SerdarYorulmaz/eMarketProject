using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket
{
    public class KrediKarti
    {
        public string SahibininAdi { get; set; }
        public string SahibininSoyadi { get; set; }
        public ulong IBAN { get; set; }

        public bool ParaCek(decimal miktar)
        {
            // Herzaman yeterli bakiyenin olduğu varsayılacaktır.
            return true;
        }
    }
}
