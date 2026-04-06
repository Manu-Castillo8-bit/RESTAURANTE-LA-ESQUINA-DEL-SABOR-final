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

        //Guarda los datos ingresados en la variable "Torrejas" de la clase Almacenamiento_temporal
        private void Datos_Click(object sender, EventArgs e)
        {
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
