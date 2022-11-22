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
            this.in_mercancia_volumen = new System.Windows.Forms.TextBox();
            this.mercanciaNombre = new System.Windows.Forms.Label();
            this.in_mercancia_nombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_add_Mercancia
            // 
            this.btn_add_Mercancia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_add_Mercancia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.btn_add_Mercancia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.btn_add_Mercancia.ForeColor = System.Drawing.Color.White;
            this.btn_add_Mercancia.Location = new System.Drawing.Point(369, 341);
            this.btn_add_Mercancia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_add_Mercancia.Name = "btn_add_Mercancia";
            this.btn_add_Mercancia.Size = new System.Drawing.Size(191, 52);
            this.btn_add_Mercancia.TabIndex = 19;
            this.btn_add_Mercancia.Text = "Anadir";
            this.btn_add_Mercancia.UseVisualStyleBackColor = false;
            this.btn_add_Mercancia.Click += new System.EventHandler(this.btn_add_Mercancia_Click);
            // 
            // volumenMercancia
            // 
            this.volumenMercancia.AutoSize = true;
            this.volumenMercancia.Location = new System.Drawing.Point(207, 235);
            this.volumenMercancia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.volumenMercancia.Name = "volumenMercancia";
            this.volumenMercancia.Size = new System.Drawing.Size(60, 16);
            this.volumenMercancia.TabIndex = 14;
            this.volumenMercancia.Text = "Volumen";
            // 
            // in_mercancia_volumen
            // 
            this.in_mercancia_volumen.Location = new System.Drawing.Point(369, 226);
            this.in_mercancia_volumen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.in_mercancia_volumen.Name = "in_mercancia_volumen";
            this.in_mercancia_volumen.Size = new System.Drawing.Size(331, 22);
            this.in_mercancia_volumen.TabIndex = 13;
            // 
            // mercanciaNombre
            // 
            this.mercanciaNombre.AutoSize = true;
            this.mercanciaNombre.Location = new System.Drawing.Point(207, 203);
            this.mercanciaNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mercanciaNombre.Name = "mercanciaNombre";
            this.mercanciaNombre.Size = new System.Drawing.Size(134, 16);
            this.mercanciaNombre.TabIndex = 12;
            this.mercanciaNombre.Text = "Nombre del producto";
            this.mercanciaNombre.Click += new System.EventHandler(this.conductorNombre_Click);
            // 
            // in_mercancia_nombre
            // 
            this.in_mercancia_nombre.Location = new System.Drawing.Point(369, 194);
            this.in_mercancia_nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.in_mercancia_nombre.Name = "in_mercancia_nombre";
            this.in_mercancia_nombre.Size = new System.Drawing.Size(331, 22);
            this.in_mercancia_nombre.TabIndex = 11;
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
            this.button1.TabIndex = 10;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IAddMercancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 620);
            this.Controls.Add(this.btn_add_Mercancia);
            this.Controls.Add(this.volumenMercancia);
            this.Controls.Add(this.in_mercancia_volumen);
            this.Controls.Add(this.mercanciaNombre);
            this.Controls.Add(this.in_mercancia_nombre);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "IAddMercancia";
            this.Text = "IAddMercancia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add_Mercancia;
        private System.Windows.Forms.Label volumenMercancia;
        private System.Windows.Forms.TextBox in_mercancia_volumen;
        private System.Windows.Forms.Label mercanciaNombre;
        private System.Windows.Forms.TextBox in_mercancia_nombre;
        private System.Windows.Forms.Button button1;
    }
}