namespace App.vistas
{
    partial class IRuta
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
            this.btn_gestion_ruta = new System.Windows.Forms.Button();
            this.in_ruta_idvehiculo = new System.Windows.Forms.TextBox();
            this.in_ruta_idmercancia = new System.Windows.Forms.TextBox();
            this.in_ruta_idconductor = new System.Windows.Forms.TextBox();
            this.in_ruta_volumen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.seleccion_ruta = new System.Windows.Forms.Label();
            this.ruta3 = new System.Windows.Forms.RadioButton();
            this.ruta2 = new System.Windows.Forms.RadioButton();
            this.ruta1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btn_gestion_ruta
            // 
            this.btn_gestion_ruta.Location = new System.Drawing.Point(440, 289);
            this.btn_gestion_ruta.Name = "btn_gestion_ruta";
            this.btn_gestion_ruta.Size = new System.Drawing.Size(106, 23);
            this.btn_gestion_ruta.TabIndex = 36;
            this.btn_gestion_ruta.Text = "Realizar solicitud";
            this.btn_gestion_ruta.UseVisualStyleBackColor = true;
            this.btn_gestion_ruta.Click += new System.EventHandler(this.btn_gestion_ruta_Click);
            // 
            // in_ruta_idvehiculo
            // 
            this.in_ruta_idvehiculo.Location = new System.Drawing.Point(356, 251);
            this.in_ruta_idvehiculo.Name = "in_ruta_idvehiculo";
            this.in_ruta_idvehiculo.Size = new System.Drawing.Size(299, 20);
            this.in_ruta_idvehiculo.TabIndex = 35;
            // 
            // in_ruta_idmercancia
            // 
            this.in_ruta_idmercancia.Location = new System.Drawing.Point(356, 230);
            this.in_ruta_idmercancia.Name = "in_ruta_idmercancia";
            this.in_ruta_idmercancia.Size = new System.Drawing.Size(299, 20);
            this.in_ruta_idmercancia.TabIndex = 34;
            // 
            // in_ruta_idconductor
            // 
            this.in_ruta_idconductor.Location = new System.Drawing.Point(356, 209);
            this.in_ruta_idconductor.Name = "in_ruta_idconductor";
            this.in_ruta_idconductor.Size = new System.Drawing.Size(299, 20);
            this.in_ruta_idconductor.TabIndex = 33;
            // 
            // in_ruta_volumen
            // 
            this.in_ruta_volumen.Location = new System.Drawing.Point(356, 188);
            this.in_ruta_volumen.Name = "in_ruta_volumen";
            this.in_ruta_volumen.Size = new System.Drawing.Size(299, 20);
            this.in_ruta_volumen.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Id Vehiculo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Id Mercancia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Id Conductor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Volumen a transportar";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // seleccion_ruta
            // 
            this.seleccion_ruta.AutoSize = true;
            this.seleccion_ruta.Location = new System.Drawing.Point(104, 180);
            this.seleccion_ruta.Name = "seleccion_ruta";
            this.seleccion_ruta.Size = new System.Drawing.Size(44, 13);
            this.seleccion_ruta.TabIndex = 23;
            this.seleccion_ruta.Text = "RUTAS";
            // 
            // ruta3
            // 
            this.ruta3.AutoSize = true;
            this.ruta3.Location = new System.Drawing.Point(64, 254);
            this.ruta3.Name = "ruta3";
            this.ruta3.Size = new System.Drawing.Size(123, 17);
            this.ruta3.TabIndex = 22;
            this.ruta3.TabStop = true;
            this.ruta3.Text = "Barcelona - Valencia";
            this.ruta3.UseVisualStyleBackColor = true;
            // 
            // ruta2
            // 
            this.ruta2.AutoSize = true;
            this.ruta2.Location = new System.Drawing.Point(64, 231);
            this.ruta2.Name = "ruta2";
            this.ruta2.Size = new System.Drawing.Size(127, 17);
            this.ruta2.TabIndex = 21;
            this.ruta2.TabStop = true;
            this.ruta2.Text = "Barcelona - Zaragoza";
            this.ruta2.UseVisualStyleBackColor = false;
            // 
            // ruta1
            // 
            this.ruta1.AutoSize = true;
            this.ruta1.Location = new System.Drawing.Point(64, 208);
            this.ruta1.Name = "ruta1";
            this.ruta1.Size = new System.Drawing.Size(114, 17);
            this.ruta1.TabIndex = 20;
            this.ruta1.TabStop = true;
            this.ruta1.Text = "Barcelona - Madrid";
            this.ruta1.UseVisualStyleBackColor = true;
            // 
            // IRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 504);
            this.Controls.Add(this.btn_gestion_ruta);
            this.Controls.Add(this.in_ruta_idvehiculo);
            this.Controls.Add(this.in_ruta_idmercancia);
            this.Controls.Add(this.in_ruta_idconductor);
            this.Controls.Add(this.in_ruta_volumen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.seleccion_ruta);
            this.Controls.Add(this.ruta3);
            this.Controls.Add(this.ruta2);
            this.Controls.Add(this.ruta1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IRuta";
            this.Text = "IRuta";
            this.Load += new System.EventHandler(this.IRuta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_gestion_ruta;
        private System.Windows.Forms.TextBox in_ruta_idvehiculo;
        private System.Windows.Forms.TextBox in_ruta_idmercancia;
        private System.Windows.Forms.TextBox in_ruta_idconductor;
        private System.Windows.Forms.TextBox in_ruta_volumen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label seleccion_ruta;
        private System.Windows.Forms.RadioButton ruta3;
        private System.Windows.Forms.RadioButton ruta2;
        private System.Windows.Forms.RadioButton ruta1;
    }
}