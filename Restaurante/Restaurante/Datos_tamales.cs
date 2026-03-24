using System;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class Datos_tamales : Form
    {
        public Datos_tamales()
        {
            InitializeComponent();
        }

        private void Datos_Click(object sender, EventArgs e)
        {
            Almacenamiento_temporal.Tamales = Tamales_.Text;

            this.Close(); // Solo cierra, NO hace INSERT
            Entradas entradas = new Entradas(this);
            entradas.Show();
        }

        private void R_Dtos_tamal_Click(object sender, EventArgs e)
        {
            this.Close(); // Solo cierra, NO hace INSERT
            Entradas entradas = new Entradas(this);
            entradas.Show();
        }
    }
}
