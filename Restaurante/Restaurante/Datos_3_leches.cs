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
    public partial class Datos_3_leches : Form
    {

        public Datos_3_leches()
        {
            InitializeComponent();

        }


        //-----------BOTON DE REGRESO A LOS POSTRES 🔙-------------------
        private void R_Dtos_3_leches_Click(object sender, EventArgs e)
        {
            this.Hide();
            Postres postres = new Postres(this);
            postres.Show();
            this.Close();
        }
        //______________________________________________________________



        private void Datos_Click(object sender, EventArgs e)
        {//Guarda los datos ingresados en la variable "TresLeches" de la clase Almacenamiento_temporal
            Almacenamiento_temporal.TresLeches = tres_leches_.Text;
         
            this.Close(); 
            Postres postres = new Postres(this);
            postres.Show();
        }
    }
}
