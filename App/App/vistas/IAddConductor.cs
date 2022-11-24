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
    public partial class IAddConductor : Form
    {
        public IAddConductor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void IAddConductor_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_conductor_Click(object sender, EventArgs e)
        {
            List<string> conductor = new List<string>();
            conductor.Add("25");
            conductor.Add(in_conductor_nombre.Text);
            conductor.Add(in_conductor_apellido.Text);
            conductor.Add(in_conductor_domicilio.Text);
            conductor.Add(in_conductor_permiso.Text);
            conductor.Add("false");

            controlador.Controlador controlador = new controlador.Controlador();
            if (controlador.addConductor(conductor))
            {
                MessageBox.Show("Conductor creado correctamente.");
            }
            else
            {
                MessageBox.Show("El Conductor ya existe.");
            }
        }
    }
}
