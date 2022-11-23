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
using App.controlador;

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
            Controlador controlador = new Controlador();
            List<string> listaVehi = controlador.buscarVehiculo(in_Matricula.Text);
            if (listaVehi != null)
            {
                out_marca_vehiculo.Text = listaVehi[1];
                out_tipo_vehiculo.Text = listaVehi[2];
                out_volumen_gasolina.Text = listaVehi[4];
                out_disponibilidad_vehiculo.Text = listaVehi[3];
                panelDatosVehiculo.Show();
            }
            else
            {
                MessageBox.Show("No se encuentra el Vehículo.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void out_marca_vehiculo_Click(object sender, EventArgs e)
        {

        }

        private void in_Matricula_TextChanged(object sender, EventArgs e)
        {
            Controlador controlador = new Controlador();
            
            

        }

        private void out_volumen_gasolina_Click(object sender, EventArgs e)
        {

        }

        private void volumen_gasolina_Click(object sender, EventArgs e)
        {

        }
    }
}
