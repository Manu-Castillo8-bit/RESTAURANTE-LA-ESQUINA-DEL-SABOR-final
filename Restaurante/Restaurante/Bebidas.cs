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



        //LOS CONSTRUCTORES PERMITEN RECIBIR DATOS DE OTROS FORMULARIOS.

        //_____________CONSTRUCTOR DE SODAS___________________________________
        private Datos_soda form_dt_soda;
        public Bebidas(Datos_soda formPadre)
        {
            InitializeComponent();
            this.form_dt_soda = formPadre;
        }
        //__________________________________________________________________



        //_______________CONSTRUCTOR DE CHOCOLATES____________________________

        private Datos_chocolate form_dt_chocolate;
        public Bebidas(Datos_chocolate formPadre)
        {
            InitializeComponent();
            this.form_dt_chocolate = formPadre;
        }
        //__________________________________________________________________



        //________________CONSTRUCTOR DE CAFÉS_______________________________

        private Datos_cafe form_dt_cafe;
        public Bebidas(Datos_cafe formPadre)
        {
            InitializeComponent();
            this.form_dt_cafe = formPadre;
        }
        //__________________________________________________________________



        //________________CONSTRUCTOR DE ATOLES______________________________

        private Datos_atol form_dt_atol;
        public Bebidas(Datos_atol formPadre)
        {
            InitializeComponent();
            this.form_dt_atol = formPadre;
        }
        //__________________________________________________________________



        //----------------BOTON DE REGRESO AL MENÚ 🔙--------------------------------
        private void ingresar_Click(object sender, EventArgs e)
        {


            //Muestra un mensaje de confirmación al usuario
            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que deseas regresar al menú?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Verificar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            { 
                this.Hide();
                Menú newForm = new Menú();
                newForm.ShowDialog();

            }
            // Si el usuario selecciona No, no hace nada y permanece en la aplicación
        }

        //___________________________________________________________________________





        //________________________EVENTOS CREADOS POR ERROR EN EL DISEÑADOR 💀____________________________________
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
        //__________________________________________________________________________________________________________________




        //----------------BOTON DE CHOCOLATE------------------
        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Datos_chocolate newForm = new Datos_chocolate();
            newForm.Show();
        }
        //___________________________________________________


        //-------------------BOTON DE SODA--------------------
        private void btnSoda_Click(object sender, EventArgs e)
        {
            this.Hide();
            Datos_soda newForm = new Datos_soda();
            newForm.Show();
        }
        //___________________________________________________


        //-------------------BOTON DE CAFÉ--------------------
        private void btnCafe_Click(object sender, EventArgs e)
        {
            this.Hide();
            Datos_cafe newForm = new Datos_cafe();
            newForm.Show();
        }
        //___________________________________________________


        //-------------------BOTON DE ATOL--------------------
        private void btnAtol_Click(object sender, EventArgs e)
        {
            this.Hide();
            Datos_atol newForm = new Datos_atol();
            newForm.Show();
        }
        //___________________________________________________


        //-------------------BOTON DE LICUADO--------------------
        private void btnLicuado_Click(object sender, EventArgs e)
        {
            this.Hide();
            Datos_licuado newForm = new Datos_licuado();
            newForm.Show();
        }
        //_____________________________________________________


        //-------------------BOTON DE TÉ--------------------
        private void btnTe_Click(object sender, EventArgs e)
        {//BOTON DE TÉ
            this.Hide();
            Datos_te newForm = new Datos_te();
            newForm.Show();
        }
        //_____________________________________________________


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
        //___________________________________________________
    }
}
