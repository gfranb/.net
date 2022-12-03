namespace App.vistas
{
    partial class IOdoo
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
            this.seleccion_ruta = new System.Windows.Forms.Label();
            this.op3 = new System.Windows.Forms.RadioButton();
            this.op2 = new System.Windows.Forms.RadioButton();
            this.op1 = new System.Windows.Forms.RadioButton();
            this.op4 = new System.Windows.Forms.RadioButton();
            this.op5 = new System.Windows.Forms.RadioButton();
            this.cargar = new System.Windows.Forms.Button();
            this.cargarBD = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.button1.TabIndex = 41;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // seleccion_ruta
            // 
            this.seleccion_ruta.AutoSize = true;
            this.seleccion_ruta.Location = new System.Drawing.Point(292, 94);
            this.seleccion_ruta.Name = "seleccion_ruta";
            this.seleccion_ruta.Size = new System.Drawing.Size(101, 13);
            this.seleccion_ruta.TabIndex = 45;
            this.seleccion_ruta.Text = "Conexion con Odoo";
            this.seleccion_ruta.Click += new System.EventHandler(this.seleccion_ruta_Click);
            // 
            // op3
            // 
            this.op3.AutoSize = true;
            this.op3.Location = new System.Drawing.Point(209, 237);
            this.op3.Name = "op3";
            this.op3.Size = new System.Drawing.Size(66, 17);
            this.op3.TabIndex = 44;
            this.op3.TabStop = true;
            this.op3.Text = "Vehiculo";
            this.op3.UseVisualStyleBackColor = true;
            this.op3.CheckedChanged += new System.EventHandler(this.ruta3_CheckedChanged);
            // 
            // op2
            // 
            this.op2.AutoSize = true;
            this.op2.Location = new System.Drawing.Point(209, 214);
            this.op2.Name = "op2";
            this.op2.Size = new System.Drawing.Size(75, 17);
            this.op2.TabIndex = 43;
            this.op2.TabStop = true;
            this.op2.Text = "Mercancia";
            this.op2.UseVisualStyleBackColor = false;
            this.op2.CheckedChanged += new System.EventHandler(this.ruta2_CheckedChanged);
            // 
            // op1
            // 
            this.op1.AutoSize = true;
            this.op1.Location = new System.Drawing.Point(209, 191);
            this.op1.Name = "op1";
            this.op1.Size = new System.Drawing.Size(74, 17);
            this.op1.TabIndex = 42;
            this.op1.TabStop = true;
            this.op1.Text = "Conductor";
            this.op1.UseVisualStyleBackColor = true;
            this.op1.CheckedChanged += new System.EventHandler(this.ruta1_CheckedChanged);
            // 
            // op4
            // 
            this.op4.AutoSize = true;
            this.op4.Location = new System.Drawing.Point(209, 260);
            this.op4.Name = "op4";
            this.op4.Size = new System.Drawing.Size(63, 17);
            this.op4.TabIndex = 46;
            this.op4.TabStop = true;
            this.op4.Text = "Pedidos";
            this.op4.UseVisualStyleBackColor = true;
            // 
            // op5
            // 
            this.op5.AutoSize = true;
            this.op5.Location = new System.Drawing.Point(209, 283);
            this.op5.Name = "op5";
            this.op5.Size = new System.Drawing.Size(53, 17);
            this.op5.TabIndex = 47;
            this.op5.TabStop = true;
            this.op5.Text = "Rutas";
            this.op5.UseVisualStyleBackColor = true;
            // 
            // cargar
            // 
            this.cargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.cargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.cargar.ForeColor = System.Drawing.Color.White;
            this.cargar.Location = new System.Drawing.Point(354, 191);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(143, 42);
            this.cargar.TabIndex = 48;
            this.cargar.Text = "Cargar Odoo";
            this.cargar.UseVisualStyleBackColor = false;
            this.cargar.Click += new System.EventHandler(this.button2_Click);
            // 
            // cargarBD
            // 
            this.cargarBD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cargarBD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.cargarBD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.cargarBD.ForeColor = System.Drawing.Color.White;
            this.cargarBD.Location = new System.Drawing.Point(354, 258);
            this.cargarBD.Name = "cargarBD";
            this.cargarBD.Size = new System.Drawing.Size(143, 42);
            this.cargarBD.TabIndex = 49;
            this.cargarBD.Text = "Cargar BD";
            this.cargarBD.UseVisualStyleBackColor = false;
            this.cargarBD.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // IOdoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(691, 465);
            this.Controls.Add(this.cargarBD);
            this.Controls.Add(this.cargar);
            this.Controls.Add(this.op5);
            this.Controls.Add(this.op4);
            this.Controls.Add(this.seleccion_ruta);
            this.Controls.Add(this.op3);
            this.Controls.Add(this.op2);
            this.Controls.Add(this.op1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IOdoo";
            this.Text = "IOdoo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label seleccion_ruta;
        private System.Windows.Forms.RadioButton op3;
        private System.Windows.Forms.RadioButton op2;
        private System.Windows.Forms.RadioButton op1;
        private System.Windows.Forms.RadioButton op4;
        private System.Windows.Forms.RadioButton op5;
        private System.Windows.Forms.Button cargar;
        private System.Windows.Forms.Button cargarBD;
    }
}