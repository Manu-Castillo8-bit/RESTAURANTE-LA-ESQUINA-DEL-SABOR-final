namespace Restaurante
{
    partial class Datos_sandwich
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
            this.Sandwich_ = new System.Windows.Forms.TextBox();
            this.Panes = new System.Windows.Forms.Label();
            this.R_Dtos_sandwich = new System.Windows.Forms.Button();
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
            this.Datos.Location = new System.Drawing.Point(201, 399);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(105, 39);
            this.Datos.TabIndex = 48;
            this.Datos.Text = "Registrar";
            this.Datos.UseVisualStyleBackColor = false;
            this.Datos.Click += new System.EventHandler(this.Datos_Click);
            // 
            // Sandwich_
            // 
            this.Sandwich_.Location = new System.Drawing.Point(15, 54);
            this.Sandwich_.Name = "Sandwich_";
            this.Sandwich_.Size = new System.Drawing.Size(410, 20);
            this.Sandwich_.TabIndex = 45;
            // 
            // Panes
            // 
            this.Panes.AutoSize = true;
            this.Panes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panes.Location = new System.Drawing.Point(12, 24);
            this.Panes.Name = "Panes";
            this.Panes.Size = new System.Drawing.Size(175, 13);
            this.Panes.TabIndex = 47;
            this.Panes.Text = "¿Cuántos sandwiches desea?";
            // 
            // R_Dtos_sandwich
            // 
            this.R_Dtos_sandwich.BackColor = System.Drawing.Color.IndianRed;
            this.R_Dtos_sandwich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_Dtos_sandwich.ForeColor = System.Drawing.Color.Black;
            this.R_Dtos_sandwich.Location = new System.Drawing.Point(424, 399);
            this.R_Dtos_sandwich.Name = "R_Dtos_sandwich";
            this.R_Dtos_sandwich.Size = new System.Drawing.Size(105, 39);
            this.R_Dtos_sandwich.TabIndex = 46;
            this.R_Dtos_sandwich.Text = "Regresar";
            this.R_Dtos_sandwich.UseVisualStyleBackColor = false;
            this.R_Dtos_sandwich.Click += new System.EventHandler(this.R_Dtos_sandwich_Click);
            // 
            // salsa_blanca
            // 
            this.salsa_blanca.AutoSize = true;
            this.salsa_blanca.Location = new System.Drawing.Point(394, 265);
            this.salsa_blanca.Name = "salsa_blanca";
            this.salsa_blanca.Size = new System.Drawing.Size(105, 17);
            this.salsa_blanca.TabIndex = 55;
            this.salsa_blanca.Text = "SALSA BLANCA";
            this.salsa_blanca.UseVisualStyleBackColor = true;
            // 
            // salsa_aguacate
            // 
            this.salsa_aguacate.AutoSize = true;
            this.salsa_aguacate.Location = new System.Drawing.Point(394, 225);
            this.salsa_aguacate.Name = "salsa_aguacate";
            this.salsa_aguacate.Size = new System.Drawing.Size(139, 17);
            this.salsa_aguacate.TabIndex = 54;
            this.salsa_aguacate.Text = "SALSA DE AGUACATE";
            this.salsa_aguacate.UseVisualStyleBackColor = true;
            // 
            // mayonesa
            // 
            this.mayonesa.AutoSize = true;
            this.mayonesa.Location = new System.Drawing.Point(235, 265);
            this.mayonesa.Name = "mayonesa";
            this.mayonesa.Size = new System.Drawing.Size(86, 17);
            this.mayonesa.TabIndex = 53;
            this.mayonesa.Text = "MAYONESA";
            this.mayonesa.UseVisualStyleBackColor = true;
            // 
            // pepinesa
            // 
            this.pepinesa.AutoSize = true;
            this.pepinesa.Location = new System.Drawing.Point(235, 225);
            this.pepinesa.Name = "pepinesa";
            this.pepinesa.Size = new System.Drawing.Size(79, 17);
            this.pepinesa.TabIndex = 52;
            this.pepinesa.Text = "PEPINESA";
            this.pepinesa.UseVisualStyleBackColor = true;
            // 
            // salsa_tomate
            // 
            this.salsa_tomate.AutoSize = true;
            this.salsa_tomate.Location = new System.Drawing.Point(31, 265);
            this.salsa_tomate.Name = "salsa_tomate";
            this.salsa_tomate.Size = new System.Drawing.Size(126, 17);
            this.salsa_tomate.TabIndex = 51;
            this.salsa_tomate.Text = "SALSA DE TOMATE";
            this.salsa_tomate.UseVisualStyleBackColor = true;
            // 
            // ketchup
            // 
            this.ketchup.AutoSize = true;
            this.ketchup.Location = new System.Drawing.Point(31, 225);
            this.ketchup.Name = "ketchup";
            this.ketchup.Size = new System.Drawing.Size(77, 17);
            this.ketchup.TabIndex = 50;
            this.ketchup.Text = "KETCHUP";
            this.ketchup.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "DESEA AGREGAR ALGÚN ADEREZO";
            // 
            // Datos_sandwich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.Controls.Add(this.salsa_blanca);
            this.Controls.Add(this.salsa_aguacate);
            this.Controls.Add(this.mayonesa);
            this.Controls.Add(this.pepinesa);
            this.Controls.Add(this.salsa_tomate);
            this.Controls.Add(this.ketchup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.Sandwich_);
            this.Controls.Add(this.Panes);
            this.Controls.Add(this.R_Dtos_sandwich);
            this.Name = "Datos_sandwich";
            this.Text = "Datos_sandwich";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Datos;
        private System.Windows.Forms.TextBox Sandwich_;
        private System.Windows.Forms.Label Panes;
        private System.Windows.Forms.Button R_Dtos_sandwich;
        private System.Windows.Forms.CheckBox salsa_blanca;
        private System.Windows.Forms.CheckBox salsa_aguacate;
        private System.Windows.Forms.CheckBox mayonesa;
        private System.Windows.Forms.CheckBox pepinesa;
        private System.Windows.Forms.CheckBox salsa_tomate;
        private System.Windows.Forms.CheckBox ketchup;
        private System.Windows.Forms.Label label1;
    }
}