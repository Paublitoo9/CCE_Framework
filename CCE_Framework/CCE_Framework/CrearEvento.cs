﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CCE
{
    public partial class CrearEvento : Form
    {
        public CrearEvento()
        {
            InitializeComponent();
        }

        private void bAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}