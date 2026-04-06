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
    public partial class Datos_tortas : Form
    {
         
        public Datos_tortas()
        {
            InitializeComponent();
           
        }

        //----------------EVENTOS CREADOS POR ERROR EN EL DISEÑADOR 💀---------------------
        private void Datos_tortas_Load(object sender, EventArgs e)
        {
            //Ignorar
        }
        //__________________________________________________________________________________


        //--------------------BOTON DE REGRESO A LOS PLATILLOS 🔙---------------------------
        private void R_Dtos_tortas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Platillos platillos = new Platillos(this);
            platillos.Show();
            this.Close();
        }
        //----------------------------------------------------------------------------------

       
        private void Datos_Click(object sender, EventArgs e)
        {//Guarda los datos ingresados en la variable "Tortas" de la clase Almacenamiento_temporal

            Almacenamiento_temporal.Tortas = Tortas_.Text;

            //Se ejecuta el método para calcular el costo de los aderezos seleccionados
          Calcular_aderezos();
            this.Close(); 
            Platillos platillos = new Platillos(this);
            platillos.Show();
        }



        //Este el método que calcula el costo de los aderezos seleccionados 
        public void Calcular_aderezos()
        {
            double Aderezo_de_tortas = 0;

            // Sumar $1.50 por cada CheckBox seleccionado
            if (ketchup.Checked) Aderezo_de_tortas += 1.50;
            if (salsa_tomate.Checked) Aderezo_de_tortas += 1.50;
            if (pepinesa.Checked) Aderezo_de_tortas += 1.50;
            if (mayonesa.Checked) Aderezo_de_tortas += 1.50;
            if (salsa_aguacate.Checked) Aderezo_de_tortas += 1.50;
            if (salsa_blanca.Checked) Aderezo_de_tortas += 1.50;



            Almacenamiento_temporal.Ad_tortas = Convert.ToString(Aderezo_de_tortas);
        }

    }
}
