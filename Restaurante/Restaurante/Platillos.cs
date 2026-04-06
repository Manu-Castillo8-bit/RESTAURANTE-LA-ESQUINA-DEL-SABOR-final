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
    {//------------------CONSTRUCTOR DE PUPUSAS----------------------
        private Datos_de_paltillos form_dt_platillos;

        public Platillos(Datos_de_paltillos formPadre)
        {
            InitializeComponent();
            this.form_dt_platillos = formPadre;
        }
        //------------------------------------------------------------


        //------------------CONSTRUCTOR DE CENA----------------------
        private Datos_cena form_dt_cena;
        public Platillos(Datos_cena formPadre)
        {
            InitializeComponent();
            this.form_dt_cena = formPadre;
        }
        //------------------------------------------------------------


        //------------------CONSTRUCTOR DE PANES----------------------
        private Datos_panes form_dt_panes;
        public Platillos(Datos_panes formPadre)
        {
            InitializeComponent();
            this.form_dt_panes = formPadre;
        }
        //------------------------------------------------------------


        //------------------CONSTRUCTOR DE TORTAS----------------------
        private Datos_tortas form_dt_tortas;
        public Platillos(Datos_tortas formPadre)
        {
            InitializeComponent();
            this.form_dt_tortas = formPadre;
        }
        //------------------------------------------------------------


        //------------------CONSTRUCTOR DE LASAÑA----------------------
        private Datos_lasaña form_dt_lasaña;
        public Platillos(Datos_lasaña formPadre)
        {
            InitializeComponent();
            this.form_dt_lasaña = formPadre;
        }
        //------------------------------------------------------------


        //------------------CONSTRUCTOR DE CARNE----------------------
        private Datos_carne form_dt_carne;
        public Platillos(Datos_carne formPadre)
        {
            InitializeComponent();
            this.form_dt_carne = formPadre;
        }
        //------------------------------------------------------------




        //------------EVENTOS CREADOS POR ERROR EN EL DISEÑADOR 💀----------------
        private void R_pl_m_Click(object sender, EventArgs e)
        {
        
        }
        //-------------------------------------------------------------------------




       //-------Para recibir datos de otros formularios y mostrarlos en Platillos-------

        private string pupusasRecibidas;
        public Platillos(string pupusas)
        {
            InitializeComponent();
            pupusasRecibidas = pupusas;
        }
        //-------------------------------------------------------------------------




        //------------EVENTOS CREADOS POR ERROR EN EL DISEÑADOR 💀----------------

        private void ord_pl_CheckedChanged(object sender, EventArgs e)
        {     
        }

        private void Ord_cena_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Ord_panes_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Ord_tortas_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        //-------------------------------------------------------------------------


        //-------------------BOTON DE REGRESO AL MENÚ 🔙------------------------------
        private void R_pl_m_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que deseas regresar al menú?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {

                this.Hide();
                Menú newForm = new Menú();
                newForm.ShowDialog();

            }
        }
        //-------------------------------------------------------------------------------



        //-------------------BOTON DE PUPUSAS----------------------
        private void btnPupusas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Datos_de_paltillos newForm = new Datos_de_paltillos();
            newForm.Show();
        }
        //---------------------------------------------------------



        //-------------------BOTON DE PANES----------------------
        private void btnPanes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Datos_panes newForm = new Datos_panes();
            newForm.Show();

        }
        //--------------------------------------------------------


        //-------------------BOTON DE CENA----------------------
           private void btnCena_Click(object sender, EventArgs e)
        {
            this.Hide();
            Datos_cena newForm = new Datos_cena();
            newForm.Show();

        }
        //-------------------------------------------------------


        //-------------------BOTON DE TORTAS----------------------
        private void btnTortas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Datos_tortas newForm = new Datos_tortas();
            newForm.Show();
        }
        //--------------------------------------------------------


        //-------------------BOTON DE CARNE----------------------
        private void btnCarne_Click(object sender, EventArgs e)
        {
            this.Hide();
            Datos_carne newForm = new Datos_carne();
            newForm.Show();
        }
        //-------------------------------------------------------


        //-------------------BOTON DE LASAÑA----------------------
        private void btnLasaña_Click(object sender, EventArgs e)
        {
            this.Hide();
            Datos_lasaña newForm = new Datos_lasaña();
            newForm.Show();
        }
        //--------------------------------------------------------


        //-------------------BOTON DE SALIR ❌ ----------------------
        private void button7_Click(object sender, EventArgs e)
        {
            
            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que deseas salir?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
 
            if (resultado == DialogResult.Yes)
            {
                
                Application.Exit();
               
            }
            
        }
        //---------------------------------------------------------
    }
}
