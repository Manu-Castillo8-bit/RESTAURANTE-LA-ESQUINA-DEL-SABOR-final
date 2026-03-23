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

        private void Datos_tortas_Load(object sender, EventArgs e)
        {
            //Ignorar
        }

        private void R_Dtos_tortas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Platillos platillos = new Platillos(this);
            platillos.Show();
            this.Close();
        }

        private void Datos_Click(object sender, EventArgs e)
        {
            Almacenamiento_temporal.Tortas = Tortas_.Text;
          
            this.Close(); // Solo cierra, NO hace INSERT
            Platillos platillos = new Platillos(this);
            platillos.Show();
        }
    }
}
