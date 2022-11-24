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
    public partial class IEditConductor : Form
    {
        public IEditConductor()
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void edit_conductor_Click(object sender, EventArgs e)
        {
            List<string> conductor = new List<string>();
            conductor.Add(in_id_conductor.Text);
            conductor.Add(out_nombre_conductor.Text);
            conductor.Add(out_apellido_conductor.Text);
            conductor.Add(out_domicilio_conductor.Text);
            conductor.Add(out_permiso_conductor.Text);
            conductor.Add("false");
            controlador.Controlador controlador = new controlador.Controlador();
            if (controlador.editarConductor(conductor))
            {
                MessageBox.Show("Conductor se ha modificado correctamente.");
            }
            else
            {
                MessageBox.Show("El Conductor no se puedo modificar.");
            }
        }
    }
}
