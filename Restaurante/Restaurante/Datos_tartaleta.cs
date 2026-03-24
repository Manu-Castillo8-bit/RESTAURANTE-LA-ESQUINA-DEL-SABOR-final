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
    public partial class Datos_tartaleta : Form
    {
        public Datos_tartaleta()
        {
            InitializeComponent();
        }

        private void R_Dtos_tartaletas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Postres postres = new Postres();
            postres.Show();
            this.Close();
        }

        private void Datos_Click(object sender, EventArgs e)
        {
            Almacenamiento_temporal.Tartaletas = Tartaleta_.Text;

            this.Close(); // Solo cierra, NO hace INSERT
            Postres postre = new Postres();
            postre.Show();
        }
    }
}
