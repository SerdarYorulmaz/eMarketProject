﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket
{
    public class VeriTabani
    {
        public string Adi { get; set; }
        private static VeriTabani veriTabani;

        private VeriTabani()
        {
            //Todo : Veri bağlantısı veya ilgili kayıt işlemleri.
        }

        public static VeriTabani VeriTabaniGetir()
        {
            lock (veriTabani)
            {
                if (veriTabani == null)
                    veriTabani = new VeriTabani();

                return veriTabani;
            }
        }
    }
}
