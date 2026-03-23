namespace Restaurante
{
    partial class Datos_3_leches
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Datos_3_leches));
            this.Datos = new System.Windows.Forms.Button();
            this.tres_leches_ = new System.Windows.Forms.TextBox();
            this.Pupusas = new System.Windows.Forms.Label();
            this.R_Dtos_3_leches = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Datos
            // 
            this.Datos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datos.Location = new System.Drawing.Point(219, 193);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(105, 39);
            this.Datos.TabIndex = 32;
            this.Datos.Text = "Registrar";
            this.Datos.UseVisualStyleBackColor = false;
            this.Datos.Click += new System.EventHandler(this.Datos_Click);
            // 
            // tres_leches_
            // 
            this.tres_leches_.Location = new System.Drawing.Point(28, 62);
            this.tres_leches_.Name = "tres_leches_";
            this.tres_leches_.Size = new System.Drawing.Size(410, 20);
            this.tres_leches_.TabIndex = 0;
            // 
            // Pupusas
            // 
            this.Pupusas.AutoSize = true;
            this.Pupusas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pupusas.Location = new System.Drawing.Point(25, 32);
            this.Pupusas.Name = "Pupusas";
            this.Pupusas.Size = new System.Drawing.Size(171, 13);
            this.Pupusas.TabIndex = 30;
            this.Pupusas.Text = "¿Cuántos tres leches desea?";
            // 
            // R_Dtos_3_leches
            // 
            this.R_Dtos_3_leches.BackColor = System.Drawing.Color.IndianRed;
            this.R_Dtos_3_leches.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_Dtos_3_leches.ForeColor = System.Drawing.Color.Black;
            this.R_Dtos_3_leches.Location = new System.Drawing.Point(442, 193);
            this.R_Dtos_3_leches.Name = "R_Dtos_3_leches";
            this.R_Dtos_3_leches.Size = new System.Drawing.Size(105, 39);
            this.R_Dtos_3_leches.TabIndex = 29;
            this.R_Dtos_3_leches.Text = "Regresar";
            this.R_Dtos_3_leches.UseVisualStyleBackColor = false;
            this.R_Dtos_3_leches.Click += new System.EventHandler(this.R_Dtos_3_leches_Click);
            // 
            // Datos_3_leches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(573, 265);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.tres_leches_);
            this.Controls.Add(this.Pupusas);
            this.Controls.Add(this.R_Dtos_3_leches);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Datos_3_leches";
            this.Text = "Datos_3_leches";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Datos;
        private System.Windows.Forms.TextBox tres_leches_;
        private System.Windows.Forms.Label Pupusas;
        private System.Windows.Forms.Button R_Dtos_3_leches;
    }
}