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
    public partial class Datos_ensalada : Form
    {
        public Datos_ensalada()
        {
            InitializeComponent();
        }

        private void Datos_Click(object sender, EventArgs e)
        {//Guarda los datos ingresados en la variable "Ensaladas" de la clase Almacenamiento_temporal

            Almacenamiento_temporal.Ensaladas = Ensalada_.Text;

            //Se ejecuta el método para calcular el precio de los aderezos seleccionados
            Calcular_aderezos();
            this.Close(); 
            Entradas entradas = new Entradas(this);
            entradas.Show();
        }




        //--------------BOTON DE REGRESO A LAS ENTRADAS 🔙--------------
        private void R_Dtos_ensaladas_Click(object sender, EventArgs e)
        {

            this.Close(); 
            Entradas entradas = new Entradas(this);
            entradas.Show();
        }
        //______________________________________________________________





        // Método para calcular el precio de los aderezos seleccionados
        public void Calcular_aderezos()
        {
            double Aderezo_de_ensaladas = 0;

            // Sumar $1.50 por cada CheckBox seleccionado
            if (ketchup.Checked) Aderezo_de_ensaladas += 1.50;
            if (salsa_tomate.Checked) Aderezo_de_ensaladas += 1.50;
            if (pepinesa.Checked) Aderezo_de_ensaladas += 1.50;
            if (mayonesa.Checked) Aderezo_de_ensaladas += 1.50;
            if (salsa_aguacate.Checked) Aderezo_de_ensaladas += 1.50;
            if (salsa_blanca.Checked) Aderezo_de_ensaladas += 1.50;



            Almacenamiento_temporal.Ad_ensaladas = Convert.ToString(Aderezo_de_ensaladas);
        }

    }
}
