using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.controlador;

namespace App.vistas
{
    public partial class IShowConductor : Form
    {
        public IShowConductor()
        {
            InitializeComponent();
            panelDatosConductor.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Controlador controlador = new Controlador();
            List<string> listaC = controlador.buscarConductor(in_id_conductor.Text);
            if (listaC != null)
            {
                out_nombre_conductor.Text = listaC[1];
                out_apellido_conductor.Text = listaC[2];
                out_domicilio_conductor.Text = listaC[3];
                out_permiso_conductor.Text = listaC[4];
                panelDatosConductor.Show();
            }
            else
            {
                MessageBox.Show("No se encuentra al Conductor.");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelDatosConductor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void out_nombre_conductor_Click(object sender, EventArgs e)
        {

        }

        private void IShowConductor_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void conductorNombre_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
