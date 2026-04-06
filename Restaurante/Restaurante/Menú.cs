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

        //-------------------------BOTON PARA REGRESAR AL LOGIN 🚹--------------------
        private void r_m_l_Click(object sender, EventArgs e)
        {
            
            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que deseas regresar al login?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                
                this.Hide();
                Login newForm = new Login();
                newForm.ShowDialog();

            }
        }
        //------------------------------------------------------------------------


        //-------------------BOTON DE PLATILLOS--------------------------------
        private void Platillos_Click(object sender, EventArgs e)
        {
            this.Hide();

            Datos_de_paltillos datosForm = new Datos_de_paltillos();
            Platillos newForm = new Platillos(datosForm);
            newForm.ShowDialog();
        }
        //---------------------------------------------------------------------



        //-----------------------BOTON DE BEBIDAS-----------------------------
        private void Bebidas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bebidas newForm = new Bebidas();
            newForm.ShowDialog();
        }
        //----------------------------------------------------------------------




        //-----------------------BOTON DE POSTRES----------------------------
        private void Postres_Click(object sender, EventArgs e)
        {
            this.Hide();
            Postres newForm = new Postres();
            newForm.ShowDialog();
        }
        //-------------------------------------------------------------------




        //----------------------BOTON DE FACTURA----------------------------
        private void Factura_Click(object sender, EventArgs e)
        {
            this.Hide();
            Factura newForm = new Factura();
            newForm.ShowDialog();
        }
        //-------------------------------------------------------------------




        //-----------------------BOTON DE ENTRADAS--------------------------
        private void Entradas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Entradas newForm = new Entradas();
            newForm.ShowDialog();
        }
        //------------------------------------------------------------------




        //----------------BOTON DE SALIDA ❌-----------------------
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
        //----------------------------------------------------------



        //------------BOTON DE RESUMEN DE PEDIDOS-------------------
        private void btnResumen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Resumen newForm = new Resumen();
            newForm.ShowDialog();
        }
        //-----------------------------------------------------------
    }
}
