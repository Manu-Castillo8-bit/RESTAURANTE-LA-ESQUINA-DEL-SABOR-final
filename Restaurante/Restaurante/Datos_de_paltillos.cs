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
        /*string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Mi pc\Desktop\Etapa de informarse\Usuarios.accdb;";
        OleDbConnection conexion;*/

        public Datos_de_paltillos()
        {
            InitializeComponent();
            //conexion = new OleDbConnection(cadenaConexion);
            Pupusas_.Visible = true;
        }

        private void R_Dtos_platillos_Click(object sender, EventArgs e)
        {

            Platillos platillos = new Platillos(this);
            platillos.Show();
            this.Close();
        }




        //_______________________________________
        private void Datos_Click(object sender, EventArgs e)
        {
            Almacenamiento_temporal.Pupusas = Pupusas_.Text;
            Calcular_aderezos();
            this.Close(); // Solo cierra, NO hace INSERT
            Platillos platillos = new Platillos(this);
            platillos.Show();


        }
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
