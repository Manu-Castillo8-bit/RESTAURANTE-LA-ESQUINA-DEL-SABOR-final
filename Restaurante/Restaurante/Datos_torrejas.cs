using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class Datos_torrejas : Form
    {
        public Datos_torrejas()
        {
            InitializeComponent();
        }

        private void Datos_Click(object sender, EventArgs e)
        {
            // Validar que el campo no esté vacío
            if (string.IsNullOrWhiteSpace(Torrejas_.Text))
            {
                MessageBox.Show("Por favor, ingrese una cantidad.", "Campo vacío",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sale del método sin continuar
            }

            // Validar que sea un número
            if (!int.TryParse(Torrejas_.Text, out int cantidad))
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



        //Guarda los datos ingresados en la variable "Torrejas" de la clase Almacenamiento_temporal

            Almacenamiento_temporal.Torrejas= Torrejas_.Text;

            this.Close(); 
            Entradas entradas = new Entradas(this);
            entradas.Show();
        }


        //---------------------BOTON DE REGRESO A LOS POSTRES 🔙---------------------------
        private void R_Dtos_torrejas_Click(object sender, EventArgs e)
        {
            this.Close(); 
            Entradas entradas = new Entradas(this);
            entradas.Show();
        }
        //________________________________________________________________________________
    }
}
