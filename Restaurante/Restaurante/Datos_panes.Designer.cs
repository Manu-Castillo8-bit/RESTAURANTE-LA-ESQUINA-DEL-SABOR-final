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
            this.salsa_blanca = new System.Windows.Forms.CheckBox();
            this.salsa_aguacate = new System.Windows.Forms.CheckBox();
            this.mayonesa = new System.Windows.Forms.CheckBox();
            this.pepinesa = new System.Windows.Forms.CheckBox();
            this.salsa_tomate = new System.Windows.Forms.CheckBox();
            this.ketchup = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Datos
            // 
            this.Datos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datos.Location = new System.Drawing.Point(213, 438);
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
            this.R_Dtos_panes.Location = new System.Drawing.Point(436, 438);
            this.R_Dtos_panes.Name = "R_Dtos_panes";
            this.R_Dtos_panes.Size = new System.Drawing.Size(105, 39);
            this.R_Dtos_panes.TabIndex = 33;
            this.R_Dtos_panes.Text = "Regresar";
            this.R_Dtos_panes.UseVisualStyleBackColor = false;
            this.R_Dtos_panes.Click += new System.EventHandler(this.R_Dtos_panes_Click);
            // 
            // salsa_blanca
            // 
            this.salsa_blanca.AutoSize = true;
            this.salsa_blanca.Location = new System.Drawing.Point(398, 289);
            this.salsa_blanca.Name = "salsa_blanca";
            this.salsa_blanca.Size = new System.Drawing.Size(105, 17);
            this.salsa_blanca.TabIndex = 43;
            this.salsa_blanca.Text = "SALSA BLANCA";
            this.salsa_blanca.UseVisualStyleBackColor = true;
            // 
            // salsa_aguacate
            // 
            this.salsa_aguacate.AutoSize = true;
            this.salsa_aguacate.Location = new System.Drawing.Point(398, 249);
            this.salsa_aguacate.Name = "salsa_aguacate";
            this.salsa_aguacate.Size = new System.Drawing.Size(139, 17);
            this.salsa_aguacate.TabIndex = 42;
            this.salsa_aguacate.Text = "SALSA DE AGUACATE";
            this.salsa_aguacate.UseVisualStyleBackColor = true;
            // 
            // mayonesa
            // 
            this.mayonesa.AutoSize = true;
            this.mayonesa.Location = new System.Drawing.Point(239, 289);
            this.mayonesa.Name = "mayonesa";
            this.mayonesa.Size = new System.Drawing.Size(86, 17);
            this.mayonesa.TabIndex = 41;
            this.mayonesa.Text = "MAYONESA";
            this.mayonesa.UseVisualStyleBackColor = true;
            // 
            // pepinesa
            // 
            this.pepinesa.AutoSize = true;
            this.pepinesa.Location = new System.Drawing.Point(239, 249);
            this.pepinesa.Name = "pepinesa";
            this.pepinesa.Size = new System.Drawing.Size(79, 17);
            this.pepinesa.TabIndex = 40;
            this.pepinesa.Text = "PEPINESA";
            this.pepinesa.UseVisualStyleBackColor = true;
            // 
            // salsa_tomate
            // 
            this.salsa_tomate.AutoSize = true;
            this.salsa_tomate.Location = new System.Drawing.Point(35, 289);
            this.salsa_tomate.Name = "salsa_tomate";
            this.salsa_tomate.Size = new System.Drawing.Size(126, 17);
            this.salsa_tomate.TabIndex = 39;
            this.salsa_tomate.Text = "SALSA DE TOMATE";
            this.salsa_tomate.UseVisualStyleBackColor = true;
            // 
            // ketchup
            // 
            this.ketchup.AutoSize = true;
            this.ketchup.Location = new System.Drawing.Point(35, 249);
            this.ketchup.Name = "ketchup";
            this.ketchup.Size = new System.Drawing.Size(77, 17);
            this.ketchup.TabIndex = 38;
            this.ketchup.Text = "KETCHUP";
            this.ketchup.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "DESEA AGREGAR ALGÚN ADEREZO";
            // 
            // Datos_panes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(573, 489);
            this.Controls.Add(this.salsa_blanca);
            this.Controls.Add(this.salsa_aguacate);
            this.Controls.Add(this.mayonesa);
            this.Controls.Add(this.pepinesa);
            this.Controls.Add(this.salsa_tomate);
            this.Controls.Add(this.ketchup);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.CheckBox salsa_blanca;
        private System.Windows.Forms.CheckBox salsa_aguacate;
        private System.Windows.Forms.CheckBox mayonesa;
        private System.Windows.Forms.CheckBox pepinesa;
        private System.Windows.Forms.CheckBox salsa_tomate;
        private System.Windows.Forms.CheckBox ketchup;
        private System.Windows.Forms.Label label1;
    }
}