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


        private Datos_sopa form_dt_sopa;
        public Entradas(Datos_sopa formPadre)
        {
            InitializeComponent();
            this.form_dt_sopa = formPadre;
        }

        private Datos_tamales form_dt_tamales;
        public Entradas(Datos_tamales formPadre)
        {
            InitializeComponent();
            this.form_dt_tamales = formPadre;
        }

        private Datos_torrejas form_dt_torrejas;
        public Entradas(Datos_torrejas formPadre)
        {
            InitializeComponent();
            this.form_dt_torrejas = formPadre;
        }

        private Datos_ensalada form_dt_ensaladas;
        public Entradas(Datos_ensalada formPadre)
        {
            InitializeComponent();
            this.form_dt_ensaladas = formPadre;
        }

        private Datos_sandwich form_dt_sandwich;
        public Entradas(Datos_sandwich formPadre)
        {
            InitializeComponent();
            this.form_dt_sandwich = formPadre;
        }

        private Datos_papas form_dt_papa;
        public Entradas(Datos_papas formPadre)
        {
            InitializeComponent();
            this.form_dt_papa = formPadre;
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

        private void btnPapas_Click(object sender, EventArgs e)
        {
            Datos_papas newForm = new Datos_papas();
            newForm.ShowDialog();
        }

        private void btnSopa_Click(object sender, EventArgs e)
        {
            Datos_sopa newForm = new Datos_sopa();
            newForm.ShowDialog();
        }

        private void btnTamales_Click(object sender, EventArgs e)
        {
            Datos_tamales newForm = new Datos_tamales();
            newForm.ShowDialog();
        }

        private void btnTorrejas_Click(object sender, EventArgs e)
        {
            Datos_torrejas newForm = new Datos_torrejas();
            newForm.ShowDialog();
        }

        private void btnEnsalada_Click(object sender, EventArgs e)
        {
            Datos_ensalada newForm = new Datos_ensalada();
            newForm.ShowDialog();
        }

        private void btnSandwich_Click(object sender, EventArgs e)
        {
            Datos_sandwich newForm = new Datos_sandwich();
            newForm.ShowDialog();
        }
    }
}
