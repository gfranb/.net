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
    public partial class IAddMercancia : Form
    {
        public IAddMercancia()
        {
            InitializeComponent();
        }

        private void conductorNombre_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Mercancia_Click(object sender, EventArgs e)
        {
            List<string> mercancia = new List<string>();
            mercancia.Add("25");
            mercancia.Add(in_mercancia_nombre.Text);
            mercancia.Add(in_mercancia_volumen.Text);
            controlador.Controlador controlador = new controlador.Controlador();
            if (controlador.addMercancia(mercancia))
            {
                MessageBox.Show("Mercancia creada correctamente.");
            }
            else
            {
                MessageBox.Show("La Mercancia ya existe.");
            }
        }
    }
}
