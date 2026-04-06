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
    public partial class Datos_sopa : Form
    {
        public Datos_sopa()
        {
            InitializeComponent();
        }


        private void Datos_Click(object sender, EventArgs e)
        {
            // Validar que el campo no esté vacío
            if (string.IsNullOrWhiteSpace(Sopa_.Text))
            {
                MessageBox.Show("Por favor, ingrese una cantidad.", "Campo vacío",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sale del método sin continuar
            }

            // Validar que sea un número
            if (!int.TryParse(Sopa_.Text, out int cantidad))
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
            
            

            //Guarda los datos ingresados en la variable "Sopas" de la clase Almacenamiento_temporal

            Almacenamiento_temporal.Sopas = Sopa_.Text;

            this.Close(); 
            Entradas entradas = new Entradas(this);
            entradas.Show();
        }


        //-------------------BOTON DE REGRESO A LOS PLATILLOS 🔙--------------------------------
        private void R_Dtos_sopa_Click(object sender, EventArgs e)
        {
            this.Close(); 
            Entradas entradas = new Entradas(this);
            entradas.Show();
        }
        //-------------------------------------------------------------------------------------
    }
}
