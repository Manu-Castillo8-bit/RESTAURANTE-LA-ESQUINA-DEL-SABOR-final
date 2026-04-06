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
        {//Guarda los datos ingresados en la variable "Sopas" de la clase Almacenamiento_temporal

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
