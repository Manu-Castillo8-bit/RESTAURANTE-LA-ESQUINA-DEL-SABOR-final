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
    public partial class Datos_de_paltillos : Form
    {
       

        public Datos_de_paltillos()
        {
            InitializeComponent();
            Pupusas_.Visible = true;
        }



        //--------------BOTON DE REGRESO A Los platillos 🔙--------------
        private void R_Dtos_platillos_Click(object sender, EventArgs e)
        {

            Platillos platillos = new Platillos(this);
            platillos.Show();
            this.Close();
        }

        //______________________________________________________________





        private void Datos_Click(object sender, EventArgs e)
        {//Guarda los datos ingresados en la variable "Pupusas" de la clase Almacenamiento_temporal

            Almacenamiento_temporal.Pupusas = Pupusas_.Text;

            //Ejecuta el método que calcula el costo de los aderezos seleccionados
            Calcular_aderezos();
            this.Close(); 
            Platillos platillos = new Platillos(this);
            platillos.Show();


        }



        //Método para calcular el costo de los aderezos seleccionados
        public void Calcular_aderezos()
        {
            double Aderezo_de_pupusas = 0;

            // Sumar $1.50 por cada CheckBox seleccionado
            if (ketchup.Checked) Aderezo_de_pupusas += 1.50;
            if (salsa_tomate.Checked) Aderezo_de_pupusas += 1.50;
            if (pepinesa.Checked) Aderezo_de_pupusas += 1.50;
            if (mayonesa.Checked) Aderezo_de_pupusas += 1.50;
            if (salsa_aguacate.Checked) Aderezo_de_pupusas += 1.50;
            if (salsa_blanca.Checked) Aderezo_de_pupusas += 1.50;



            Almacenamiento_temporal.Ad_pupusas= Convert.ToString (Aderezo_de_pupusas);
        }

    }


}
