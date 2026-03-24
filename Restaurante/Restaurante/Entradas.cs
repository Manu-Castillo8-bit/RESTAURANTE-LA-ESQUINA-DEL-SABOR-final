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
    public partial class Entradas : Form
    {
        public Entradas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
          this.Close();
        }

        private void R_e_m_Click(object sender, EventArgs e)
        {
            this.Hide();

            // 2. Crear y mostrar el nuevo formulario (Form2)
            Menú newForm = new Menú();
            newForm.ShowDialog();
        }
    }
}
