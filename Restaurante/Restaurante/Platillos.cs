using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class Platillos : Form
    {
        private Datos_de_paltillos form_dt_platillos;

        
        
            
        
        public Platillos(Datos_de_paltillos formPadre)
        {
            InitializeComponent();
            this.form_dt_platillos = formPadre;
        }

        private Datos_cena form_dt_cena;
        public Platillos(Datos_cena formPadre)
        {
            InitializeComponent();
            this.form_dt_cena = formPadre;
        }

        private Datos_panes form_dt_panes;
        public Platillos(Datos_panes formPadre)
        {
            InitializeComponent();
            this.form_dt_panes = formPadre;
        }

        private Datos_tortas form_dt_tortas;
        public Platillos(Datos_tortas formPadre)
        {
            InitializeComponent();
            this.form_dt_tortas = formPadre;
        }


        private void R_pl_m_Click(object sender, EventArgs e)
        {
        
        }

        //-------Para recibir datos de otros formularios y mostrarlos en Platillos-------//




        private string pupusasRecibidas;
        public Platillos(string pupusas)
        {
            InitializeComponent();
            pupusasRecibidas = pupusas;
            // Puedes usar pupusasRecibidas como necesites
            
        }








        private void ord_pl_CheckedChanged(object sender, EventArgs e)
        {
            if (ord_pl.Checked)
            {
                this.Hide();
                Datos_de_paltillos newForm = new Datos_de_paltillos();
                newForm.Show();

                

            }
           
        }

        private void Ord_cena_CheckedChanged(object sender, EventArgs e)
        {
            if (Ord_cena.Checked)
            {
                this.Hide();
                Datos_cena newForm = new Datos_cena();
                newForm.Show();


            }
        }

        private void Ord_panes_CheckedChanged(object sender, EventArgs e)
        {
            if (Ord_panes.Checked)
            {
                this.Hide();
                Datos_panes newForm = new Datos_panes();
                newForm.Show();

            }
        }

        private void Ord_tortas_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            Datos_tortas newForm = new Datos_tortas();
            newForm.Show();
        }

        private void R_pl_m_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            // 2. Crear y mostrar el nuevo formulario (Form2)
            Menú newForm = new Menú();
            newForm.ShowDialog();
        }
    }
}
