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
    public partial class Datos_paslimon : Form
    {
        public Datos_paslimon()
        {
            InitializeComponent();
        }

        private void Datos_Click(object sender, EventArgs e)
        {
            Almacenamiento_temporal.Pastel_de_limon = Paslimon_.Text;

            this.Close(); // Solo cierra, NO hace INSERT
            Postres postre = new Postres();
            postre.Show();
        }
    }
}
