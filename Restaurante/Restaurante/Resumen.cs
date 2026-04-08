using Restaurante;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq.Expressions;

namespace Restaurante
{
    public partial class Resumen : Form
    {
        public Resumen()
        {
            InitializeComponent();
        }


 //-----------------Diccionario para almacenar los precios de los productos--------------------------
        Dictionary<string, double> precios = new Dictionary<string, double>()
{
    {"Papas", 1.00},
    {"Sopas", 1.50},
    {"Tamales",1.00}, //Son 3 por el dólar, así que se piden en dólares
    {"Torrejas", 2.00},
    {"Ensaladas", 1.50},
    {"Sandwiches", 1.50},

    {"Pupusas", 1.00}, //Son 3 por el dólar, así que se piden en dólares
    {"Cena", 3.50},
    {"Panes", 1.50},
    {"Tortas", 2.00},
    {"Lasaña", 1.50},
    {"Carne", 1.50},

    {"Bebidas", 1.00},
    {"Chocolates", 1.00},
    {"Cafes", 1.00},
    {"Atoles", 1.00},
    {"Licuados", 1.00},
    {"Tes", 1.00},

    {"Tres Leches", 3.00},
    {"Quesadillas", 2.00},
    {"Flanes", 1.50},
    {"Pastel de chocolate", 3.50},
    {"Tartaletas", 1.50},
    {"Pastel de limón", 3.50},


 // 🔥 ADEREZOS (precio unitario)
  {"Aderezo de Papas", 0.50},
 {"Aderezo de Ensaladas", 0.50 },
 {"Aderezo de Sandwiches", 0.50},
{"Aderezo de Pupusas", 0.50},
{"Aderezo de Panes", 0.50},
{"Aderezo de Cenas", 0.50},
{"Aderezo de Tortas", 0.50}
};
        //--------------------------------------------------------------------------------------------------------


        private void CargarPedidos()
        {
            dataGridView1.Rows.Clear();

            double totalGeneral = 0;

            void AgregarProducto(string nombre, string cantidadTexto)
            {
                if (!string.IsNullOrEmpty(cantidadTexto) && cantidadTexto != "0")
                {
                    int cantidad = int.Parse(cantidadTexto);
                    double precio = precios[nombre];
                    double subtotal = cantidad * precio;

                    totalGeneral += subtotal;

                    dataGridView1.Rows.Add(nombre, cantidad, precio, subtotal);
                }
            }

            // 🔥 Función para agregar aderezos (solo si tienen precio > 0)
            void AgregarAderezo(string nombre, string precioTexto)
            {
                if (!string.IsNullOrEmpty(precioTexto) && precioTexto != "0")
                {
                    double precioAderezo = double.Parse(precioTexto);
                    if (precioAderezo > 0)
                    {
                        // Los aderezos se muestran con cantidad 1 y su precio individual
                        totalGeneral += precioAderezo;
                        dataGridView1.Rows.Add(nombre, 1, precioAderezo, precioAderezo);
                    }
                }
            }


            // ========== PRODUCTOS NORMALES ==========

            // ENTRADAS
            AgregarProducto("Papas", Almacenamiento_temporal.Papas);
            AgregarProducto("Sopas", Almacenamiento_temporal.Sopas);
            AgregarProducto("Tamales", Almacenamiento_temporal.Tamales);
            AgregarProducto("Torrejas", Almacenamiento_temporal.Torrejas);
            AgregarProducto("Ensaladas", Almacenamiento_temporal.Ensaladas);
            AgregarProducto("Sandwiches", Almacenamiento_temporal.Sandwiches);

            // PLATILLOS
            AgregarProducto("Pupusas", Almacenamiento_temporal.Pupusas);
            AgregarProducto("Cena", Almacenamiento_temporal.Cena);
            AgregarProducto("Panes", Almacenamiento_temporal.Panes);
            AgregarProducto("Tortas", Almacenamiento_temporal.Tortas);
            AgregarProducto("Lasaña", Almacenamiento_temporal.Lasaña);
            AgregarProducto("Carne", Almacenamiento_temporal.Carne);

            // BEBIDAS
            AgregarProducto("Bebidas", Almacenamiento_temporal.Bebidas);
            AgregarProducto("Chocolates", Almacenamiento_temporal.Chocolates);
            AgregarProducto("Cafes", Almacenamiento_temporal.Cafes);
            AgregarProducto("Atoles", Almacenamiento_temporal.Atoles);
            AgregarProducto("Licuados", Almacenamiento_temporal.Licuados);
            AgregarProducto("Tes", Almacenamiento_temporal.Tes);

            // POSTRES
            AgregarProducto("Tres Leches", Almacenamiento_temporal.TresLeches);
            AgregarProducto("Quesadillas", Almacenamiento_temporal.Quesadillas);
            AgregarProducto("Flanes", Almacenamiento_temporal.Flanes);
            AgregarProducto("Pastel de chocolate", Almacenamiento_temporal.pastel);
            AgregarProducto("Tartaletas", Almacenamiento_temporal.Tartaletas);
            AgregarProducto("Pastel de limón", Almacenamiento_temporal.Pastel_de_limon);

            // ========== 🔥 ADEREZOS (se muestran como productos independientes) ==========
            AgregarAderezo("Aderezo de Papas", Almacenamiento_temporal.Ad_papas);
            AgregarAderezo("Aderezo de Ensaladas", Almacenamiento_temporal.Ad_ensaladas);
            AgregarAderezo("Aderezo de Sandwiches", Almacenamiento_temporal.Ad_sandwiches);
            AgregarAderezo("Aderezo de Pupusas", Almacenamiento_temporal.Ad_pupusas);
            AgregarAderezo("Aderezo de Panes", Almacenamiento_temporal.Ad_panes);
            AgregarAderezo("Aderezo de Cenas", Almacenamiento_temporal.Ad_cenas);
            AgregarAderezo("Aderezo de Tortas", Almacenamiento_temporal.Ad_tortas);

            // Mostrar total
            lblTotal.Text = "Total: $" + totalGeneral.ToString("0.00");
        }


        //---------------------BOTON DE MOSTRAR RESUMEN-------------------------
        private void Resumen_Load(object sender, EventArgs e)
        {
            // Configurar columnas del DataGridView
            dataGridView1.ColumnCount = 4;

            dataGridView1.Columns[0].Name = "Producto";
            dataGridView1.Columns[1].Name = "Cantidad";
            dataGridView1.Columns[2].Name = "Precio Unitario";
            dataGridView1.Columns[3].Name = "Subtotal";

            // Ajustar anchos de columnas
            dataGridView1.Columns[0].Width = 180;
            dataGridView1.Columns[1].Width = 80;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;

            CargarPedidos();
        }
        //-------------------------------------------------------------------------



        //---------------------BOTON DE ACTUALIZAR RESUMEN---------------------
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarPedidos();
        }
        //-------------------------------------------------------------------------



        //------------------BOTON DE REGRESO AL MENÚ 🔙------------------------
        private void regresar_Click(object sender, EventArgs e)
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




        //------------------BOTON DE SALIR DE LA APLICACIÓN ❌------------------------
        private void salir_Click(object sender, EventArgs e)
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
        //-------------------------------------------------------------------------





        // Método para eliminar un producto
        private void EliminarDeMemoria(string producto)
        {
            switch (producto)
            {
                case "Papas": Almacenamiento_temporal.Papas = "0"; break;
                case "Tamales": Almacenamiento_temporal.Tamales = "0"; break;
                case "Ensaladas": Almacenamiento_temporal.Ensaladas = "0"; break;
                case "Sopas": Almacenamiento_temporal.Sopas = "0"; break;
                case "Torrejas": Almacenamiento_temporal.Torrejas = "0"; break;
                case "Sandwiches": Almacenamiento_temporal.Sandwiches = "0"; break;

                case "Pupusas": Almacenamiento_temporal.Pupusas = "0"; break;
                case "Panes": Almacenamiento_temporal.Panes = "0"; break;
                case "Cena": Almacenamiento_temporal.Cena = "0"; break;
                case "Tortas": Almacenamiento_temporal.Tortas = "0"; break;
                case "Carne": Almacenamiento_temporal.Carne = "0"; break;
                case "Lasaña": Almacenamiento_temporal.Lasaña = "0"; break;

                case "Bebidas": Almacenamiento_temporal.Bebidas = "0"; break;
                case "Cafes": Almacenamiento_temporal.Cafes = "0"; break;
                case "Chocolates": Almacenamiento_temporal.Chocolates = "0"; break;
                case "Atoles": Almacenamiento_temporal.Atoles = "0"; break;
                case "Licuados": Almacenamiento_temporal.Licuados = "0"; break;
                case "Tes": Almacenamiento_temporal.Tes = "0"; break;

                case "Tres Leches": Almacenamiento_temporal.TresLeches = "0"; break;
                case "Flanes": Almacenamiento_temporal.Flanes = "0"; break;
                case "Quesadillas": Almacenamiento_temporal.Quesadillas = "0"; break;
                case "Pastel de chocolate": Almacenamiento_temporal.pastel = "0"; break;
                case "Tartaletas": Almacenamiento_temporal.Tartaletas = "0"; break;
                case "Pastel de limón": Almacenamiento_temporal.Pastel_de_limon = "0"; break;

                // 🔥 ADEREZOS
                case "Aderezo de Papas": Almacenamiento_temporal.Ad_papas = "0"; break;
                case "Aderezo de Ensaladas": Almacenamiento_temporal.Ad_ensaladas = "0"; break;
                case "Aderezo de Sandwiches": Almacenamiento_temporal.Ad_sandwiches = "0"; break;
                case "Aderezo de Pupusas": Almacenamiento_temporal.Ad_pupusas = "0"; break;
                case "Aderezo de Panes": Almacenamiento_temporal.Ad_panes = "0"; break;
                case "Aderezo de Cenas": Almacenamiento_temporal.Ad_cenas = "0"; break;
                case "Aderezo de Tortas": Almacenamiento_temporal.Ad_tortas = "0"; break;
            }
        }





        //----------------------------BOTON PARA ELIMINAR UN PRODUCTO DEL RESUMEN----------------------------
        private void butEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    string producto = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                    DialogResult r = MessageBox.Show($"¿Eliminar '{producto}' del pedido?",
                        "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (r == DialogResult.Yes)
                    {
                        // Eliminar de la memoria
                        EliminarDeMemoria(producto);

                        // Recargar el DataGridView
                        CargarPedidos();
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona un producto para eliminar", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
            //--------------------------------------------------------------------------------------------------
        
        



       
