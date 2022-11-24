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
    public partial class IDeleteVehiculo : Form
    {
        public IDeleteVehiculo()
        {
            InitializeComponent();
        }

        private void label_idConductor_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_conductor_Click(object sender, EventArgs e)
        {
            controlador.Controlador controlador = new controlador.Controlador();
            if (controlador.eliminarVehiculo(in_vehiculo_eliminar.Text))
            {
                MessageBox.Show("Vehículo eliminado.");
            }
            else
            {
                MessageBox.Show("Vehículo no existe.");
            }
        }

        private void in_conductor_eliminar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
