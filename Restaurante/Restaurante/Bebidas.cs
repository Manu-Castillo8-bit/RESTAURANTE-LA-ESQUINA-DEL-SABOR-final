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
    public partial class Bebidas : Form
    {
        public Bebidas()
        {
            InitializeComponent();
        }
        private Datos_soda form_dt_soda;
        public Bebidas(Datos_soda formPadre)
        {
            InitializeComponent();
            this.form_dt_soda = formPadre;
        }

        private Datos_chocolate form_dt_chocolate;
        public Bebidas(Datos_chocolate formPadre)
        {
            InitializeComponent();
            this.form_dt_chocolate = formPadre;
        }

        private Datos_cafe form_dt_cafe;
        public Bebidas(Datos_cafe formPadre)
        {
            InitializeComponent();
            this.form_dt_cafe = formPadre;
        }

        private Datos_atol form_dt_atol;
        public Bebidas(Datos_atol formPadre)
        {
            InitializeComponent();
            this.form_dt_atol = formPadre;
        }


        private void ingresar_Click(object sender, EventArgs e)
        {
            // Mostrar cuadro de diálogo de confirmación
            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que deseas regresar al menú?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Verificar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {

                // O si es un formulario específico:
                this.Hide();
                Menú newForm = new Menú();
                newForm.ShowDialog();

            }
            // Si el usuario selecciona No, no hace nada y permanece en la aplicación
        }

        private void label9_Click(object sender, EventArgs e)
        {
            //Ignorar
        }

        private void Ord_soda_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Ord_chocolate_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Ord_cafe_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Ord_atol_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Datos_chocolate newForm = new Datos_chocolate();
            newForm.Show();
        }

        private void btnSoda_Click(object sender, EventArgs e)
        {
            this.Hide();
            Datos_soda newForm = new Datos_soda();
            newForm.Show();
        }

        private void btnCafe_Click(object sender, EventArgs e)
        {
            this.Hide();
            Datos_cafe newForm = new Datos_cafe();
            newForm.Show();
        }

        private void btnAtol_Click(object sender, EventArgs e)
        {
            this.Hide();
            Datos_atol newForm = new Datos_atol();
            newForm.Show();
        }

        private void btnLicuado_Click(object sender, EventArgs e)
        {
            this.Hide();
            Datos_licuado newForm = new Datos_licuado();
            newForm.Show();
        }

        private void btnTe_Click(object sender, EventArgs e)
        {
            this.Hide();
            Datos_te newForm = new Datos_te();
            newForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Mostrar cuadro de diálogo de confirmación
            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que deseas salir?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Verificar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                // Cerrar la aplicación
                Application.Exit();
                // O si es un formulario específico: this.Close();
            }
            // Si el usuario selecciona No, no hace nada y permanece en la aplicación

        }
    }
}
