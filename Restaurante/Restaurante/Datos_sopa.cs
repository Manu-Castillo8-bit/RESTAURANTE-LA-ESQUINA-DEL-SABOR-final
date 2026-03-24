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
    public partial class Datos_sopa : Form
    {
        public Datos_sopa()
        {
            InitializeComponent();
        }

        private void Datos_Click(object sender, EventArgs e)
        {
            Almacenamiento_temporal.Sopas = Sopa_.Text;

            this.Close(); // Solo cierra, NO hace INSERT
            Entradas entradas = new Entradas(this);
            entradas.Show();
        }
    }
}
