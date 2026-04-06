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
    public partial class Datos_atol : Form
    {
         
        public Datos_atol()
        {
            InitializeComponent();
             
        }


        //--------------BOTON DE REGRESO A LAS BEBIDAS 🔙--------------------
        private void R_Dtos_atol_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bebidas bebidas = new Bebidas(this);
            bebidas.Show();
            this.Close();
        }
        //____________________________________________________________________



        private void Datos_Click(object sender, EventArgs e)
        {//Guarda los datos ingresados en la variable "Atoles" de la clase Almacenamiento_temporal
            Almacenamiento_temporal.Atoles = Atol_.Text;
          
            this.Close(); // Solo cierra, NO hace INSERT
            Bebidas bebidas = new Bebidas(this);
            bebidas.Show();
        }
    }
}
