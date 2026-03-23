namespace Restaurante
{
    partial class Datos_chocolate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Datos_chocolate));
            this.Datos = new System.Windows.Forms.Button();
            this.Chocolate_ = new System.Windows.Forms.TextBox();
            this.Panes = new System.Windows.Forms.Label();
            this.R_Dtos_chocolate = new System.Windows.Forms.Button();
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
            // Chocolate_
            // 
            this.Chocolate_.Location = new System.Drawing.Point(28, 62);
            this.Chocolate_.Name = "Chocolate_";
            this.Chocolate_.Size = new System.Drawing.Size(410, 20);
            this.Chocolate_.TabIndex = 0;
            // 
            // Panes
            // 
            this.Panes.AutoSize = true;
            this.Panes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panes.Location = new System.Drawing.Point(25, 32);
            this.Panes.Name = "Panes";
            this.Panes.Size = new System.Drawing.Size(171, 13);
            this.Panes.TabIndex = 38;
            this.Panes.Text = "¿Cuántos chocolates desea?";
            // 
            // R_Dtos_chocolate
            // 
            this.R_Dtos_chocolate.BackColor = System.Drawing.Color.IndianRed;
            this.R_Dtos_chocolate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_Dtos_chocolate.ForeColor = System.Drawing.Color.Black;
            this.R_Dtos_chocolate.Location = new System.Drawing.Point(442, 193);
            this.R_Dtos_chocolate.Name = "R_Dtos_chocolate";
            this.R_Dtos_chocolate.Size = new System.Drawing.Size(105, 39);
            this.R_Dtos_chocolate.TabIndex = 37;
            this.R_Dtos_chocolate.Text = "Regresar";
            this.R_Dtos_chocolate.UseVisualStyleBackColor = false;
            this.R_Dtos_chocolate.Click += new System.EventHandler(this.R_Dtos_chocolate_Click);
            // 
            // Datos_chocolate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(573, 265);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.Chocolate_);
            this.Controls.Add(this.Panes);
            this.Controls.Add(this.R_Dtos_chocolate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Datos_chocolate";
            this.Text = "Datos_chocolate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Datos;
        private System.Windows.Forms.TextBox Chocolate_;
        private System.Windows.Forms.Label Panes;
        private System.Windows.Forms.Button R_Dtos_chocolate;
    }
}