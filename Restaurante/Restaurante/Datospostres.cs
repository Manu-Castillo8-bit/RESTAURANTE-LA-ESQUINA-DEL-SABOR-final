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
    public partial class Datospostres : Form
    {
         
        public Datospostres()
        {
            InitializeComponent();
             
        }

        //-----------BOTON DE REGRESO A LOS POSTRES 🔙------------------
        private void R_Dtos_pastel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Postres newForm = new Postres();
            newForm.Show();
        }
        //______________________________________________________________

        private void Datos_Click(object sender, EventArgs e)
        {//Guarda los datos ingresados en la variable "pastel" de la clase Almacenamiento_temporal

            Almacenamiento_temporal.pastel = p_chocolate_.Text;
           
            this.Close();
            Postres postres = new Postres(this);
            postres.Show();
        }













        //-----------------EVENTOS CREADOS POR ERROR 💀--------------------------
        private void Datospostres_Load(object sender, EventArgs e)
        {
            //Ignorar
        }

        private void p_chocolate__TextChanged(object sender, EventArgs e)
        {

        }
        //------------------------------------------------------------------------  
    }
}
