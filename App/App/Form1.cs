using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.SQL;
using App.vistas;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panelConductorSubMenu.Visible = false;
            panelVehiculosSubMenu.Visible = false;
            panelMercanciaSubMenu.Visible = false;

        }

        private void hideSubMenu()
        {
            if (panelConductorSubMenu.Visible == true)
                panelConductorSubMenu.Visible = false;
            if (panelVehiculosSubMenu.Visible == true)
                panelVehiculosSubMenu.Visible = false;
            if (panelMercanciaSubMenu.Visible == true)
                panelMercanciaSubMenu.Visible = false;

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnRuta_Click(object sender, EventArgs e)
        {

        }

        private void textTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelConductorSubMenu);
        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            showSubMenu(panelVehiculosSubMenu);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildrenForm(new IDeleteVehiculo());
        }

        private void btnMercancia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMercanciaSubMenu);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private Form formularioActivo = null;
        private void openChildrenForm(Form childForm)
        {
            if(formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(childForm);
            panelContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnAddConductor_Click(object sender, EventArgs e)
        {
            openChildrenForm(new IAddConductor());
        }

        private void btnDeleteConductor_Click(object sender, EventArgs e)
        {
            openChildrenForm(new IDeleteConductor());
        }

        private void btnShowConductor_Click(object sender, EventArgs e)
        {
            openChildrenForm(new IShowConductor());
        }

        private void btnEditConductor_Click(object sender, EventArgs e)
        {
            openChildrenForm(new IEditConductor());
        }

        private void btnAddVehiculo_Click(object sender, EventArgs e)
        {
            openChildrenForm(new IAddVehiculo());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildrenForm(new IShowVehiculo());
        }
    }
}
