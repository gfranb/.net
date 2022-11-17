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
            out_nombre_mercancia.Text = "Mercancia";
            out_volumen_mercancia.Text = "Volumen";

            panelDatosMercancia.Visible = true;
        }

        private void IShowMercancia_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
