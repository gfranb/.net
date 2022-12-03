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
    public partial class IOdoo : Form
    {
        public IOdoo()
        {
            InitializeComponent();
        }

        private void seleccion_ruta_Click(object sender, EventArgs e)
        {

        }

        private void ruta3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ruta2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ruta1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            controlador.Controlador conector = new controlador.Controlador();

            if (op1.Checked)
            {
                conector.exportarXML(1);
                conector.runPythonScript(1);
            }
            if (op2.Checked)
            {
                conector.exportarXML(2);
                conector.runPythonScript(2);
            }
            if (op3.Checked)
            {
                conector.exportarXML(3);
                conector.runPythonScript(3);
            }
            if (op4.Checked)
            {
                conector.exportarXML(4);
                conector.runPythonScript(4);
            }
            if (op5.Checked)
            {
                conector.exportarXML(5);
                conector.runPythonScript(5);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            controlador.Controlador conector = new controlador.Controlador();

            if (op1.Checked)
            {
                conector.importarXML(1);
                
            }
            if (op2.Checked)
            {
                conector.importarXML(2);
            }
            if (op3.Checked)
            {
                conector.importarXML(3);
            }
            if (op4.Checked)
            {
                conector.importarXML(4);
            }
            if (op5.Checked)
            {
                conector.importarXML(5);
            }
        }
    }
}
