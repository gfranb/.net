namespace App.vistas
{
    partial class IDeleteVehiculo
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
            this.btn_eliminar_vehiculo = new System.Windows.Forms.Button();
            this.label_idMatricula = new System.Windows.Forms.Label();
            this.in_vehiculo_eliminar = new System.Windows.Forms.TextBox();
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
            this.button1.TabIndex = 23;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar_vehiculo
            // 
            this.btn_eliminar_vehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_eliminar_vehiculo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.btn_eliminar_vehiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.btn_eliminar_vehiculo.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar_vehiculo.Location = new System.Drawing.Point(260, 207);
            this.btn_eliminar_vehiculo.Name = "btn_eliminar_vehiculo";
            this.btn_eliminar_vehiculo.Size = new System.Drawing.Size(143, 42);
            this.btn_eliminar_vehiculo.TabIndex = 22;
            this.btn_eliminar_vehiculo.Text = "Eliminar Vehiculo";
            this.btn_eliminar_vehiculo.UseVisualStyleBackColor = false;
            this.btn_eliminar_vehiculo.Click += new System.EventHandler(this.btn_eliminar_conductor_Click);
            // 
            // label_idMatricula
            // 
            this.label_idMatricula.AutoSize = true;
            this.label_idMatricula.Location = new System.Drawing.Point(304, 143);
            this.label_idMatricula.Name = "label_idMatricula";
            this.label_idMatricula.Size = new System.Drawing.Size(50, 13);
            this.label_idMatricula.TabIndex = 21;
            this.label_idMatricula.Text = "Matricula";
            this.label_idMatricula.Click += new System.EventHandler(this.label_idConductor_Click);
            // 
            // in_vehiculo_eliminar
            // 
            this.in_vehiculo_eliminar.Location = new System.Drawing.Point(212, 171);
            this.in_vehiculo_eliminar.Name = "in_vehiculo_eliminar";
            this.in_vehiculo_eliminar.Size = new System.Drawing.Size(249, 20);
            this.in_vehiculo_eliminar.TabIndex = 20;
            this.in_vehiculo_eliminar.TextChanged += new System.EventHandler(this.in_conductor_eliminar_TextChanged);
            // 
            // IDeleteVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(707, 504);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_eliminar_vehiculo);
            this.Controls.Add(this.label_idMatricula);
            this.Controls.Add(this.in_vehiculo_eliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IDeleteVehiculo";
            this.Text = "IDeleteVehiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_eliminar_vehiculo;
        private System.Windows.Forms.Label label_idMatricula;
        private System.Windows.Forms.TextBox in_vehiculo_eliminar;
    }
}