﻿using System;
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
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void btnPerGiris_Click(object sender, EventArgs e)
        {
            FormPersonel formPersonel = new FormPersonel();
            this.Hide();
            formPersonel.Show();
            
        }

        private void btnUyeGiris_Click(object sender, EventArgs e)
        {
            FormUye formUye = new FormUye();
            this.Hide();
            formUye.Show();
            
        }
    }
}
