namespace Restaurante
{
    partial class Datos_tortas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Datos_tortas));
            this.Datos = new System.Windows.Forms.Button();
            this.Tortas_ = new System.Windows.Forms.TextBox();
            this.Panes = new System.Windows.Forms.Label();
            this.R_Dtos_tortas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Datos
            // 
            this.Datos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datos.Location = new System.Drawing.Point(219, 193);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(105, 39);
            this.Datos.TabIndex = 40;
            this.Datos.Text = "Registrar";
            this.Datos.UseVisualStyleBackColor = false;
            this.Datos.Click += new System.EventHandler(this.Datos_Click);
            // 
            // Tortas_
            // 
            this.Tortas_.Location = new System.Drawing.Point(28, 62);
            this.Tortas_.Name = "Tortas_";
            this.Tortas_.Size = new System.Drawing.Size(410, 20);
            this.Tortas_.TabIndex = 0;
            // 
            // Panes
            // 
            this.Panes.AutoSize = true;
            this.Panes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panes.Location = new System.Drawing.Point(25, 32);
            this.Panes.Name = "Panes";
            this.Panes.Size = new System.Drawing.Size(141, 13);
            this.Panes.TabIndex = 38;
            this.Panes.Text = "¿Cuántas tortas desea?";
            // 
            // R_Dtos_tortas
            // 
            this.R_Dtos_tortas.BackColor = System.Drawing.Color.IndianRed;
            this.R_Dtos_tortas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_Dtos_tortas.ForeColor = System.Drawing.Color.Black;
            this.R_Dtos_tortas.Location = new System.Drawing.Point(442, 193);
            this.R_Dtos_tortas.Name = "R_Dtos_tortas";
            this.R_Dtos_tortas.Size = new System.Drawing.Size(105, 39);
            this.R_Dtos_tortas.TabIndex = 37;
            this.R_Dtos_tortas.Text = "Regresar";
            this.R_Dtos_tortas.UseVisualStyleBackColor = false;
            this.R_Dtos_tortas.Click += new System.EventHandler(this.R_Dtos_tortas_Click);
            // 
            // Datos_tortas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(573, 265);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.Tortas_);
            this.Controls.Add(this.Panes);
            this.Controls.Add(this.R_Dtos_tortas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Datos_tortas";
            this.Text = "Datos_tortas";
            this.Load += new System.EventHandler(this.Datos_tortas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Datos;
        private System.Windows.Forms.TextBox Tortas_;
        private System.Windows.Forms.Label Panes;
        private System.Windows.Forms.Button R_Dtos_tortas;
    }
}