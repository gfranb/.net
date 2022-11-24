namespace App.vistas
{
    partial class IAddConductor
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
            this.in_conductor_nombre = new System.Windows.Forms.TextBox();
            this.conductorNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.in_conductor_apellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.in_conductor_domicilio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.in_conductor_permiso = new System.Windows.Forms.TextBox();
            this.btn_add_conductor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(16, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // in_conductor_nombre
            // 
            this.in_conductor_nombre.Location = new System.Drawing.Point(375, 177);
            this.in_conductor_nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.in_conductor_nombre.Name = "in_conductor_nombre";
            this.in_conductor_nombre.Size = new System.Drawing.Size(331, 22);
            this.in_conductor_nombre.TabIndex = 1;
            // 
            // conductorNombre
            // 
            this.conductorNombre.AutoSize = true;
            this.conductorNombre.Location = new System.Drawing.Point(212, 186);
            this.conductorNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conductorNombre.Name = "conductorNombre";
            this.conductorNombre.Size = new System.Drawing.Size(56, 16);
            this.conductorNombre.TabIndex = 2;
            this.conductorNombre.Text = "Nombre";
            this.conductorNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 218);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Apellido";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // in_conductor_apellido
            // 
            this.in_conductor_apellido.Location = new System.Drawing.Point(375, 209);
            this.in_conductor_apellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.in_conductor_apellido.Name = "in_conductor_apellido";
            this.in_conductor_apellido.Size = new System.Drawing.Size(331, 22);
            this.in_conductor_apellido.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 250);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Domicilio";
            // 
            // in_conductor_domicilio
            // 
            this.in_conductor_domicilio.Location = new System.Drawing.Point(375, 241);
            this.in_conductor_domicilio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.in_conductor_domicilio.Name = "in_conductor_domicilio";
            this.in_conductor_domicilio.Size = new System.Drawing.Size(331, 22);
            this.in_conductor_domicilio.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 282);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Permiso de conducir";
            // 
            // in_conductor_permiso
            // 
            this.in_conductor_permiso.Location = new System.Drawing.Point(375, 273);
            this.in_conductor_permiso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.in_conductor_permiso.Name = "in_conductor_permiso";
            this.in_conductor_permiso.Size = new System.Drawing.Size(331, 22);
            this.in_conductor_permiso.TabIndex = 7;
            // 
            // btn_add_conductor
            // 
            this.btn_add_conductor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_add_conductor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.btn_add_conductor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.btn_add_conductor.ForeColor = System.Drawing.Color.White;
            this.btn_add_conductor.Location = new System.Drawing.Point(375, 391);
            this.btn_add_conductor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_add_conductor.Name = "btn_add_conductor";
            this.btn_add_conductor.Size = new System.Drawing.Size(191, 52);
            this.btn_add_conductor.TabIndex = 9;
            this.btn_add_conductor.Text = "Anadir";
            this.btn_add_conductor.UseVisualStyleBackColor = false;
            this.btn_add_conductor.Click += new System.EventHandler(this.btn_add_conductor_Click);
            // 
            // IAddConductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(943, 620);
            this.Controls.Add(this.btn_add_conductor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.in_conductor_permiso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.in_conductor_domicilio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.in_conductor_apellido);
            this.Controls.Add(this.conductorNombre);
            this.Controls.Add(this.in_conductor_nombre);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "IAddConductor";
            this.Text = "IConductor";
            this.Load += new System.EventHandler(this.IAddConductor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox in_conductor_nombre;
        private System.Windows.Forms.Label conductorNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox in_conductor_apellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox in_conductor_domicilio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox in_conductor_permiso;
        private System.Windows.Forms.Button btn_add_conductor;
    }
}