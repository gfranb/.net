using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.modelo;

namespace App.vistas
{
    public partial class IShowVehiculo : Form
    {
        public IShowVehiculo()
        {
            InitializeComponent();
            panelDatosVehiculo.Visible = false;
        }

        private void conductorNombre_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
                    out_marca_vehiculo.Text = "a";
                    out_tipo_vehiculo.Text = "a";
                    out_disponibilidad_vehiculo.Text = "a";
                    panelDatosVehiculo.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void out_marca_vehiculo_Click(object sender, EventArgs e)
        {

        }
    }
}
