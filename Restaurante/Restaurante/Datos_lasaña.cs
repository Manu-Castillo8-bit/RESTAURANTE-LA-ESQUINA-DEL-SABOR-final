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
    public partial class Datos_lasaña : Form
    {
        public Datos_lasaña()
        {
            InitializeComponent();
        }

        private void Datos_Click(object sender, EventArgs e)
        {//Guarda los datos ingresados en la variable "Lasaña" de la clase Almacenamiento_temporal

            Almacenamiento_temporal.Lasaña = Lasaña_.Text;

            this.Close(); 
            Platillos platillos = new Platillos(this);
            platillos.Show();

        }


        //---------------BOTON DE REGRESO A LOS PLATILLOS 🔙---------------------
        private void R_Dtos_platillos_Click(object sender, EventArgs e)
        {
            this.Close(); 
            Platillos platillos = new Platillos(this);
            platillos.Show();
        }
        //-----------------------------------------------------------------------
    }
}
