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
    public partial class Datos_cena : Form
    {
         
        public Datos_cena()
        {
            InitializeComponent();
            
        }



        //--------------EVENTOS CREADOS POR ACCIDENTE 💀----------------
        private void Datos_cena_Load(object sender, EventArgs e)
        {
            //Ignorar
        }
        //______________________________________________________________






        //---------------BOTON DE REGRESO A LOS PLATILLOS 🔙-----------------
        private void R_Dtos_cenas_Click(object sender, EventArgs e)
        { 
            this.Hide();
            Platillos platillos = new Platillos(this);
            platillos.Show();
            this.Close();
        }
        //____________________________________________________________________





        private void Datos_Click(object sender, EventArgs e)
        {
            //Guarda los datos ingresados en la variable "Cena" de la clase Almacenamiento_temporal
            Almacenamiento_temporal.Cena = Cenas_.Text;

            //Ejecuta el metodo para calcular el costo de los aderezos seleccionados
           Calcular_aderezos();

            this.Close(); 
            Platillos platillos = new Platillos(this);
            platillos.Show();
        }



        //ESTE METODO CALCULA EL COSTO DE LOS ADEREZOS QUE SE SELECCIONAN
        public void Calcular_aderezos()
        {
            double Aderezo_de_cenas = 0;

            // Sumar $1.50 por cada CheckBox seleccionado
            if (ketchup.Checked) Aderezo_de_cenas += 1.50;
            if (salsa_tomate.Checked) Aderezo_de_cenas += 1.50;
            if (pepinesa.Checked) Aderezo_de_cenas += 1.50;
            if (mayonesa.Checked) Aderezo_de_cenas += 1.50;
            if (salsa_aguacate.Checked) Aderezo_de_cenas += 1.50;
            if (salsa_blanca.Checked) Aderezo_de_cenas += 1.50;



            Almacenamiento_temporal.Ad_cenas = Convert.ToString(Aderezo_de_cenas);
        }

    }
}
