using System;
using System.Data.OleDb;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Restaurante
{
    public partial class Login : Form
    {
        // Usa la misma cadena que en Registro.cs
        private readonly string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Desktop\Profe Javier\Módulo 1.5\Etapa de informarse\Usuarios.accdb;";

        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //Ignorar
        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            // Asegúrate de que los nombres textBox1/textBox2 coincidan con tus controles
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Ingrese por favor sus datos correspondientes.");
                return;
            }

            try
            {
                using (var conexion = new OleDbConnection(cadenaConexion))
                using (var comando = new OleDbCommand("SELECT COUNT(*) FROM registros WHERE [Usuario]=? AND [Contraseña]=?", conexion))
                {
                    comando.Parameters.AddWithValue("?", usuario);
                    comando.Parameters.AddWithValue("?", contraseña);

                    conexion.Open();
                    int existe = Convert.ToInt32(comando.ExecuteScalar());

                    if (existe > 0)
                    {
                        MessageBox.Show("Bienvenido a LA ESQUINA DEL SABOR :D ");
                        // Credenciales válidas
                        this.Hide();
                        Menú newForm = new Menú();
                        newForm.ShowDialog();
                       
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //ignorar
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void Registrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registro newForm = new Registro();
            newForm.ShowDialog();
        }
    }
}
