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
    public partial class Datos_licuado : Form
    {
        public Datos_licuado()
        {
            InitializeComponent();
        }

        private void Datos_Click(object sender, EventArgs e)
        {
            Almacenamiento_temporal.Licuados = Licuados_.Text;

            this.Close(); // Solo cierra, NO hace INSERT
            Bebidas bebidas = new Bebidas();
            bebidas.Show();
        }

        private void R_Dtos_licuado_Click(object sender, EventArgs e)
        {
            this.Close(); // Solo cierra, NO hace INSERT
            Bebidas bebidas = new Bebidas();
            bebidas.Show();

        }
    }
}
