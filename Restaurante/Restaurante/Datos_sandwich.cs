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
    public partial class Datos_sandwich : Form
    {
        public Datos_sandwich()
        {
            InitializeComponent();
        }

        private void Datos_Click(object sender, EventArgs e)
        {//Guarda los datos ingresados en la variable "Sandwiches" de la clase Almacenamiento_temporal
            Almacenamiento_temporal.Sandwiches = Sandwich_.Text;

            //Ejecuta en método para calcular el costo de los aderezos seleccionados
            Calcular_aderezos();



            this.Close(); 
            Entradas entradas = new Entradas(this);
            entradas.Show();
        }


        //------------------BOTON DE REGRESO A LAS ENTRADAS 🔙-----------------------
        private void R_Dtos_sandwich_Click(object sender, EventArgs e)
        {
            this.Close(); 
            Entradas entradas = new Entradas(this);
            entradas.Show();
        }
        //---------------------------------------------------------------------------




        //Ejecuta el método para calcular el costo de los aderezos seleccionados
        public void Calcular_aderezos()
        {
            double Aderezo_de_sandwiches = 0;

            // Sumar $1.50 por cada CheckBox seleccionado
            if (ketchup.Checked) Aderezo_de_sandwiches += 1.50;
            if (salsa_tomate.Checked) Aderezo_de_sandwiches += 1.50;
            if (pepinesa.Checked) Aderezo_de_sandwiches += 1.50;
            if (mayonesa.Checked) Aderezo_de_sandwiches += 1.50;
            if (salsa_aguacate.Checked) Aderezo_de_sandwiches += 1.50;
            if (salsa_blanca.Checked) Aderezo_de_sandwiches += 1.50;



            Almacenamiento_temporal.Ad_sandwiches = Convert.ToString(Aderezo_de_sandwiches);
        }

    }
}
