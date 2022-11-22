namespace App.vistas
{
    partial class IShowMercancia
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
            this.btn_buscar_mercancia = new System.Windows.Forms.Button();
            this.mercanciaNombre = new System.Windows.Forms.Label();
            this.in_Matricula = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelDatosMercancia = new System.Windows.Forms.Panel();
            this.out_volumen_mercancia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.out_nombre_mercancia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelDatosMercancia.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_buscar_mercancia
            // 
            this.btn_buscar_mercancia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_buscar_mercancia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.btn_buscar_mercancia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.btn_buscar_mercancia.ForeColor = System.Drawing.Color.White;
            this.btn_buscar_mercancia.Location = new System.Drawing.Point(456, 76);
            this.btn_buscar_mercancia.Name = "btn_buscar_mercancia";
            this.btn_buscar_mercancia.Size = new System.Drawing.Size(104, 44);
            this.btn_buscar_mercancia.TabIndex = 32;
            this.btn_buscar_mercancia.Text = "Buscar Mercancia";
            this.btn_buscar_mercancia.UseVisualStyleBackColor = false;
            this.btn_buscar_mercancia.Click += new System.EventHandler(this.btn_buscar_mercancia_Click);
            // 
            // mercanciaNombre
            // 
            this.mercanciaNombre.AutoSize = true;
            this.mercanciaNombre.Location = new System.Drawing.Point(124, 92);
            this.mercanciaNombre.Name = "mercanciaNombre";
            this.mercanciaNombre.Size = new System.Drawing.Size(71, 13);
            this.mercanciaNombre.TabIndex = 31;
            this.mercanciaNombre.Text = "ID Mercancia";
            // 
            // in_Matricula
            // 
            this.in_Matricula.Location = new System.Drawing.Point(201, 88);
            this.in_Matricula.Name = "in_Matricula";
            this.in_Matricula.Size = new System.Drawing.Size(249, 20);
            this.in_Matricula.TabIndex = 30;
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
            this.button1.TabIndex = 29;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelDatosMercancia
            // 
            this.panelDatosMercancia.Controls.Add(this.out_volumen_mercancia);
            this.panelDatosMercancia.Controls.Add(this.label1);
            this.panelDatosMercancia.Controls.Add(this.out_nombre_mercancia);
            this.panelDatosMercancia.Controls.Add(this.label2);
            this.panelDatosMercancia.Location = new System.Drawing.Point(128, 142);
            this.panelDatosMercancia.Name = "panelDatosMercancia";
            this.panelDatosMercancia.Size = new System.Drawing.Size(432, 282);
            this.panelDatosMercancia.TabIndex = 34;
            // 
            // out_volumen_mercancia
            // 
            this.out_volumen_mercancia.AutoSize = true;
            this.out_volumen_mercancia.BackColor = System.Drawing.Color.Transparent;
            this.out_volumen_mercancia.Location = new System.Drawing.Point(194, 110);
            this.out_volumen_mercancia.Name = "out_volumen_mercancia";
            this.out_volumen_mercancia.Size = new System.Drawing.Size(157, 13);
            this.out_volumen_mercancia.TabIndex = 26;
            this.out_volumen_mercancia.Text = "Aqui muestra el tipo de vehiculo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Volumen disponible:";
            // 
            // out_nombre_mercancia
            // 
            this.out_nombre_mercancia.AutoSize = true;
            this.out_nombre_mercancia.BackColor = System.Drawing.Color.Transparent;
            this.out_nombre_mercancia.Location = new System.Drawing.Point(194, 85);
            this.out_nombre_mercancia.Name = "out_nombre_mercancia";
            this.out_nombre_mercancia.Size = new System.Drawing.Size(117, 13);
            this.out_nombre_mercancia.TabIndex = 24;
            this.out_nombre_mercancia.Text = "Aqui muestra el nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nombre:";
            // 
            // IShowMercancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 504);
            this.Controls.Add(this.panelDatosMercancia);
            this.Controls.Add(this.btn_buscar_mercancia);
            this.Controls.Add(this.mercanciaNombre);
            this.Controls.Add(this.in_Matricula);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IShowMercancia";
            this.Text = "IShowMercancia";
            this.Load += new System.EventHandler(this.IShowMercancia_Load);
            this.panelDatosMercancia.ResumeLayout(false);
            this.panelDatosMercancia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_buscar_mercancia;
        private System.Windows.Forms.Label mercanciaNombre;
        private System.Windows.Forms.TextBox in_Matricula;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelDatosMercancia;
        private System.Windows.Forms.Label out_volumen_mercancia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label out_nombre_mercancia;
        private System.Windows.Forms.Label label2;
    }
}