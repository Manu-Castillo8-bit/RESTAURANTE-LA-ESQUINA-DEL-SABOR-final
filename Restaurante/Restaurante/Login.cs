using System;
using System.Data.OleDb;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Restaurante
{ //Prueba de commit
    public partial class Login : Form
    {
        private readonly string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Desktop\RESTAURANTE LA ESQUINA DEL SABOR\La esquina del sabor new.accdb;";

        public Login()
        {
            InitializeComponent();
        }

       //--------------EVENTOS CREADOS POR ERROR EN EL DISEÑADOR 💀----------------------
        private void label2_Click(object sender, EventArgs e)
        {
            //Ignorar
        }
        //------------------------------------------------------------------------------    





        private void ingresar_Click(object sender, EventArgs e)
        {
            // Asegúrate de que los nombres textBox1/textBox2 coincidan con tus controles
            string usuario = textBox1.Text;



            // Validar que el campo de usuario no esté vacío
            if (string.IsNullOrWhiteSpace(usuario))
            {
                MessageBox.Show("Ingrese por favor sus datos correspondientes.");
                return;
            }

            try
            {
                using (var conexion = new OleDbConnection(cadenaConexion))
                using (var comando = new OleDbCommand("SELECT COUNT(*) FROM tb_cliente WHERE [nombre]=? ", conexion))
                {
                    comando.Parameters.AddWithValue("?", usuario);
                   

                    conexion.Open();
                    int existe = Convert.ToInt32(comando.ExecuteScalar());


                    // Si los datos son válidos
                    if (existe > 0)
                    {
                        MessageBox.Show("BIENVENIDO A LA ESQUINA DEL SABOR ");
                        
                        this.Hide();
                        Menú newForm = new Menú();
                        newForm.ShowDialog();
                       
                    }
                    else
                    {
                        MessageBox.Show("Introduzca su nombre correcto.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //--------------EVENTOS CREADOS POR ERROR EN EL DISEÑADOR 💀----------------------

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //ignorar
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            
        }
        //------------------------------------------------------------------------------    



        //-----------------------------BOTON DE REGISTRARSE 🚹---------------------------------
        private void Registrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registro newForm = new Registro();
            newForm.ShowDialog();
        }
        //--------------------------------------------------------------------------------------


        //-----------------------------BOTON DE SALIR ❌---------------------------------
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
        //--------------------------------------------------------------------------------------
    }
}
