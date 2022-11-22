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
    public partial class IDeleteMercancia : Form
    {
        public IDeleteMercancia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_idConductor_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_conductor_Click(object sender, EventArgs e)
        {
            controlador.Controlador controlador = new controlador.Controlador();
            if (controlador.deleteMercancia(in_mercancia_eliminar.Text))
            {
                MessageBox.Show("Mercancia eliminada.");
            }
            else
            {
                MessageBox.Show("Mercancia no existe.");
            }
        }

        private void in_conductor_eliminar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
