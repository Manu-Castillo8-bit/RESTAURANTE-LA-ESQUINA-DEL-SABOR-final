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
    public partial class Datos_flan : Form
    {
        
        public Datos_flan()
        {
            InitializeComponent();
             
        }

        //---------------BOTON DE REGRESO A LOS POSTRES 🔙-----------------
        private void R_Dtos_flan_Click(object sender, EventArgs e)
        {
            this.Hide();
            Postres postres = new Postres(this);
            postres.Show();
            this.Close();
        }
        //-----------------------------------------------------------------



        private void Datos_Click(object sender, EventArgs e)
        {//Guarda los datos ingresados en la variable "Flanes" de la clase Almacenamiento_temporal

            Almacenamiento_temporal.Flanes = flan_.Text;
        
            this.Close(); // Solo cierra, NO hace INSERT
            Postres postres = new Postres(this);
            postres.Show();
        }
    }
}
