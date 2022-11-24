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
            this.btn_eliminar_conductor.Location = new System.Drawing.Point(364, 326);
            this.btn_eliminar_conductor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_eliminar_conductor.Name = "btn_eliminar_conductor";
            this.btn_eliminar_conductor.Size = new System.Drawing.Size(191, 52);
            this.btn_eliminar_conductor.TabIndex = 18;
            this.btn_eliminar_conductor.Text = "Eliminar Conductor";
            this.btn_eliminar_conductor.UseVisualStyleBackColor = false;
            this.btn_eliminar_conductor.Click += new System.EventHandler(this.btn_eliminar_conductor_Click);
            // 
            // label_idConductor
            // 
            this.label_idConductor.AutoSize = true;
            this.label_idConductor.Location = new System.Drawing.Point(409, 246);
            this.label_idConductor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_idConductor.Name = "label_idConductor";
            this.label_idConductor.Size = new System.Drawing.Size(84, 16);
            this.label_idConductor.TabIndex = 11;
            this.label_idConductor.Text = "ID Conductor";
            this.label_idConductor.Click += new System.EventHandler(this.conductorNombre_Click);
            // 
            // in_conductor_eliminar
            // 
            this.in_conductor_eliminar.Location = new System.Drawing.Point(300, 282);
            this.in_conductor_eliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.in_conductor_eliminar.Name = "in_conductor_eliminar";
            this.in_conductor_eliminar.Size = new System.Drawing.Size(331, 22);
            this.in_conductor_eliminar.TabIndex = 10;
            this.in_conductor_eliminar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.button1.TabIndex = 19;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IDeleteConductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(943, 620);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_eliminar_conductor);
            this.Controls.Add(this.label_idConductor);
            this.Controls.Add(this.in_conductor_eliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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