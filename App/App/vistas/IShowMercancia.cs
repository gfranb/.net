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
    public partial class IShowMercancia : Form
    {
        public IShowMercancia()
        {
            InitializeComponent();
            panelDatosMercancia.Visible = false;
        }

        private void marca_vehiculo_Click(object sender, EventArgs e)
        {

        }

        private void btn_buscar_mercancia_Click(object sender, EventArgs e)
        {
            Controlador controlador = new Controlador();
            List<string> listaM = controlador.buscarMercancia(in_Mercancia.Text);
            if (listaM != null)
            {
                out_nombre_mercancia.Text = listaM[1];
                out_volumen_mercancia.Text = listaM[2];
                panelDatosMercancia.Visible = true;
            }
            else
            {
                MessageBox.Show("No se encuentra la Mercancía.");
            }

            
        }

        private void IShowMercancia_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void in_Mercancia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
