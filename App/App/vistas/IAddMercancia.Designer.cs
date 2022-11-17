namespace App.vistas
{
    partial class IAddMercancia
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
            this.btn_add_Mercancia = new System.Windows.Forms.Button();
            this.volumenMercancia = new System.Windows.Forms.Label();
            this.in_conductor_apellido = new System.Windows.Forms.TextBox();
            this.mercanciaNombre = new System.Windows.Forms.Label();
            this.in_conductor_nombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_add_Mercancia
            // 
            this.btn_add_Mercancia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_add_Mercancia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.btn_add_Mercancia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.btn_add_Mercancia.ForeColor = System.Drawing.Color.White;
            this.btn_add_Mercancia.Location = new System.Drawing.Point(277, 277);
            this.btn_add_Mercancia.Name = "btn_add_Mercancia";
            this.btn_add_Mercancia.Size = new System.Drawing.Size(143, 42);
            this.btn_add_Mercancia.TabIndex = 19;
            this.btn_add_Mercancia.Text = "Anadir";
            this.btn_add_Mercancia.UseVisualStyleBackColor = false;
            // 
            // volumenMercancia
            // 
            this.volumenMercancia.AutoSize = true;
            this.volumenMercancia.Location = new System.Drawing.Point(155, 191);
            this.volumenMercancia.Name = "volumenMercancia";
            this.volumenMercancia.Size = new System.Drawing.Size(48, 13);
            this.volumenMercancia.TabIndex = 14;
            this.volumenMercancia.Text = "Volumen";
            // 
            // in_conductor_apellido
            // 
            this.in_conductor_apellido.Location = new System.Drawing.Point(277, 184);
            this.in_conductor_apellido.Name = "in_conductor_apellido";
            this.in_conductor_apellido.Size = new System.Drawing.Size(249, 20);
            this.in_conductor_apellido.TabIndex = 13;
            // 
            // mercanciaNombre
            // 
            this.mercanciaNombre.AutoSize = true;
            this.mercanciaNombre.Location = new System.Drawing.Point(155, 165);
            this.mercanciaNombre.Name = "mercanciaNombre";
            this.mercanciaNombre.Size = new System.Drawing.Size(106, 13);
            this.mercanciaNombre.TabIndex = 12;
            this.mercanciaNombre.Text = "Nombre del producto";
            this.mercanciaNombre.Click += new System.EventHandler(this.conductorNombre_Click);
            // 
            // in_conductor_nombre
            // 
            this.in_conductor_nombre.Location = new System.Drawing.Point(277, 158);
            this.in_conductor_nombre.Name = "in_conductor_nombre";
            this.in_conductor_nombre.Size = new System.Drawing.Size(249, 20);
            this.in_conductor_nombre.TabIndex = 11;
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
            this.button1.TabIndex = 10;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IAddMercancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 504);
            this.Controls.Add(this.btn_add_Mercancia);
            this.Controls.Add(this.volumenMercancia);
            this.Controls.Add(this.in_conductor_apellido);
            this.Controls.Add(this.mercanciaNombre);
            this.Controls.Add(this.in_conductor_nombre);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IAddMercancia";
            this.Text = "IAddMercancia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add_Mercancia;
        private System.Windows.Forms.Label volumenMercancia;
        private System.Windows.Forms.TextBox in_conductor_apellido;
        private System.Windows.Forms.Label mercanciaNombre;
        private System.Windows.Forms.TextBox in_conductor_nombre;
        private System.Windows.Forms.Button button1;
    }
}