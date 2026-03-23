namespace Restaurante
{
    partial class Datospostres
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
            this.Panes = new System.Windows.Forms.Label();
            this.R_Dtos_pastel = new System.Windows.Forms.Button();
            this.p_chocolate_ = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Datos
            // 
            this.Datos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datos.Location = new System.Drawing.Point(219, 193);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(105, 39);
            this.Datos.TabIndex = 47;
            this.Datos.Text = "Registrar";
            this.Datos.UseVisualStyleBackColor = false;
            this.Datos.Click += new System.EventHandler(this.Datos_Click);
            // 
            // Panes
            // 
            this.Panes.AutoSize = true;
            this.Panes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panes.Location = new System.Drawing.Point(25, 32);
            this.Panes.Name = "Panes";
            this.Panes.Size = new System.Drawing.Size(238, 13);
            this.Panes.TabIndex = 46;
            this.Panes.Text = "¿Cuántos pasteles de chocolate desea ?";
            // 
            // R_Dtos_pastel
            // 
            this.R_Dtos_pastel.BackColor = System.Drawing.Color.IndianRed;
            this.R_Dtos_pastel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_Dtos_pastel.ForeColor = System.Drawing.Color.Black;
            this.R_Dtos_pastel.Location = new System.Drawing.Point(442, 193);
            this.R_Dtos_pastel.Name = "R_Dtos_pastel";
            this.R_Dtos_pastel.Size = new System.Drawing.Size(105, 39);
            this.R_Dtos_pastel.TabIndex = 45;
            this.R_Dtos_pastel.Text = "Regresar";
            this.R_Dtos_pastel.UseVisualStyleBackColor = false;
            this.R_Dtos_pastel.Click += new System.EventHandler(this.R_Dtos_pastel_Click);
            // 
            // p_chocolate_
            // 
            this.p_chocolate_.Location = new System.Drawing.Point(28, 82);
            this.p_chocolate_.Name = "p_chocolate_";
            this.p_chocolate_.Size = new System.Drawing.Size(473, 20);
            this.p_chocolate_.TabIndex = 0;
            // 
            // Datospostres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(573, 265);
            this.Controls.Add(this.p_chocolate_);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.Panes);
            this.Controls.Add(this.R_Dtos_pastel);
            this.Name = "Datospostres";
            this.Text = "Datospostres";
            this.Load += new System.EventHandler(this.Datospostres_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Datos;
        private System.Windows.Forms.Label Panes;
        private System.Windows.Forms.Button R_Dtos_pastel;
        private System.Windows.Forms.TextBox p_chocolate_;
    }
}