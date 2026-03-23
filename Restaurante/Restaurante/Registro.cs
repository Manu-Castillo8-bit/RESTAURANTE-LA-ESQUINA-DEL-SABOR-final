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
        string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Desktop\RESTAURANTE LA ESQUINA DEL SABOR\La esquina del sabor new.accdb;";
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
                string correo = txtCorreo.Text;

                // Verificar si el usuario ya existe
                string consulta = "SELECT COUNT(*) FROM tb_cliente WHERE nombre = ?";
                OleDbCommand verificarCmd = new OleDbCommand(consulta, conexion);
                verificarCmd.Parameters.AddWithValue("?", usuario);

                int existe = (int)verificarCmd.ExecuteScalar();

                if (existe > 0)
                {
                    MessageBox.Show("El usuario ya existe. Por favor, elige otro nombre de usuario.", "Usuario existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Insertar solo si no existe
                OleDbCommand comando = new OleDbCommand("INSERT INTO tb_cliente ([nombre], [correo]) VALUES (?, ?)", conexion);
                comando.Parameters.AddWithValue("?", usuario);
                comando.Parameters.AddWithValue("?", correo);

                int resultado = comando.ExecuteNonQuery();
                MessageBox.Show($"Registros insertados: {resultado}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                comando.Dispose();
                verificarCmd.Dispose();
                txtUsuario.Clear();
                txtCorreo.Clear();

                this.Hide();
                Login newForm = new Login();
                newForm.ShowDialog();
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
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
