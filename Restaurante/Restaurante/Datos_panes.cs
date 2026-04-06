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
    public partial class Datos_panes : Form
    { 
        public Datos_panes()
        {
            InitializeComponent();
             
        }

        //------------BOTON DE REGRESO A LOS PLATILLOS 🔙------------------
        private void R_Dtos_panes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Platillos platillos = new Platillos(this);
            platillos.Show();
            this.Close();
        }
        //-----------------------------------------------------------------


        private void Datos_Click(object sender, EventArgs e)
        {//Guarda los datos ingresados en la variable "Panes" de la clase Almacenamiento_temporal

            Almacenamiento_temporal.Panes = Panes_.Text;

            //Ejecuta el método para calcular el costo de los aderezos seleccionados
          Calcular_aderezos();
            this.Close(); 
             Platillos platillos = new Platillos(this);
            platillos.Show();
        }



        // Método para calcular el costo de los aderezos seleccionados
        public void Calcular_aderezos()
        {
            double Aderezo_de_panes = 0;

            // Sumar $1.50 por cada CheckBox seleccionado
            if (ketchup.Checked) Aderezo_de_panes += 1.50;
            if (salsa_tomate.Checked) Aderezo_de_panes += 1.50;
            if (pepinesa.Checked) Aderezo_de_panes += 1.50;
            if (mayonesa.Checked) Aderezo_de_panes += 1.50;
            if (salsa_aguacate.Checked) Aderezo_de_panes += 1.50;
            if (salsa_blanca.Checked) Aderezo_de_panes += 1.50;



            Almacenamiento_temporal.Ad_panes = Convert.ToString(Aderezo_de_panes);
        }




        //---------------EVENTOS CREADOS POR ACCIDENTE EN EL DISEÑADOR 💀-----------------------
        private void Panes__TextChanged(object sender, EventArgs e)
        {

        }
        //-----------------------------------------------------------------------------------------
    }
}
