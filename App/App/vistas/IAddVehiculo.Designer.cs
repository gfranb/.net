namespace App.vistas
{
    partial class IAddVehiculo
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
            this.btn_add_vehiculo = new System.Windows.Forms.Button();
            this.vehiculoVolumen = new System.Windows.Forms.Label();
            this.in_vehiculo_volumen = new System.Windows.Forms.TextBox();
            this.vehiculoTipo = new System.Windows.Forms.Label();
            this.in_vehiculo_tipo = new System.Windows.Forms.TextBox();
            this.vehiculoMarca = new System.Windows.Forms.Label();
            this.in_vehiculo_marca = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.in_vehiculo_matricula = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_add_vehiculo
            // 
            this.btn_add_vehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_add_vehiculo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.btn_add_vehiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.btn_add_vehiculo.ForeColor = System.Drawing.Color.White;
            this.btn_add_vehiculo.Location = new System.Drawing.Point(274, 246);
            this.btn_add_vehiculo.Name = "btn_add_vehiculo";
            this.btn_add_vehiculo.Size = new System.Drawing.Size(143, 42);
            this.btn_add_vehiculo.TabIndex = 18;
            this.btn_add_vehiculo.Text = "Anadir";
            this.btn_add_vehiculo.UseVisualStyleBackColor = false;
            // 
            // vehiculoVolumen
            // 
            this.vehiculoVolumen.AutoSize = true;
            this.vehiculoVolumen.Location = new System.Drawing.Point(152, 195);
            this.vehiculoVolumen.Name = "vehiculoVolumen";
            this.vehiculoVolumen.Size = new System.Drawing.Size(105, 13);
            this.vehiculoVolumen.TabIndex = 15;
            this.vehiculoVolumen.Text = "Volumen de gasolina";
            // 
            // in_vehiculo_volumen
            // 
            this.in_vehiculo_volumen.Location = new System.Drawing.Point(274, 188);
            this.in_vehiculo_volumen.Name = "in_vehiculo_volumen";
            this.in_vehiculo_volumen.Size = new System.Drawing.Size(249, 20);
            this.in_vehiculo_volumen.TabIndex = 14;
            // 
            // vehiculoTipo
            // 
            this.vehiculoTipo.AutoSize = true;
            this.vehiculoTipo.Location = new System.Drawing.Point(152, 169);
            this.vehiculoTipo.Name = "vehiculoTipo";
            this.vehiculoTipo.Size = new System.Drawing.Size(86, 13);
            this.vehiculoTipo.TabIndex = 13;
            this.vehiculoTipo.Text = "Tipo de vehiculo";
            // 
            // in_vehiculo_tipo
            // 
            this.in_vehiculo_tipo.Location = new System.Drawing.Point(274, 162);
            this.in_vehiculo_tipo.Name = "in_vehiculo_tipo";
            this.in_vehiculo_tipo.Size = new System.Drawing.Size(249, 20);
            this.in_vehiculo_tipo.TabIndex = 12;
            // 
            // vehiculoMarca
            // 
            this.vehiculoMarca.AutoSize = true;
            this.vehiculoMarca.Location = new System.Drawing.Point(152, 143);
            this.vehiculoMarca.Name = "vehiculoMarca";
            this.vehiculoMarca.Size = new System.Drawing.Size(37, 13);
            this.vehiculoMarca.TabIndex = 11;
            this.vehiculoMarca.Text = "Marca";
            this.vehiculoMarca.Click += new System.EventHandler(this.conductorNombre_Click);
            // 
            // in_vehiculo_marca
            // 
            this.in_vehiculo_marca.Location = new System.Drawing.Point(274, 136);
            this.in_vehiculo_marca.Name = "in_vehiculo_marca";
            this.in_vehiculo_marca.Size = new System.Drawing.Size(249, 20);
            this.in_vehiculo_marca.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Matricula";
            // 
            // in_vehiculo_matricula
            // 
            this.in_vehiculo_matricula.Location = new System.Drawing.Point(274, 110);
            this.in_vehiculo_matricula.Name = "in_vehiculo_matricula";
            this.in_vehiculo_matricula.Size = new System.Drawing.Size(249, 20);
            this.in_vehiculo_matricula.TabIndex = 20;
            // 
            // IAddVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(707, 504);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.in_vehiculo_matricula);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_add_vehiculo);
            this.Controls.Add(this.vehiculoVolumen);
            this.Controls.Add(this.in_vehiculo_volumen);
            this.Controls.Add(this.vehiculoTipo);
            this.Controls.Add(this.in_vehiculo_tipo);
            this.Controls.Add(this.vehiculoMarca);
            this.Controls.Add(this.in_vehiculo_marca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IAddVehiculo";
            this.Text = "IAddVehiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add_vehiculo;
        private System.Windows.Forms.Label vehiculoVolumen;
        private System.Windows.Forms.TextBox in_vehiculo_volumen;
        private System.Windows.Forms.Label vehiculoTipo;
        private System.Windows.Forms.TextBox in_vehiculo_tipo;
        private System.Windows.Forms.Label vehiculoMarca;
        private System.Windows.Forms.TextBox in_vehiculo_marca;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox in_vehiculo_matricula;
    }
}