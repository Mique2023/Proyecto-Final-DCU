using System;
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
    public partial class Pantalla_Principal : Form
    {
        public Pantalla_Principal()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            Registrar_Maestros ventana = new Registrar_Maestros();
            ventana.Visible = true;
            this.Visible = false;

        }

        private void button22_Click(object sender, EventArgs e)
        {
            Registrar_Maestros ventana = new Registrar_Maestros();
            ventana.Visible = true;
            this.Visible = false;

        }

        private void Pantalla_Principal_Load(object sender, EventArgs e)
        {

        }

        private void Cerrar(object sender, FormClosingEventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.Visible = true;
        }
    }
}
