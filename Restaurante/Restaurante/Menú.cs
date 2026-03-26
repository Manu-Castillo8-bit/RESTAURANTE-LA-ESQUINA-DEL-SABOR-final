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
    public partial class Menú : Form
    {
        public Menú()
        {
            InitializeComponent();
        }

        private void r_m_l_Click(object sender, EventArgs e)
        {
            this.Hide();

           
            Login newForm = new Login();
            newForm.ShowDialog();
        }

        private void Platillos_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Crear el formulario de datos que requiere el constructor de Platillos
            Datos_de_paltillos datosForm = new Datos_de_paltillos();
            Platillos newForm = new Platillos(datosForm);
            newForm.ShowDialog();
        }

        private void Bebidas_Click(object sender, EventArgs e)
        {
            this.Hide();

            // 2. Crear y mostrar el nuevo formulario (Form2)
            Bebidas newForm = new Bebidas();
            newForm.ShowDialog();
        }

        private void Postres_Click(object sender, EventArgs e)
        {
            this.Hide();

            // 2. Crear y mostrar el nuevo formulario (Form2)
            Postres newForm = new Postres();
            newForm.ShowDialog();
        }

        private void Factura_Click(object sender, EventArgs e)
        {
            this.Hide();

            // 2. Crear y mostrar el nuevo formulario (Form2)
            Factura newForm = new Factura();
            newForm.ShowDialog();
        }

        private void Entradas_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Crear el formulario de datos que requiere el constructor de Platillos
            Entradas newForm = new Entradas();
            newForm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Resumen newForm = new Resumen();
            newForm.ShowDialog();
        }
    }
}
