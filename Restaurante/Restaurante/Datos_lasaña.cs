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
    public partial class Datos_lasaña : Form
    {
        public Datos_lasaña()
        {
            InitializeComponent();
        }

        private void Datos_Click(object sender, EventArgs e)
        {
            Almacenamiento_temporal.Lasaña = Lasaña_.Text;

            this.Close(); // Solo cierra, NO hace INSERT
            Platillos platillos = new Platillos(this);
            platillos.Show();

        }
    }
}
