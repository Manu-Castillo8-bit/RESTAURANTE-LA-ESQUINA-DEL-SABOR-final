namespace Restaurante
{
    partial class Datos_sandwich
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
            this.Sandwich_ = new System.Windows.Forms.TextBox();
            this.Panes = new System.Windows.Forms.Label();
            this.R_Dtos_sandwich = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Datos
            // 
            this.Datos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datos.Location = new System.Drawing.Point(206, 185);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(105, 39);
            this.Datos.TabIndex = 48;
            this.Datos.Text = "Registrar";
            this.Datos.UseVisualStyleBackColor = false;
            this.Datos.Click += new System.EventHandler(this.Datos_Click);
            // 
            // Sandwich_
            // 
            this.Sandwich_.Location = new System.Drawing.Point(15, 54);
            this.Sandwich_.Name = "Sandwich_";
            this.Sandwich_.Size = new System.Drawing.Size(410, 20);
            this.Sandwich_.TabIndex = 45;
            // 
            // Panes
            // 
            this.Panes.AutoSize = true;
            this.Panes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panes.Location = new System.Drawing.Point(12, 24);
            this.Panes.Name = "Panes";
            this.Panes.Size = new System.Drawing.Size(175, 13);
            this.Panes.TabIndex = 47;
            this.Panes.Text = "¿Cuántos sandwiches desea?";
            // 
            // R_Dtos_sandwich
            // 
            this.R_Dtos_sandwich.BackColor = System.Drawing.Color.IndianRed;
            this.R_Dtos_sandwich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_Dtos_sandwich.ForeColor = System.Drawing.Color.Black;
            this.R_Dtos_sandwich.Location = new System.Drawing.Point(429, 185);
            this.R_Dtos_sandwich.Name = "R_Dtos_sandwich";
            this.R_Dtos_sandwich.Size = new System.Drawing.Size(105, 39);
            this.R_Dtos_sandwich.TabIndex = 46;
            this.R_Dtos_sandwich.Text = "Regresar";
            this.R_Dtos_sandwich.UseVisualStyleBackColor = false;
            this.R_Dtos_sandwich.Click += new System.EventHandler(this.R_Dtos_sandwich_Click);
            // 
            // Datos_sandwich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.Sandwich_);
            this.Controls.Add(this.Panes);
            this.Controls.Add(this.R_Dtos_sandwich);
            this.Name = "Datos_sandwich";
            this.Text = "Datos_sandwich";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Datos;
        private System.Windows.Forms.TextBox Sandwich_;
        private System.Windows.Forms.Label Panes;
        private System.Windows.Forms.Button R_Dtos_sandwich;
    }
}