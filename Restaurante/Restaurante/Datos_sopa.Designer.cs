namespace Restaurante
{
    partial class Datos_sopa
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
            this.Sopa_ = new System.Windows.Forms.TextBox();
            this.Panes = new System.Windows.Forms.Label();
            this.R_Dtos_atol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Datos
            // 
            this.Datos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datos.Location = new System.Drawing.Point(214, 194);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(105, 39);
            this.Datos.TabIndex = 48;
            this.Datos.Text = "Registrar";
            this.Datos.UseVisualStyleBackColor = false;
            this.Datos.Click += new System.EventHandler(this.Datos_Click);
            // 
            // Sopa_
            // 
            this.Sopa_.Location = new System.Drawing.Point(23, 63);
            this.Sopa_.Name = "Sopa_";
            this.Sopa_.Size = new System.Drawing.Size(410, 20);
            this.Sopa_.TabIndex = 45;
            // 
            // Panes
            // 
            this.Panes.AutoSize = true;
            this.Panes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panes.Location = new System.Drawing.Point(20, 33);
            this.Panes.Name = "Panes";
            this.Panes.Size = new System.Drawing.Size(142, 13);
            this.Panes.TabIndex = 47;
            this.Panes.Text = "¿Cuántas sopas desea?";
            // 
            // R_Dtos_atol
            // 
            this.R_Dtos_atol.BackColor = System.Drawing.Color.IndianRed;
            this.R_Dtos_atol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_Dtos_atol.ForeColor = System.Drawing.Color.Black;
            this.R_Dtos_atol.Location = new System.Drawing.Point(437, 194);
            this.R_Dtos_atol.Name = "R_Dtos_atol";
            this.R_Dtos_atol.Size = new System.Drawing.Size(105, 39);
            this.R_Dtos_atol.TabIndex = 46;
            this.R_Dtos_atol.Text = "Regresar";
            this.R_Dtos_atol.UseVisualStyleBackColor = false;
            // 
            // Datos_sopa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.Sopa_);
            this.Controls.Add(this.Panes);
            this.Controls.Add(this.R_Dtos_atol);
            this.Name = "Datos_sopa";
            this.Text = "Datos_sopa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Datos;
        private System.Windows.Forms.TextBox Sopa_;
        private System.Windows.Forms.Label Panes;
        private System.Windows.Forms.Button R_Dtos_atol;
    }
}