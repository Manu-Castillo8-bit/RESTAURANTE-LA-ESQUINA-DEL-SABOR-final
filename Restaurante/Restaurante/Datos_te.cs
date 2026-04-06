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
    public partial class Datos_te : Form
    {
        public Datos_te()
        {
            InitializeComponent();
        }

        //------------BOTON DE REGRESO A LAS BEBIDAS 🔙---------------------
        private void R_Dtos_te_Click(object sender, EventArgs e)
        {
            this.Close(); 
            Bebidas bebidas = new Bebidas();
            bebidas.Show();
        }
        //------------------------------------------------------------------


        private void Datos_Click(object sender, EventArgs e)
        {//Guarda los datos ingresados en la variable "Tes" de la clase Almacenamiento_temporal

            Almacenamiento_temporal.Tes = te_.Text;

            this.Close(); 
            Bebidas bebidas = new Bebidas();
            bebidas.Show();
        }
    }
}
