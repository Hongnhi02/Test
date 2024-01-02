﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int a, b, Kq;
            a = int.Parse(txtSo1.Text);
            b = int.Parse(txtSo2.Text);
            Calculation c = new Calculation(a, b);
            Kq = c.Execute("+");
            txtKetQua.Text = Kq.ToString();
        }
    }
}
