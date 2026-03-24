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
    public partial class Datos_carne : Form
    {
        public Datos_carne()
        {
            InitializeComponent();
        }

        private void Datos_Click(object sender, EventArgs e)
        {
            Almacenamiento_temporal.Carne = Carne_.Text;

            this.Close(); // Solo cierra, NO hace INSERT
            Platillos platillos = new Platillos(this);
            platillos.Show();
        }

        private void R_Dtos_platillos_Click(object sender, EventArgs e)
        {
            this.Close(); // Solo cierra, NO hace INSERT
            Platillos platillos = new Platillos(this);
            platillos.Show();
        }
    }
}
