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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Datospostres));
            this.Datos = new System.Windows.Forms.Button();
            this.Panes = new System.Windows.Forms.Label();
            this.R_Dtos_pastel = new System.Windows.Forms.Button();
            this.p_chocolate_ = new System.Windows.Forms.TextBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // Datos
            // 
            this.Datos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datos.Location = new System.Drawing.Point(190, 256);
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
            this.Panes.BackColor = System.Drawing.Color.Transparent;
            this.Panes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panes.ForeColor = System.Drawing.Color.White;
            this.Panes.Location = new System.Drawing.Point(42, 118);
            this.Panes.Name = "Panes";
            this.Panes.Size = new System.Drawing.Size(303, 17);
            this.Panes.TabIndex = 46;
            this.Panes.Text = "¿Cuántos pasteles de chocolate desea ?";
            // 
            // R_Dtos_pastel
            // 
            this.R_Dtos_pastel.BackColor = System.Drawing.Color.IndianRed;
            this.R_Dtos_pastel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_Dtos_pastel.ForeColor = System.Drawing.Color.Black;
            this.R_Dtos_pastel.Location = new System.Drawing.Point(413, 256);
            this.R_Dtos_pastel.Name = "R_Dtos_pastel";
            this.R_Dtos_pastel.Size = new System.Drawing.Size(105, 39);
            this.R_Dtos_pastel.TabIndex = 45;
            this.R_Dtos_pastel.Text = "Regresar";
            this.R_Dtos_pastel.UseVisualStyleBackColor = false;
            this.R_Dtos_pastel.Click += new System.EventHandler(this.R_Dtos_pastel_Click);
            // 
            // p_chocolate_
            // 
            this.p_chocolate_.Location = new System.Drawing.Point(45, 147);
            this.p_chocolate_.Name = "p_chocolate_";
            this.p_chocolate_.Size = new System.Drawing.Size(473, 20);
            this.p_chocolate_.TabIndex = 0;
            this.p_chocolate_.TextChanged += new System.EventHandler(this.p_chocolate__TextChanged);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(45, 19);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(157, 84);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 48;
            this.pictureBox8.TabStop = false;
            // 
            // Datospostres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::Restaurante.Properties.Resources.fondo_login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(573, 333);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.p_chocolate_);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.Panes);
            this.Controls.Add(this.R_Dtos_pastel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Datospostres";
            this.Text = "Datospostres";
            this.Load += new System.EventHandler(this.Datospostres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Datos;
        private System.Windows.Forms.Label Panes;
        private System.Windows.Forms.Button R_Dtos_pastel;
        private System.Windows.Forms.TextBox p_chocolate_;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}