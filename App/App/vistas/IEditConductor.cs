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
    public partial class IEditConductor : Form
    {
        public IEditConductor()
        {
            InitializeComponent();
            panelDatosConductor.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            out_nombre_conductor.Text = "Gianfranco";
            out_apellido_conductor.Text = "Bonanno";
            out_domicilio_conductor.Text = "Carrer Cartagena 171";
            out_permiso_conductor.Text = "A3123444";

            panelDatosConductor.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
