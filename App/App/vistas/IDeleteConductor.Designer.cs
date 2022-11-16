namespace App.vistas
{
    partial class IDeleteConductor
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
            this.btn_eliminar_conductor = new System.Windows.Forms.Button();
            this.label_idConductor = new System.Windows.Forms.Label();
            this.in_conductor_eliminar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_eliminar_conductor
            // 
            this.btn_eliminar_conductor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_eliminar_conductor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.btn_eliminar_conductor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.btn_eliminar_conductor.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar_conductor.Location = new System.Drawing.Point(273, 265);
            this.btn_eliminar_conductor.Name = "btn_eliminar_conductor";
            this.btn_eliminar_conductor.Size = new System.Drawing.Size(143, 42);
            this.btn_eliminar_conductor.TabIndex = 18;
            this.btn_eliminar_conductor.Text = "Eliminar Conductor";
            this.btn_eliminar_conductor.UseVisualStyleBackColor = false;
            // 
            // label_idConductor
            // 
            this.label_idConductor.AutoSize = true;
            this.label_idConductor.Location = new System.Drawing.Point(307, 200);
            this.label_idConductor.Name = "label_idConductor";
            this.label_idConductor.Size = new System.Drawing.Size(70, 13);
            this.label_idConductor.TabIndex = 11;
            this.label_idConductor.Text = "ID Conductor";
            this.label_idConductor.Click += new System.EventHandler(this.conductorNombre_Click);
            // 
            // in_conductor_eliminar
            // 
            this.in_conductor_eliminar.Location = new System.Drawing.Point(225, 229);
            this.in_conductor_eliminar.Name = "in_conductor_eliminar";
            this.in_conductor_eliminar.Size = new System.Drawing.Size(249, 20);
            this.in_conductor_eliminar.TabIndex = 10;
            this.in_conductor_eliminar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IDeleteConductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(707, 504);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_eliminar_conductor);
            this.Controls.Add(this.label_idConductor);
            this.Controls.Add(this.in_conductor_eliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IDeleteConductor";
            this.Text = "IDeleteConductor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_eliminar_conductor;
        private System.Windows.Forms.Label label_idConductor;
        private System.Windows.Forms.TextBox in_conductor_eliminar;
        private System.Windows.Forms.Button button1;
    }
}