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
    public partial class Datos_flan : Form
    {
        
        public Datos_flan()
        {
            InitializeComponent();
             
        }

        //---------------BOTON DE REGRESO A LOS POSTRES 🔙-----------------
        private void R_Dtos_flan_Click(object sender, EventArgs e)
        {
            this.Hide();
            Postres postres = new Postres(this);
            postres.Show();
            this.Close();
        }
        //-----------------------------------------------------------------



        private void Datos_Click(object sender, EventArgs e)
        {

            // Validar que el campo no esté vacío
            if (string.IsNullOrWhiteSpace(flan_.Text))
            {
                MessageBox.Show("Por favor, ingrese una cantidad.", "Campo vacío",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sale del método sin continuar
            }

            // Validar que sea un número
            if (!int.TryParse(flan_.Text, out int cantidad))
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

            //Guarda los datos ingresados en la variable "Flanes" de la clase Almacenamiento_temporal

            Almacenamiento_temporal.Flanes = flan_.Text;
        
            this.Close(); // Solo cierra, NO hace INSERT
            Postres postres = new Postres(this);
            postres.Show();
        }
    }
}
