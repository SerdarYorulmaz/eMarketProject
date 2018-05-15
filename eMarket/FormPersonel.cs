using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eMarket
{
    public partial class FormPersonel : Form
    {
        public FormPersonel()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Market bizimMarket = new Market();

            Uye uye = new Uye { Ad = "Zeynal", Soyad="Kara", ID=1234 };
            Uye uye1 = new Uye { Ad = "Serdar", Soyad = "Kara", ID = 1235 };

            bizimMarket.UyeEkle(uye);
            bizimMarket.UyeEkle(uye1);
        }
    }
}
