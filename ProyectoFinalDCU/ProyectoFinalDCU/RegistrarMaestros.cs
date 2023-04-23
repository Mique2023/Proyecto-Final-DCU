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
    public partial class Registrar_Maestros : Form
    {
        public Registrar_Maestros()
        {
            InitializeComponent();
        }

        private void Registrar_Maestros_Load(object sender, EventArgs e)
        {

        }

        private void Cerrar(object sender, FormClosingEventArgs e)
        {
            Pantalla_Principal ventana = new Pantalla_Principal();
            ventana.Visible = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Pantalla_Principal ventana = new Pantalla_Principal();
            ventana.Visible = true;
            this.Visible = false;
        }
    }
}
