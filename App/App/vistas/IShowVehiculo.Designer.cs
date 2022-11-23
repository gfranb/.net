namespace App.vistas
{
    partial class IShowVehiculo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btn_show_vehiculo = new System.Windows.Forms.Button();
            this.conductorNombre = new System.Windows.Forms.Label();
            this.in_Matricula = new System.Windows.Forms.TextBox();
            this.panelDatosVehiculo = new System.Windows.Forms.Panel();
            this.out_disponibilidad_vehiculo = new System.Windows.Forms.Label();
            this.disponibilidad_vehiculo = new System.Windows.Forms.Label();
            this.out_volumen_gasolina = new System.Windows.Forms.Label();
            this.volumen_gasolina = new System.Windows.Forms.Label();
            this.out_tipo_vehiculo = new System.Windows.Forms.Label();
            this.tipo_vehiculo = new System.Windows.Forms.Label();
            this.out_marca_vehiculo = new System.Windows.Forms.Label();
            this.marca_vehiculo = new System.Windows.Forms.Label();
            this.panelDatosVehiculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(16, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 21;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_show_vehiculo
            // 
            this.btn_show_vehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_show_vehiculo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.btn_show_vehiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.btn_show_vehiculo.ForeColor = System.Drawing.Color.White;
            this.btn_show_vehiculo.Location = new System.Drawing.Point(623, 106);
            this.btn_show_vehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_show_vehiculo.Name = "btn_show_vehiculo";
            this.btn_show_vehiculo.Size = new System.Drawing.Size(139, 54);
            this.btn_show_vehiculo.TabIndex = 27;
            this.btn_show_vehiculo.Text = "Buscar Vehiculo";
            this.btn_show_vehiculo.UseVisualStyleBackColor = false;
            this.btn_show_vehiculo.Click += new System.EventHandler(this.button2_Click);
            // 
            // conductorNombre
            // 
            this.conductorNombre.AutoSize = true;
            this.conductorNombre.Location = new System.Drawing.Point(208, 126);
            this.conductorNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conductorNombre.Name = "conductorNombre";
            this.conductorNombre.Size = new System.Drawing.Size(61, 16);
            this.conductorNombre.TabIndex = 26;
            this.conductorNombre.Text = "Matricula";
            this.conductorNombre.Click += new System.EventHandler(this.conductorNombre_Click);
            // 
            // in_Matricula
            // 
            this.in_Matricula.Location = new System.Drawing.Point(283, 121);
            this.in_Matricula.Margin = new System.Windows.Forms.Padding(4);
            this.in_Matricula.Name = "in_Matricula";
            this.in_Matricula.Size = new System.Drawing.Size(331, 22);
            this.in_Matricula.TabIndex = 25;
            this.in_Matricula.TextChanged += new System.EventHandler(this.in_Matricula_TextChanged);
            // 
            // panelDatosVehiculo
            // 
            this.panelDatosVehiculo.Controls.Add(this.out_disponibilidad_vehiculo);
            this.panelDatosVehiculo.Controls.Add(this.disponibilidad_vehiculo);
            this.panelDatosVehiculo.Controls.Add(this.out_volumen_gasolina);
            this.panelDatosVehiculo.Controls.Add(this.volumen_gasolina);
            this.panelDatosVehiculo.Controls.Add(this.out_tipo_vehiculo);
            this.panelDatosVehiculo.Controls.Add(this.tipo_vehiculo);
            this.panelDatosVehiculo.Controls.Add(this.out_marca_vehiculo);
            this.panelDatosVehiculo.Controls.Add(this.marca_vehiculo);
            this.panelDatosVehiculo.Location = new System.Drawing.Point(199, 212);
            this.panelDatosVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.panelDatosVehiculo.Name = "panelDatosVehiculo";
            this.panelDatosVehiculo.Size = new System.Drawing.Size(576, 347);
            this.panelDatosVehiculo.TabIndex = 34;
            // 
            // out_disponibilidad_vehiculo
            // 
            this.out_disponibilidad_vehiculo.AutoSize = true;
            this.out_disponibilidad_vehiculo.BackColor = System.Drawing.Color.Transparent;
            this.out_disponibilidad_vehiculo.Location = new System.Drawing.Point(259, 196);
            this.out_disponibilidad_vehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.out_disponibilidad_vehiculo.Name = "out_disponibilidad_vehiculo";
            this.out_disponibilidad_vehiculo.Size = new System.Drawing.Size(187, 16);
            this.out_disponibilidad_vehiculo.TabIndex = 30;
            this.out_disponibilidad_vehiculo.Text = "Aqui muestra la disponibilidad";
            // 
            // disponibilidad_vehiculo
            // 
            this.disponibilidad_vehiculo.AutoSize = true;
            this.disponibilidad_vehiculo.Location = new System.Drawing.Point(113, 196);
            this.disponibilidad_vehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.disponibilidad_vehiculo.Name = "disponibilidad_vehiculo";
            this.disponibilidad_vehiculo.Size = new System.Drawing.Size(97, 16);
            this.disponibilidad_vehiculo.TabIndex = 29;
            this.disponibilidad_vehiculo.Text = "Disponibilidad:";
            // 
            // out_volumen_gasolina
            // 
            this.out_volumen_gasolina.AutoSize = true;
            this.out_volumen_gasolina.BackColor = System.Drawing.Color.Transparent;
            this.out_volumen_gasolina.Location = new System.Drawing.Point(259, 166);
            this.out_volumen_gasolina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.out_volumen_gasolina.Name = "out_volumen_gasolina";
            this.out_volumen_gasolina.Size = new System.Drawing.Size(227, 16);
            this.out_volumen_gasolina.TabIndex = 28;
            this.out_volumen_gasolina.Text = "Aqui muestra el volumen de gasolina";
            this.out_volumen_gasolina.Click += new System.EventHandler(this.out_volumen_gasolina_Click);
            // 
            // volumen_gasolina
            // 
            this.volumen_gasolina.AutoSize = true;
            this.volumen_gasolina.Location = new System.Drawing.Point(113, 166);
            this.volumen_gasolina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.volumen_gasolina.Name = "volumen_gasolina";
            this.volumen_gasolina.Size = new System.Drawing.Size(115, 16);
            this.volumen_gasolina.TabIndex = 27;
            this.volumen_gasolina.Text = "Gasolina restante:";
            this.volumen_gasolina.Click += new System.EventHandler(this.volumen_gasolina_Click);
            // 
            // out_tipo_vehiculo
            // 
            this.out_tipo_vehiculo.AutoSize = true;
            this.out_tipo_vehiculo.BackColor = System.Drawing.Color.Transparent;
            this.out_tipo_vehiculo.Location = new System.Drawing.Point(259, 135);
            this.out_tipo_vehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.out_tipo_vehiculo.Name = "out_tipo_vehiculo";
            this.out_tipo_vehiculo.Size = new System.Drawing.Size(196, 16);
            this.out_tipo_vehiculo.TabIndex = 26;
            this.out_tipo_vehiculo.Text = "Aqui muestra el tipo de vehiculo";
            // 
            // tipo_vehiculo
            // 
            this.tipo_vehiculo.AutoSize = true;
            this.tipo_vehiculo.Location = new System.Drawing.Point(113, 135);
            this.tipo_vehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tipo_vehiculo.Name = "tipo_vehiculo";
            this.tipo_vehiculo.Size = new System.Drawing.Size(110, 16);
            this.tipo_vehiculo.TabIndex = 25;
            this.tipo_vehiculo.Text = "Tipo de vehiculo:";
            // 
            // out_marca_vehiculo
            // 
            this.out_marca_vehiculo.AutoSize = true;
            this.out_marca_vehiculo.BackColor = System.Drawing.Color.Transparent;
            this.out_marca_vehiculo.Location = new System.Drawing.Point(259, 105);
            this.out_marca_vehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.out_marca_vehiculo.Name = "out_marca_vehiculo";
            this.out_marca_vehiculo.Size = new System.Drawing.Size(148, 16);
            this.out_marca_vehiculo.TabIndex = 24;
            this.out_marca_vehiculo.Text = "Aqui muestra el nombre";
            this.out_marca_vehiculo.Click += new System.EventHandler(this.out_marca_vehiculo_Click);
            // 
            // marca_vehiculo
            // 
            this.marca_vehiculo.AutoSize = true;
            this.marca_vehiculo.Location = new System.Drawing.Point(113, 105);
            this.marca_vehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.marca_vehiculo.Name = "marca_vehiculo";
            this.marca_vehiculo.Size = new System.Drawing.Size(48, 16);
            this.marca_vehiculo.TabIndex = 23;
            this.marca_vehiculo.Text = "Marca:";
            // 
            // IShowVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(943, 620);
            this.Controls.Add(this.panelDatosVehiculo);
            this.Controls.Add(this.btn_show_vehiculo);
            this.Controls.Add(this.conductorNombre);
            this.Controls.Add(this.in_Matricula);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IShowVehiculo";
            this.Text = "IShowVehiculo";
            this.panelDatosVehiculo.ResumeLayout(false);
            this.panelDatosVehiculo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_show_vehiculo;
        private System.Windows.Forms.Label conductorNombre;
        private System.Windows.Forms.TextBox in_Matricula;
        private System.Windows.Forms.Panel panelDatosVehiculo;
        private System.Windows.Forms.Label out_disponibilidad_vehiculo;
        private System.Windows.Forms.Label disponibilidad_vehiculo;
        private System.Windows.Forms.Label out_volumen_gasolina;
        private System.Windows.Forms.Label volumen_gasolina;
        private System.Windows.Forms.Label out_tipo_vehiculo;
        private System.Windows.Forms.Label tipo_vehiculo;
        private System.Windows.Forms.Label out_marca_vehiculo;
        private System.Windows.Forms.Label marca_vehiculo;
    }
}