using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.vistas
{
    public partial class IDeleteConductor : Form
    {
        public IDeleteConductor()
        {
            InitializeComponent();
        }

        private void conductorNombre_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_eliminar_conductor_Click(object sender, EventArgs e)
        {
            controlador.Controlador controlador = new controlador.Controlador();
            if (controlador.deleteConductor(in_conductor_eliminar.Text))
            {
                MessageBox.Show("Conductor eliminado.");
            }
            else
            {
                MessageBox.Show("Conductor no existe.");
            }
        }
    }
}
