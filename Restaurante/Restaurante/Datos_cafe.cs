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
    public partial class Datos_cafe : Form
    {
       
        public Datos_cafe()
        {
            InitializeComponent();
             
        }


        //-------------BOTON DE REGRESO A LAS BEBIDAS 🔙-------------------
        private void R_Dtos_cafe_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bebidas bebidas = new Bebidas(this);
            bebidas.Show();
            this.Close();
        }
        //_________________________________________________________________


        private void Datos_Click(object sender, EventArgs e)
        {//Guarda los datos ingresados en la variable "Cafes" de la clase Almacenamiento_temporal
            Almacenamiento_temporal.Cafes = Cafe_.Text;
         
            this.Close();
            Bebidas bebidas = new Bebidas(this);
            bebidas.Show();
        }
    }
}
