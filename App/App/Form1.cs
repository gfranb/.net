using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.SQL;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SQLConnector conexionBD = new SQLConnector();
            conexionBD.showValuesGrid(dataGridView1);

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLConnector conexionBD = new SQLConnector();
            conexionBD.importDataXML();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SQLConnector conexionBD = new SQLConnector();
            conexionBD.exportDataXML();
        }

    }
}
