﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Mundo. Este es mi primer programa en C#");
        }

        private void btnSegundo_Click(object sender, EventArgs e)
        {
            lblEtiqueta.Text = txtCuadroTexto.Text;
        }
    }
}
