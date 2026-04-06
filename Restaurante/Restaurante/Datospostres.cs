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
    public partial class Datospostres : Form
    {
         
        public Datospostres()
        {
            InitializeComponent();
             
        }

        //-----------BOTON DE REGRESO A LOS POSTRES 🔙------------------
        private void R_Dtos_pastel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Postres newForm = new Postres();
            newForm.Show();
        }
        //______________________________________________________________

        private void Datos_Click(object sender, EventArgs e)
        {
            // Validar que el campo no esté vacío
            if (string.IsNullOrWhiteSpace(p_chocolate_.Text))
            {
                MessageBox.Show("Por favor, ingrese una cantidad.", "Campo vacío",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sale del método sin continuar
            }

            // Validar que sea un número
            if (!int.TryParse(p_chocolate_.Text, out int cantidad))
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


            //Guarda los datos ingresados en la variable "pastel" de la clase Almacenamiento_temporal

            Almacenamiento_temporal.pastel = p_chocolate_.Text;
           
            this.Close();
            Postres postres = new Postres(this);
            postres.Show();
        }













        //-----------------EVENTOS CREADOS POR ERROR 💀--------------------------
        private void Datospostres_Load(object sender, EventArgs e)
        {
            //Ignorar
        }

        private void p_chocolate__TextChanged(object sender, EventArgs e)
        {

        }
        //------------------------------------------------------------------------  
    }
}
