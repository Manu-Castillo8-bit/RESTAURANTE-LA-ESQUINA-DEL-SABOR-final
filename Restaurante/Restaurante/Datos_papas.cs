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
    public partial class Datos_papas : Form
    {
        public Datos_papas()
        {
            InitializeComponent();
        }

        private void Datos_Click(object sender, EventArgs e)
        {
            Almacenamiento_temporal.Papas = Papas_.Text;

            this.Close(); // Solo cierra, NO hace INSERT
            Entradas entradas = new Entradas(this);
            entradas.Show();
        }

        private void R_Dtos_papas_Click(object sender, EventArgs e)
        {
            this.Close(); // Solo cierra, NO hace INSERT
            Entradas entradas = new Entradas(this);
            entradas.Show();
        }
    }
    
}
