using System;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class Datos_tamales : Form
    {
        public Datos_tamales()
        {
            InitializeComponent();
        }

        private void Datos_Click(object sender, EventArgs e)
        {//Guarda los datos ingresados en la variable "Tamales" de la clase Almacenamiento_temporal
            Almacenamiento_temporal.Tamales = Tamales_.Text;

            this.Close();
            Entradas entradas = new Entradas(this);
            entradas.Show();
        }

        //-------------------------BOTON DE REGRESO A LAS ENTRADAS 🔙-------------------------------
        private void R_Dtos_tamal_Click(object sender, EventArgs e)
        {
            this.Close(); 
            Entradas entradas = new Entradas(this);
            entradas.Show();
        }
        //-----------------------------------------------------------------------------------------
    }
}
