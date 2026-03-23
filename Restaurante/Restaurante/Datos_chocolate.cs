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
    public partial class Datos_chocolate : Form
    {
         
        public Datos_chocolate()
        {
            InitializeComponent();
            
        }

        private void R_Dtos_chocolate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bebidas bebidas = new Bebidas(this);
            bebidas.Show();
            this.Close();
        }

        private void Datos_Click(object sender, EventArgs e)
        {
            Almacenamiento_temporal.Chocolates = Chocolate_.Text;
       
            this.Close(); // Solo cierra, NO hace INSERT
            Bebidas bebidas = new Bebidas(this);
            bebidas.Show();
        }
    }
}
