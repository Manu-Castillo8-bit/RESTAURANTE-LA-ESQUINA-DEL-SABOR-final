namespace Restaurante
{
    partial class Datos_lasaña
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
            this.Datos = new System.Windows.Forms.Button();
            this.Lasaña_ = new System.Windows.Forms.TextBox();
            this.Pupusas = new System.Windows.Forms.Label();
            this.R_Dtos_platillos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Datos
            // 
            this.Datos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datos.Location = new System.Drawing.Point(215, 196);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(105, 39);
            this.Datos.TabIndex = 32;
            this.Datos.Text = "Registrar";
            this.Datos.UseVisualStyleBackColor = false;
            this.Datos.Click += new System.EventHandler(this.Datos_Click);
            // 
            // Lasaña_
            // 
            this.Lasaña_.Location = new System.Drawing.Point(24, 65);
            this.Lasaña_.Name = "Lasaña_";
            this.Lasaña_.Size = new System.Drawing.Size(410, 20);
            this.Lasaña_.TabIndex = 29;
            // 
            // Pupusas
            // 
            this.Pupusas.AutoSize = true;
            this.Pupusas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pupusas.Location = new System.Drawing.Point(21, 35);
            this.Pupusas.Name = "Pupusas";
            this.Pupusas.Size = new System.Drawing.Size(219, 13);
            this.Pupusas.TabIndex = 31;
            this.Pupusas.Text = "¿Cuántos dólares de pupusas desea?";
            // 
            // R_Dtos_platillos
            // 
            this.R_Dtos_platillos.BackColor = System.Drawing.Color.IndianRed;
            this.R_Dtos_platillos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_Dtos_platillos.ForeColor = System.Drawing.Color.Black;
            this.R_Dtos_platillos.Location = new System.Drawing.Point(438, 196);
            this.R_Dtos_platillos.Name = "R_Dtos_platillos";
            this.R_Dtos_platillos.Size = new System.Drawing.Size(105, 39);
            this.R_Dtos_platillos.TabIndex = 30;
            this.R_Dtos_platillos.Text = "Regresar";
            this.R_Dtos_platillos.UseVisualStyleBackColor = false;
            this.R_Dtos_platillos.Click += new System.EventHandler(this.R_Dtos_platillos_Click);
            // 
            // Datos_lasaña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.Lasaña_);
            this.Controls.Add(this.Pupusas);
            this.Controls.Add(this.R_Dtos_platillos);
            this.Name = "Datos_lasaña";
            this.Text = "Datos_lasaña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Datos;
        private System.Windows.Forms.TextBox Lasaña_;
        private System.Windows.Forms.Label Pupusas;
        private System.Windows.Forms.Button R_Dtos_platillos;
    }
}