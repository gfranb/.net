using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.vistas
{
    public partial class IRuta : Form
    {
        public IRuta()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void IRuta_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_gestion_ruta_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_vehiculo_Click(object sender, EventArgs e)
        {

            controlador.Controlador controlador = new controlador.Controlador();
            if (ruta1.Checked == true)
            {
                List<string> dataGestionRuta = new List<string>();
                dataGestionRuta.Add(in_ruta_id.Text);
                dataGestionRuta.Add("1");
                dataGestionRuta.Add(in_ruta_idconductor.Text);
                dataGestionRuta.Add(in_ruta_idvehiculo.Text);
                dataGestionRuta.Add(in_ruta_idmercancia.Text);
                dataGestionRuta.Add(in_ruta_volumen.Text);
                int op = controlador.gestionarRuta(dataGestionRuta);
                if (op == 0)
                {
                    MessageBox.Show("Solicitud registrada con exito");
                }
                else
                {
                    switch (op)
                    {
                        case 1:
                            MessageBox.Show("El conductor no esta disponible"); break;
                        case 2:
                            MessageBox.Show("El vehiculo no esta disponible"); break;
                        case 3:
                            MessageBox.Show("No hay mercancia disponible"); break;
                    }
                }
            }
            if (ruta2.Checked == true)
            {
                List<string> dataGestionRuta = new List<string>();
                dataGestionRuta.Add(in_ruta_id.Text);
                dataGestionRuta.Add("2");
                dataGestionRuta.Add(in_ruta_idconductor.Text);
                dataGestionRuta.Add(in_ruta_idvehiculo.Text);
                dataGestionRuta.Add(in_ruta_idmercancia.Text);
                dataGestionRuta.Add(in_ruta_volumen.Text);
                int op = controlador.gestionarRuta(dataGestionRuta);
                if (op == 0)
                {
                    MessageBox.Show("Solicitud registrada con exito");
                }
                else
                {
                    switch (op)
                    {
                        case 1:
                            MessageBox.Show("El conductor no esta disponible"); break;
                        case 2:
                            MessageBox.Show("El vehiculo no esta disponible"); break;
                        case 3:
                            MessageBox.Show("No hay mercancia disponible"); break;
                    }
                }
            }
            if (ruta3.Checked == true)
            {
                List<string> dataGestionRuta = new List<string>();
                dataGestionRuta.Add(in_ruta_id.Text);
                dataGestionRuta.Add("3");
                dataGestionRuta.Add(in_ruta_idconductor.Text);
                dataGestionRuta.Add(in_ruta_idvehiculo.Text);
                dataGestionRuta.Add(in_ruta_idmercancia.Text);
                dataGestionRuta.Add(in_ruta_volumen.Text);
                int op = controlador.gestionarRuta(dataGestionRuta);
                if (op == 0)
                {
                    MessageBox.Show("Solicitud registrada con exito");
                }
                else
                {
                    switch (op)
                    {
                        case 1:
                            MessageBox.Show("El conductor no esta disponible"); break;
                        case 2:
                            MessageBox.Show("El vehiculo no esta disponible"); break;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
