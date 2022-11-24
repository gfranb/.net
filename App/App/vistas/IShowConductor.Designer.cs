namespace App.vistas
{
    partial class IShowConductor
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
            this.button2 = new System.Windows.Forms.Button();
            this.conductorNombre = new System.Windows.Forms.Label();
            this.in_id_conductor = new System.Windows.Forms.TextBox();
            this.panelDatosConductor = new System.Windows.Forms.Panel();
            this.out_permiso_conductor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.out_domicilio_conductor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.out_apellido_conductor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.out_nombre_conductor = new System.Windows.Forms.Label();
            this.nombre_conductor = new System.Windows.Forms.Label();
            this.panelDatosConductor.SuspendLayout();
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
            this.button1.TabIndex = 20;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(603, 102);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 54);
            this.button2.TabIndex = 23;
            this.button2.Text = "Buscar Conductor";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // conductorNombre
            // 
            this.conductorNombre.AutoSize = true;
            this.conductorNombre.Location = new System.Drawing.Point(161, 121);
            this.conductorNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conductorNombre.Name = "conductorNombre";
            this.conductorNombre.Size = new System.Drawing.Size(84, 16);
            this.conductorNombre.TabIndex = 22;
            this.conductorNombre.Text = "ID Conductor";
            this.conductorNombre.Click += new System.EventHandler(this.conductorNombre_Click);
            // 
            // in_id_conductor
            // 
            this.in_id_conductor.Location = new System.Drawing.Point(263, 117);
            this.in_id_conductor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.in_id_conductor.Name = "in_id_conductor";
            this.in_id_conductor.Size = new System.Drawing.Size(331, 22);
            this.in_id_conductor.TabIndex = 21;
            this.in_id_conductor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panelDatosConductor
            // 
            this.panelDatosConductor.Controls.Add(this.out_permiso_conductor);
            this.panelDatosConductor.Controls.Add(this.label3);
            this.panelDatosConductor.Controls.Add(this.out_domicilio_conductor);
            this.panelDatosConductor.Controls.Add(this.label4);
            this.panelDatosConductor.Controls.Add(this.out_apellido_conductor);
            this.panelDatosConductor.Controls.Add(this.label2);
            this.panelDatosConductor.Controls.Add(this.out_nombre_conductor);
            this.panelDatosConductor.Controls.Add(this.nombre_conductor);
            this.panelDatosConductor.Location = new System.Drawing.Point(165, 164);
            this.panelDatosConductor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDatosConductor.Name = "panelDatosConductor";
            this.panelDatosConductor.Size = new System.Drawing.Size(576, 347);
            this.panelDatosConductor.TabIndex = 24;
            this.panelDatosConductor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDatosConductor_Paint);
            // 
            // out_permiso_conductor
            // 
            this.out_permiso_conductor.AutoSize = true;
            this.out_permiso_conductor.BackColor = System.Drawing.Color.Transparent;
            this.out_permiso_conductor.Location = new System.Drawing.Point(287, 192);
            this.out_permiso_conductor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.out_permiso_conductor.Name = "out_permiso_conductor";
            this.out_permiso_conductor.Size = new System.Drawing.Size(156, 16);
            this.out_permiso_conductor.TabIndex = 30;
            this.out_permiso_conductor.Text = "Aqui muestra el domicilio";
            this.out_permiso_conductor.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Permiso de conducir";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // out_domicilio_conductor
            // 
            this.out_domicilio_conductor.AutoSize = true;
            this.out_domicilio_conductor.BackColor = System.Drawing.Color.Transparent;
            this.out_domicilio_conductor.Location = new System.Drawing.Point(287, 162);
            this.out_domicilio_conductor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.out_domicilio_conductor.Name = "out_domicilio_conductor";
            this.out_domicilio_conductor.Size = new System.Drawing.Size(156, 16);
            this.out_domicilio_conductor.TabIndex = 28;
            this.out_domicilio_conductor.Text = "Aqui muestra el domicilio";
            this.out_domicilio_conductor.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Domicilio:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // out_apellido_conductor
            // 
            this.out_apellido_conductor.AutoSize = true;
            this.out_apellido_conductor.BackColor = System.Drawing.Color.Transparent;
            this.out_apellido_conductor.Location = new System.Drawing.Point(287, 132);
            this.out_apellido_conductor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.out_apellido_conductor.Name = "out_apellido_conductor";
            this.out_apellido_conductor.Size = new System.Drawing.Size(151, 16);
            this.out_apellido_conductor.TabIndex = 26;
            this.out_apellido_conductor.Text = "Aqui muestra el apellido";
            this.out_apellido_conductor.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Apellido:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // out_nombre_conductor
            // 
            this.out_nombre_conductor.AutoSize = true;
            this.out_nombre_conductor.BackColor = System.Drawing.Color.Transparent;
            this.out_nombre_conductor.Location = new System.Drawing.Point(287, 101);
            this.out_nombre_conductor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.out_nombre_conductor.Name = "out_nombre_conductor";
            this.out_nombre_conductor.Size = new System.Drawing.Size(148, 16);
            this.out_nombre_conductor.TabIndex = 24;
            this.out_nombre_conductor.Text = "Aqui muestra el nombre";
            this.out_nombre_conductor.Click += new System.EventHandler(this.out_nombre_conductor_Click);
            // 
            // nombre_conductor
            // 
            this.nombre_conductor.AutoSize = true;
            this.nombre_conductor.Location = new System.Drawing.Point(141, 101);
            this.nombre_conductor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombre_conductor.Name = "nombre_conductor";
            this.nombre_conductor.Size = new System.Drawing.Size(59, 16);
            this.nombre_conductor.TabIndex = 23;
            this.nombre_conductor.Text = "Nombre:";
            this.nombre_conductor.Click += new System.EventHandler(this.label1_Click);
            // 
            // IShowConductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(943, 620);
            this.Controls.Add(this.panelDatosConductor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.conductorNombre);
            this.Controls.Add(this.in_id_conductor);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "IShowConductor";
            this.Text = "IShowConductor";
            this.Load += new System.EventHandler(this.IShowConductor_Load);
            this.panelDatosConductor.ResumeLayout(false);
            this.panelDatosConductor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label conductorNombre;
        private System.Windows.Forms.TextBox in_id_conductor;
        private System.Windows.Forms.Panel panelDatosConductor;
        private System.Windows.Forms.Label nombre_conductor;
        private System.Windows.Forms.Label out_nombre_conductor;
        private System.Windows.Forms.Label out_apellido_conductor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label out_domicilio_conductor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label out_permiso_conductor;
        private System.Windows.Forms.Label label3;
    }
}