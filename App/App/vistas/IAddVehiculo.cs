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
    public partial class IAddVehiculo : Form
    {
        public IAddVehiculo()
        {
            InitializeComponent();
        }

        private void conductorNombre_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_vehiculo_Click(object sender, EventArgs e)
        {
            List<string> vehiculo = new List<string>();
            vehiculo.Add(in_vehiculo_matricula.Text);
            vehiculo.Add(in_vehiculo_marca.Text);
            vehiculo.Add(in_vehiculo_tipo.Text);
            vehiculo.Add(in_vehiculo_volumen.Text);

            controlador.Controlador controlador = new controlador.Controlador();
            if (controlador.addVehiculo(vehiculo))
            {
                MessageBox.Show("Vehículo creado correctamente.");
            }
            else
            {
                MessageBox.Show("El Vehículo ya existe.");
            }
        }
    }
}
