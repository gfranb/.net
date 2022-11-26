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
    public partial class IMostrarPedidos : Form
    {
        public IMostrarPedidos()
        {
            InitializeComponent();
        }

        private void IMostrarPedidos_Load(object sender, EventArgs e)
        {
            controlador.Controlador controlador = new controlador.Controlador();
            controlador.mostrarPedidos(dataGridView1);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
