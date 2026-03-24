namespace Restaurante
{
    partial class Datos_tartaleta
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
            this.Tartaleta_ = new System.Windows.Forms.TextBox();
            this.Panes = new System.Windows.Forms.Label();
            this.R_Dtos_tartaletas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Datos
            // 
            this.Datos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datos.Location = new System.Drawing.Point(214, 186);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(105, 39);
            this.Datos.TabIndex = 48;
            this.Datos.Text = "Registrar";
            this.Datos.UseVisualStyleBackColor = false;
            this.Datos.Click += new System.EventHandler(this.Datos_Click);
            // 
            // Tartaleta_
            // 
            this.Tartaleta_.Location = new System.Drawing.Point(23, 55);
            this.Tartaleta_.Name = "Tartaleta_";
            this.Tartaleta_.Size = new System.Drawing.Size(410, 20);
            this.Tartaleta_.TabIndex = 45;
            // 
            // Panes
            // 
            this.Panes.AutoSize = true;
            this.Panes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panes.Location = new System.Drawing.Point(20, 25);
            this.Panes.Name = "Panes";
            this.Panes.Size = new System.Drawing.Size(162, 13);
            this.Panes.TabIndex = 47;
            this.Panes.Text = "¿Cuántas tartaletas desea?";
            // 
            // R_Dtos_tartaletas
            // 
            this.R_Dtos_tartaletas.BackColor = System.Drawing.Color.IndianRed;
            this.R_Dtos_tartaletas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_Dtos_tartaletas.ForeColor = System.Drawing.Color.Black;
            this.R_Dtos_tartaletas.Location = new System.Drawing.Point(437, 186);
            this.R_Dtos_tartaletas.Name = "R_Dtos_tartaletas";
            this.R_Dtos_tartaletas.Size = new System.Drawing.Size(105, 39);
            this.R_Dtos_tartaletas.TabIndex = 46;
            this.R_Dtos_tartaletas.Text = "Regresar";
            this.R_Dtos_tartaletas.UseVisualStyleBackColor = false;
            this.R_Dtos_tartaletas.Click += new System.EventHandler(this.R_Dtos_tartaletas_Click);
            // 
            // Datos_tartaleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.Tartaleta_);
            this.Controls.Add(this.Panes);
            this.Controls.Add(this.R_Dtos_tartaletas);
            this.Name = "Datos_tartaleta";
            this.Text = "Datos_tartaleta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Datos;
        private System.Windows.Forms.TextBox Tartaleta_;
        private System.Windows.Forms.Label Panes;
        private System.Windows.Forms.Button R_Dtos_tartaletas;
    }
}