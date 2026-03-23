namespace Restaurante
{
    partial class Datos_panes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Datos_panes));
            this.Datos = new System.Windows.Forms.Button();
            this.Panes_ = new System.Windows.Forms.TextBox();
            this.Panes = new System.Windows.Forms.Label();
            this.R_Dtos_panes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Datos
            // 
            this.Datos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datos.Location = new System.Drawing.Point(219, 193);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(105, 39);
            this.Datos.TabIndex = 36;
            this.Datos.Text = "Registrar";
            this.Datos.UseVisualStyleBackColor = false;
            this.Datos.Click += new System.EventHandler(this.Datos_Click);
            // 
            // Panes_
            // 
            this.Panes_.Location = new System.Drawing.Point(28, 62);
            this.Panes_.Name = "Panes_";
            this.Panes_.Size = new System.Drawing.Size(410, 20);
            this.Panes_.TabIndex = 0;
            // 
            // Panes
            // 
            this.Panes.AutoSize = true;
            this.Panes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panes.Location = new System.Drawing.Point(25, 32);
            this.Panes.Name = "Panes";
            this.Panes.Size = new System.Drawing.Size(199, 13);
            this.Panes.TabIndex = 34;
            this.Panes.Text = "¿Cuántas panes con pollo desea?";
            // 
            // R_Dtos_panes
            // 
            this.R_Dtos_panes.BackColor = System.Drawing.Color.IndianRed;
            this.R_Dtos_panes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_Dtos_panes.ForeColor = System.Drawing.Color.Black;
            this.R_Dtos_panes.Location = new System.Drawing.Point(442, 193);
            this.R_Dtos_panes.Name = "R_Dtos_panes";
            this.R_Dtos_panes.Size = new System.Drawing.Size(105, 39);
            this.R_Dtos_panes.TabIndex = 33;
            this.R_Dtos_panes.Text = "Regresar";
            this.R_Dtos_panes.UseVisualStyleBackColor = false;
            this.R_Dtos_panes.Click += new System.EventHandler(this.R_Dtos_panes_Click);
            // 
            // Datos_panes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(573, 265);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.Panes_);
            this.Controls.Add(this.Panes);
            this.Controls.Add(this.R_Dtos_panes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Datos_panes";
            this.Text = "Datos_panes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Datos;
        private System.Windows.Forms.TextBox Panes_;
        private System.Windows.Forms.Label Panes;
        private System.Windows.Forms.Button R_Dtos_panes;
    }
}