using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket
{
  public class Iletisim
    {
        public ulong Telefon { get; set; }
        public string Email { get; set; }
        public Adres Adres { get; set; }
        public Iletisim()
        {
            Adres = new Adres();
        }
         

    }

}
