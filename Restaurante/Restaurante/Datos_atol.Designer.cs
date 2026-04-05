namespace Restaurante
{
    partial class Datos_atol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Datos_atol));
            this.R_Dtos_atol = new System.Windows.Forms.Button();
            this.Panes = new System.Windows.Forms.Label();
            this.Atol_ = new System.Windows.Forms.TextBox();
            this.Datos = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // R_Dtos_atol
            // 
            this.R_Dtos_atol.BackColor = System.Drawing.Color.IndianRed;
            this.R_Dtos_atol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_Dtos_atol.ForeColor = System.Drawing.Color.Black;
            this.R_Dtos_atol.Location = new System.Drawing.Point(381, 251);
            this.R_Dtos_atol.Name = "R_Dtos_atol";
            this.R_Dtos_atol.Size = new System.Drawing.Size(105, 39);
            this.R_Dtos_atol.TabIndex = 41;
            this.R_Dtos_atol.Text = "Regresar";
            this.R_Dtos_atol.UseVisualStyleBackColor = false;
            this.R_Dtos_atol.Click += new System.EventHandler(this.R_Dtos_atol_Click);
            // 
            // Panes
            // 
            this.Panes.AutoSize = true;
            this.Panes.BackColor = System.Drawing.Color.Transparent;
            this.Panes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panes.ForeColor = System.Drawing.Color.White;
            this.Panes.Location = new System.Drawing.Point(67, 116);
            this.Panes.Name = "Panes";
            this.Panes.Size = new System.Drawing.Size(183, 17);
            this.Panes.TabIndex = 42;
            this.Panes.Text = "¿Cuántos atoles desea?";
            // 
            // Atol_
            // 
            this.Atol_.Location = new System.Drawing.Point(55, 146);
            this.Atol_.Name = "Atol_";
            this.Atol_.Size = new System.Drawing.Size(410, 20);
            this.Atol_.TabIndex = 0;
            // 
            // Datos
            // 
            this.Datos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datos.Location = new System.Drawing.Point(200, 251);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(105, 39);
            this.Datos.TabIndex = 44;
            this.Datos.Text = "Registrar";
            this.Datos.UseVisualStyleBackColor = false;
            this.Datos.Click += new System.EventHandler(this.Datos_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(45, 19);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(157, 84);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 45;
            this.pictureBox8.TabStop = false;
            // 
            // Datos_atol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::Restaurante.Properties.Resources.fondo_login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(573, 333);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.Atol_);
            this.Controls.Add(this.Panes);
            this.Controls.Add(this.R_Dtos_atol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Datos_atol";
            this.Text = "Datos_atol";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button R_Dtos_atol;
        private System.Windows.Forms.Label Panes;
        private System.Windows.Forms.TextBox Atol_;
        private System.Windows.Forms.Button Datos;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}