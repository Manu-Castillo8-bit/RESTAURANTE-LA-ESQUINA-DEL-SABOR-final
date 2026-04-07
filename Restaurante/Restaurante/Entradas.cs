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

        //LOS CONSTRUCTORES PERMITEN RECIBIR DATOS DE OTROS FORMULARIOS.

        //-------------------CONSTRUCTOR DE SOPA----------------------------
        private Datos_sopa form_dt_sopa;
        public Entradas(Datos_sopa formPadre)
        {
            InitializeComponent();
            this.form_dt_sopa = formPadre;
        }
        //-----------------------------------------------------------------



        //--------------------CONSTRUCTOR DE TAMALES-----------------------
        private Datos_tamales form_dt_tamales;
        public Entradas(Datos_tamales formPadre)
        {
            InitializeComponent();
            this.form_dt_tamales = formPadre;
        }
        //-----------------------------------------------------------------



        //-------------------COSNTRUCTOR DE TORREJAS-----------------------
        private Datos_torrejas form_dt_torrejas;
        public Entradas(Datos_torrejas formPadre)
        {
            InitializeComponent();
            this.form_dt_torrejas = formPadre;
        }
        //-----------------------------------------------------------------



        //------------------CONSTRUCTOR DE ENSALADA------------------------
        private Datos_ensalada form_dt_ensaladas;
        public Entradas(Datos_ensalada formPadre)
        {
            InitializeComponent();
            this.form_dt_ensaladas = formPadre;
        }
        //-----------------------------------------------------------------


        //-----------------CONSTRUCTOR DE SANDWICH-------------------------
        private Datos_sandwich form_dt_sandwich;
        public Entradas(Datos_sandwich formPadre)
        {
            InitializeComponent();
            this.form_dt_sandwich = formPadre;
        }
        //-----------------------------------------------------------------


        //-----------------CONSTRUCTOR DE PAPAS---------------------------
        private Datos_papas form_dt_papa;
        public Entradas(Datos_papas formPadre)
        {
            InitializeComponent();
            this.form_dt_papa = formPadre;
        }
        //----------------------------------------------------------------


        //-------------EVENTOS CREADOS POR ERROR EN EL DISEÑADOR 💀---------------------
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //______________________________________________________________________________



        //---------------BOTÓN DE SALIDA ❌-------------------
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
        //----------------------------------------------------


        //--------------BOTON DE REGRESO AL MENÚ 🔙----------------
        private void R_e_m_Click(object sender, EventArgs e)
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
        //----------------------------------------------------------





                               //BOTONES

        //-----------------BOTON DE PAPAS--------------------------
        private void btnPapas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Datos_papas newForm = new Datos_papas();
            newForm.ShowDialog();
           
        }
        //--------------------------------------------------------



        //-------------------BOTON DE SOPAS-----------------------
        private void btnSopa_Click(object sender, EventArgs e)
        {
            this.Hide();
            Datos_sopa newForm = new Datos_sopa();
            newForm.ShowDialog();
        }
        //-------------------------------------------------------



        //-------------------BOTON DE TAMALES--------------------
        private void btnTamales_Click(object sender, EventArgs e)
        {
            this.Hide();
            Datos_tamales newForm = new Datos_tamales();
            newForm.ShowDialog();
        }
        //------------------------------------------------------



        //--------------------BOTON TORREJAS-----------------------
        private void btnTorrejas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Datos_torrejas newForm = new Datos_torrejas();
            newForm.ShowDialog();
        }
        //---------------------------------------------------------



        //-------------------BOTON DE ENSALADA----------------------
        private void btnEnsalada_Click(object sender, EventArgs e)
        {
            this.Hide();
            Datos_ensalada newForm = new Datos_ensalada();
            newForm.ShowDialog();
        }
        //----------------------------------------------------------


        //-------------------BOTON DE SANDWICH----------------------
        private void btnSandwich_Click(object sender, EventArgs e)
        {
            this.Hide();
            Datos_sandwich newForm = new Datos_sandwich();
            newForm.ShowDialog();
        }
        //----------------------------------------------------------
    }
}
