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
    public partial class Datos_te : Form
    {
        public Datos_te()
        {
            InitializeComponent();
        }

        private void R_Dtos_te_Click(object sender, EventArgs e)
        {
            this.Close(); // Solo cierra, NO hace INSERT
            Bebidas bebidas = new Bebidas();
            bebidas.Show();
        }

        private void Datos_Click(object sender, EventArgs e)
        {
            Almacenamiento_temporal.Tes = te_.Text;

            this.Close(); // Solo cierra, NO hace INSERT
            Bebidas bebidas = new Bebidas();
            bebidas.Show();
        }
    }
}
