namespace Restaurante
{
    partial class Datos_cafe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Datos_cafe));
            this.Datos = new System.Windows.Forms.Button();
            this.Cafe_ = new System.Windows.Forms.TextBox();
            this.Panes = new System.Windows.Forms.Label();
            this.R_Dtos_cafe = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // Datos
            // 
            this.Datos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datos.Location = new System.Drawing.Point(196, 258);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(105, 39);
            this.Datos.TabIndex = 40;
            this.Datos.Text = "Registrar";
            this.Datos.UseVisualStyleBackColor = false;
            this.Datos.Click += new System.EventHandler(this.Datos_Click);
            // 
            // Cafe_
            // 
            this.Cafe_.Location = new System.Drawing.Point(45, 142);
            this.Cafe_.Name = "Cafe_";
            this.Cafe_.Size = new System.Drawing.Size(410, 20);
            this.Cafe_.TabIndex = 0;
            // 
            // Panes
            // 
            this.Panes.AutoSize = true;
            this.Panes.BackColor = System.Drawing.Color.Transparent;
            this.Panes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panes.ForeColor = System.Drawing.Color.White;
            this.Panes.Location = new System.Drawing.Point(67, 116);
            this.Panes.Name = "Panes";
            this.Panes.Size = new System.Drawing.Size(178, 17);
            this.Panes.TabIndex = 38;
            this.Panes.Text = "¿Cuántos cafés desea?";
            // 
            // R_Dtos_cafe
            // 
            this.R_Dtos_cafe.BackColor = System.Drawing.Color.IndianRed;
            this.R_Dtos_cafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_Dtos_cafe.ForeColor = System.Drawing.Color.Black;
            this.R_Dtos_cafe.Location = new System.Drawing.Point(393, 258);
            this.R_Dtos_cafe.Name = "R_Dtos_cafe";
            this.R_Dtos_cafe.Size = new System.Drawing.Size(105, 39);
            this.R_Dtos_cafe.TabIndex = 37;
            this.R_Dtos_cafe.Text = "Regresar";
            this.R_Dtos_cafe.UseVisualStyleBackColor = false;
            this.R_Dtos_cafe.Click += new System.EventHandler(this.R_Dtos_cafe_Click);
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
            // Datos_cafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::Restaurante.Properties.Resources.fondo_login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(573, 333);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.Cafe_);
            this.Controls.Add(this.Panes);
            this.Controls.Add(this.R_Dtos_cafe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Datos_cafe";
            this.Text = "Datos_cafe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Datos;
        private System.Windows.Forms.TextBox Cafe_;
        private System.Windows.Forms.Label Panes;
        private System.Windows.Forms.Button R_Dtos_cafe;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}