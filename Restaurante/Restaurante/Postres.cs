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
    public partial class Postres : Form
    {
        public Postres()
        {
            InitializeComponent();
        }

        //-----------------------CONSTRUCTORES------------------------


        //--------------CONSTRUCTOR DE 3 LECHES----------------------
        private Datos_3_leches form_dt_3_leches;
        public Postres(Datos_3_leches formPadre)
        {
            InitializeComponent();
            this.form_dt_3_leches = formPadre;
        }
        //----------------------------------------------------------



        //---------CONSTRUCTOR DE QUESADILLAS-----------------------
        private Datos_quesadillas form_dt_quesadillas;
        public Postres(Datos_quesadillas formPadre)
        {
            InitializeComponent();
            this.form_dt_quesadillas = formPadre;
        }

        //-------------------------------------------------------



        //--------------------------CONSTRUCTOR DE FLAN--------------------------
        private Datos_flan form_dt_flan;
        public Postres(Datos_flan formPadre)
        {
            InitializeComponent();
            this.form_dt_flan= formPadre;
        }
        //-------------------------------------------------------------------------



        //-------------------COSNTRUCTOR DE PASTEL DE CHOCOLATE----------------------
        private Datospostres form_dt_pastel;
        public Postres(Datospostres formPadre)
        {
            InitializeComponent();
            this.form_dt_pastel = formPadre;
        }
        //---------------------------------------------------------------------------


        //-------------------BOTON DE REGRESO AL MENÚ 🔙----------------------

        private void R_pos_m_Click(object sender, EventArgs e)
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
        //-------------------------------------------------------------------------



        //----------EVENTOS CREADOS POR ERROR EN EL DISEÑADOR 💀-------------------
        private void ord_3_leches_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void ord_quesadillas_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void ord_flan_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void ord_pastel_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        //-------------------------------------------------------------------------



        //--------------BOTÓN DE TARTALETA----------------------
        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Datos_tartaleta newForm = new Datos_tartaleta();
            newForm.Show();
        }
        //-----------------------------------------------------


        //-------------BOTÓN DE PASTEL DE LIMÓN-------------------
        private void btnPasLimon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Datos_paslimon newForm = new Datos_paslimon();
            newForm.Show();
        }
        //-------------------------------------------------------



        //-----------------BOTÓN DE 3 LECHES----------------------
        private void btnLeches_Click(object sender, EventArgs e)
        {
            this.Hide();
            Datos_3_leches newForm = new Datos_3_leches();
            newForm.Show();
        }
        //---------------------------------------------------------


        //-----------------BOTÓN DE FLAN----------------------
        private void btnFlan_Click(object sender, EventArgs e)
        {
            this.Hide();
            Datos_flan newForm = new Datos_flan();
            newForm.Show();
        }
        //---------------------------------------------------------


        //-----------------BOTÓN DE QUESADILLAS----------------------
        private void btnQuesadillas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Datos_quesadillas newForm = new Datos_quesadillas();
            newForm.Show();
        }
        //-----------------------------------------------------------


        //-----------------BOTÓN DE PASTEL DE CHOCOLATE----------------
        private void btnPasChocolate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Datospostres newForm = new Datospostres();
            newForm.Show();
        }
        //-------------------------------------------------------------


        //-----------------BOTÓN DE SALIDA ❌ -------------------------
        private void button7_Click(object sender, EventArgs e)
        {
            // Mostrar cuadro de diálogo de confirmación
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
        //-----------------------------------------------------------
    }
}
