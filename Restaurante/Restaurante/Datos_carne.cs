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
    public partial class Datos_carne : Form
    {
        public Datos_carne()
        {
            InitializeComponent();
        }

        private void Datos_Click(object sender, EventArgs e)
        {//Guarda los datos ingresados en la variable "Carne" de la clase Almacenamiento_temporal
            Almacenamiento_temporal.Carne = Carne_.Text;

            this.Close();
            Platillos platillos = new Platillos(this);
            platillos.Show();
        }


        //---------------BOTON DE REGRESO A LOS PLATILLOS🔙------------------
        private void R_Dtos_platillos_Click(object sender, EventArgs e)
        {
            this.Close();
            Platillos platillos = new Platillos(this);
            platillos.Show();
        }
        //___________________________________________________________________
    }
}
