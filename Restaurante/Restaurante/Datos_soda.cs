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
    public partial class Datos_soda : Form
    {
        
        public Datos_soda()
        {
            InitializeComponent();
             
        }

        //----------------BOTON DE REGRESO A LAS BEBIDAS 🔙----------------------
        private void R_Dtos_soda_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bebidas bebidas = new Bebidas(this);
            bebidas.Show();
            this.Close();
        }
        //-----------------------------------------------------------------------


        private void Datos_Click(object sender, EventArgs e)

        {//Guarda los datos ingresados en la variable "Bebidas" de la clase Almacenamiento_temporal
            Almacenamiento_temporal.Bebidas = Soda_.Text;
          
            this.Close(); // Solo cierra, NO hace INSERT
            Bebidas bebidas= new Bebidas(this);
            bebidas.Show();
        }
    }
}
