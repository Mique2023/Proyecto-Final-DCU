﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalDCU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            Pantalla_Principal ventana = new Pantalla_Principal();
            ventana.Visible = true;
            this.Visible = false;    
        }

        private void Cerrar(object sender, FormClosingEventArgs e)
        {

        }
    }
}
