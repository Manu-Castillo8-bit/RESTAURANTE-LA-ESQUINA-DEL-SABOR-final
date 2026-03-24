namespace Restaurante
{
    partial class Datos_carne
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
            this.Carne_ = new System.Windows.Forms.TextBox();
            this.Pupusas = new System.Windows.Forms.Label();
            this.R_Dtos_platillos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Datos
            // 
            this.Datos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datos.Location = new System.Drawing.Point(221, 180);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(105, 39);
            this.Datos.TabIndex = 32;
            this.Datos.Text = "Registrar";
            this.Datos.UseVisualStyleBackColor = false;
            this.Datos.Click += new System.EventHandler(this.Datos_Click);
            // 
            // Carne_
            // 
            this.Carne_.Location = new System.Drawing.Point(30, 49);
            this.Carne_.Name = "Carne_";
            this.Carne_.Size = new System.Drawing.Size(410, 20);
            this.Carne_.TabIndex = 29;
            // 
            // Pupusas
            // 
            this.Pupusas.AutoSize = true;
            this.Pupusas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pupusas.Location = new System.Drawing.Point(27, 19);
            this.Pupusas.Name = "Pupusas";
            this.Pupusas.Size = new System.Drawing.Size(197, 13);
            this.Pupusas.TabIndex = 31;
            this.Pupusas.Text = "¿Cuántos platos de carne desea?";
            // 
            // R_Dtos_platillos
            // 
            this.R_Dtos_platillos.BackColor = System.Drawing.Color.IndianRed;
            this.R_Dtos_platillos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_Dtos_platillos.ForeColor = System.Drawing.Color.Black;
            this.R_Dtos_platillos.Location = new System.Drawing.Point(444, 180);
            this.R_Dtos_platillos.Name = "R_Dtos_platillos";
            this.R_Dtos_platillos.Size = new System.Drawing.Size(105, 39);
            this.R_Dtos_platillos.TabIndex = 30;
            this.R_Dtos_platillos.Text = "Regresar";
            this.R_Dtos_platillos.UseVisualStyleBackColor = false;
            this.R_Dtos_platillos.Click += new System.EventHandler(this.R_Dtos_platillos_Click);
            // 
            // Datos_carne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.Carne_);
            this.Controls.Add(this.Pupusas);
            this.Controls.Add(this.R_Dtos_platillos);
            this.Name = "Datos_carne";
            this.Text = "Datos_carne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Datos;
        private System.Windows.Forms.TextBox Carne_;
        private System.Windows.Forms.Label Pupusas;
        private System.Windows.Forms.Button R_Dtos_platillos;
    }
}