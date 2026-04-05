namespace Restaurante
{
    partial class Datos_tamales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Datos_tamales));
            this.Datos = new System.Windows.Forms.Button();
            this.Tamales_ = new System.Windows.Forms.TextBox();
            this.Panes = new System.Windows.Forms.Label();
            this.R_Dtos_tamal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // Datos
            // 
            this.Datos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datos.Location = new System.Drawing.Point(188, 260);
            this.Datos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(113, 38);
            this.Datos.TabIndex = 48;
            this.Datos.Text = "Registrar";
            this.Datos.UseVisualStyleBackColor = false;
            this.Datos.Click += new System.EventHandler(this.Datos_Click);
            // 
            // Tamales_
            // 
            this.Tamales_.Location = new System.Drawing.Point(60, 173);
            this.Tamales_.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tamales_.Name = "Tamales_";
            this.Tamales_.Size = new System.Drawing.Size(414, 22);
            this.Tamales_.TabIndex = 45;
            // 
            // Panes
            // 
            this.Panes.AutoSize = true;
            this.Panes.BackColor = System.Drawing.Color.Transparent;
            this.Panes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panes.ForeColor = System.Drawing.Color.White;
            this.Panes.Location = new System.Drawing.Point(74, 126);
            this.Panes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Panes.Name = "Panes";
            this.Panes.Size = new System.Drawing.Size(265, 16);
            this.Panes.TabIndex = 47;
            this.Panes.Text = "¿Cuántos dólares de tamales desea?";
            // 
            // R_Dtos_tamal
            // 
            this.R_Dtos_tamal.BackColor = System.Drawing.Color.IndianRed;
            this.R_Dtos_tamal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_Dtos_tamal.ForeColor = System.Drawing.Color.Black;
            this.R_Dtos_tamal.Location = new System.Drawing.Point(392, 260);
            this.R_Dtos_tamal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.R_Dtos_tamal.Name = "R_Dtos_tamal";
            this.R_Dtos_tamal.Size = new System.Drawing.Size(113, 38);
            this.R_Dtos_tamal.TabIndex = 46;
            this.R_Dtos_tamal.Text = "Regresar";
            this.R_Dtos_tamal.UseVisualStyleBackColor = false;
            this.R_Dtos_tamal.Click += new System.EventHandler(this.R_Dtos_tamal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Son 3 x $1.00";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(60, 23);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(170, 85);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 50;
            this.pictureBox8.TabStop = false;
            // 
            // Datos_tamales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Restaurante.Properties.Resources.fondo_login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(573, 333);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.Tamales_);
            this.Controls.Add(this.Panes);
            this.Controls.Add(this.R_Dtos_tamal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Datos_tamales";
            this.Text = "Datos_tamales";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Datos;
        private System.Windows.Forms.TextBox Tamales_;
        private System.Windows.Forms.Label Panes;
        private System.Windows.Forms.Button R_Dtos_tamal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}