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
    public partial class Datos_paslimon : Form
    {
        public Datos_paslimon()
        {
            InitializeComponent();
        }

        private void Datos_Click(object sender, EventArgs e)
        {
            //Guarda los datos ingresados en la variable "Pastel_de_limon" de la clase Almacenamiento_temporal


            Almacenamiento_temporal.Pastel_de_limon = Paslimon_.Text;

            this.Close(); 
            Postres postre = new Postres();
            postre.Show();
        }


        //-----------------BOTON DE REGRESO A LOS POSTRES 🔙----------------------
        private void R_Dtos_tartaletas_Click(object sender, EventArgs e)
        {
             
       
            this.Close();
            Postres postre = new Postres();
            postre.Show();
        
       
         }
        //------------------------------------------------------------------------
    }
}
