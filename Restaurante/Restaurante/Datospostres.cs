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

        private void R_Dtos_pastel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Postres newForm = new Postres();
            newForm.Show();
        }

        private void Datos_Click(object sender, EventArgs e)
        {
            Almacenamiento_temporal.pastel = p_chocolate_.Text;
           
            this.Close(); // Solo cierra, NO hace INSERT
            Postres postres = new Postres(this);
            postres.Show();
        }

        private void Datospostres_Load(object sender, EventArgs e)
        {
            //Ignorar
        }

        private void p_chocolate__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
