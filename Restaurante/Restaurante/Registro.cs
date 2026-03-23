using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Restaurante
{
    public partial class Registro : Form
    {
        string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Desktop\Etapa de informarse\Usuarios.accdb;";
        OleDbConnection conexion;
        public Registro()
        {
            InitializeComponent();
            conexion = new OleDbConnection(cadenaConexion);
        }

        private void Ingresar_l_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login newForm = new Login();
            newForm.ShowDialog();
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();

                string usuario = txtUsuario.Text;
                string contraseña = txtContraseña.Text;

                // Verificar si el usuario ya existe
                string consulta = "SELECT COUNT(*) FROM registros WHERE Usuario = ?";
                OleDbCommand verificarCmd = new OleDbCommand(consulta, conexion);
                verificarCmd.Parameters.AddWithValue("?", usuario);

                int existe = (int)verificarCmd.ExecuteScalar();

                if (existe > 0)
                {
                    MessageBox.Show("El usuario ya existe. Por favor, elige otro nombre de usuario.", "Usuario existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Insertar solo si no existe
                OleDbCommand comando = new OleDbCommand("INSERT INTO registros ([Usuario], [Contraseña]) VALUES (?, ?)", conexion);
                comando.Parameters.AddWithValue("?", usuario);
                comando.Parameters.AddWithValue("?", contraseña);

                int resultado = comando.ExecuteNonQuery();
                MessageBox.Show($"Registros insertados: {resultado}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                comando.Dispose();
                verificarCmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            /*
            

        

        

        private void button1_Click(object sender, EventArgs e)
        {
            /* string consulta = "SELECT * FROM login";  // <-- cambia por tu tabla
                OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                dataGridView1.DataSource = tabla;
        }

        */
        }

        private void Ver_contra_CheckedChanged(object sender, EventArgs e)
        {
            if (Ver_contra.Checked)
            {
                txtContraseña.PasswordChar = '\0';
            }
            else
            {
                txtContraseña.PasswordChar = '*';
            }
        }
    }
}
