using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class Datos_chocolate : Form
    {
         
        public Datos_chocolate()
        {
            InitializeComponent();
            
        }



        //----------------BOTON DE REGRESO A LAS BEBIDAS 🔙--------------------
        private void R_Dtos_chocolate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bebidas bebidas = new Bebidas(this);
            bebidas.Show();
            this.Close();
        }
        //______________________________________________________________________






        private void Datos_Click(object sender, EventArgs e)
        {
            // Validar que el campo no esté vacío
            if (string.IsNullOrWhiteSpace(Chocolate_.Text))
            {
                MessageBox.Show("Por favor, ingrese una cantidad.", "Campo vacío",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sale del método sin continuar
            }

            // Validar que sea un número
            if (!int.TryParse(Chocolate_.Text, out int cantidad))
            {
                MessageBox.Show("Por favor, ingrese un número válido (ejemplo: 1, 2, 3...).",
                                "Tipo de dato incorrecto",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Sale del método sin continuar
            }

            // Validar que sea un número positivo
            if (cantidad <= 0)
            {
                MessageBox.Show("Por favor, ingrese una cantidad mayor a 0.",
                                "Cantidad inválida",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Guarda los datos ingresados en la variable "Chocolates" de la clase Almacenamiento_temporal
            Almacenamiento_temporal.Chocolates = Chocolate_.Text;
       
            this.Close(); 
            Bebidas bebidas = new Bebidas(this);
            bebidas.Show();
        }
    }
}
