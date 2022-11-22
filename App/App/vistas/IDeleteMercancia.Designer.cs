namespace App.vistas
{
    partial class IDeleteMercancia
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
            this.btn_eliminar_conductor = new System.Windows.Forms.Button();
            this.label_idMercancia = new System.Windows.Forms.Label();
            this.in_mercancia_eliminar = new System.Windows.Forms.TextBox();
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
            this.button1.TabIndex = 11;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_eliminar_conductor
            // 
            this.btn_eliminar_conductor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_eliminar_conductor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.btn_eliminar_conductor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.btn_eliminar_conductor.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar_conductor.Location = new System.Drawing.Point(367, 289);
            this.btn_eliminar_conductor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_eliminar_conductor.Name = "btn_eliminar_conductor";
            this.btn_eliminar_conductor.Size = new System.Drawing.Size(191, 52);
            this.btn_eliminar_conductor.TabIndex = 21;
            this.btn_eliminar_conductor.Text = "Eliminar Mercancia";
            this.btn_eliminar_conductor.UseVisualStyleBackColor = false;
            this.btn_eliminar_conductor.Click += new System.EventHandler(this.btn_eliminar_conductor_Click);
            // 
            // label_idMercancia
            // 
            this.label_idMercancia.AutoSize = true;
            this.label_idMercancia.Location = new System.Drawing.Point(412, 209);
            this.label_idMercancia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_idMercancia.Name = "label_idMercancia";
            this.label_idMercancia.Size = new System.Drawing.Size(86, 16);
            this.label_idMercancia.TabIndex = 20;
            this.label_idMercancia.Text = "ID Mercancia";
            this.label_idMercancia.Click += new System.EventHandler(this.label_idConductor_Click);
            // 
            // in_mercancia_eliminar
            // 
            this.in_mercancia_eliminar.Location = new System.Drawing.Point(303, 245);
            this.in_mercancia_eliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.in_mercancia_eliminar.Name = "in_mercancia_eliminar";
            this.in_mercancia_eliminar.Size = new System.Drawing.Size(331, 22);
            this.in_mercancia_eliminar.TabIndex = 19;
            this.in_mercancia_eliminar.TextChanged += new System.EventHandler(this.in_conductor_eliminar_TextChanged);
            // 
            // IDeleteMercancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 572);
            this.Controls.Add(this.btn_eliminar_conductor);
            this.Controls.Add(this.label_idMercancia);
            this.Controls.Add(this.in_mercancia_eliminar);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "IDeleteMercancia";
            this.Text = "IDeleteMercancia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_eliminar_conductor;
        private System.Windows.Forms.Label label_idMercancia;
        private System.Windows.Forms.TextBox in_mercancia_eliminar;
    }
}