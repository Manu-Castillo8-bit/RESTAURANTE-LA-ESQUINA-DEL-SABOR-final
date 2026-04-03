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

namespace Restaurante
{
    public partial class Resumen : Form
    {
        public Resumen()
        {
            InitializeComponent();
        }

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
    {"Pastel de limón", 3.50}
};


        private void CargarPedidos()
        {
            dataGridView1.Rows.Clear();

            double totalGeneral = 0;

            void Agregar(string nombre, string cantidadTexto)
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

            // LLAMADAS
            Agregar("Papas", Almacenamiento_temporal.Papas);
            Agregar("Sopas", Almacenamiento_temporal.Sopas);
            Agregar("Tamales", Almacenamiento_temporal.Tamales);
            Agregar("Torrejas", Almacenamiento_temporal.Torrejas);
            Agregar("Ensaladas", Almacenamiento_temporal.Ensaladas);
            Agregar("Sandwiches", Almacenamiento_temporal.Sandwiches);

            Agregar("Pupusas", Almacenamiento_temporal.Pupusas);
            Agregar("Cena", Almacenamiento_temporal.Cena);
            Agregar("Panes", Almacenamiento_temporal.Panes);
            Agregar("Tortas", Almacenamiento_temporal.Tortas);
            Agregar("Lasaña", Almacenamiento_temporal.Lasaña);
            Agregar("Carne", Almacenamiento_temporal.Carne);

            Agregar("Bebidas", Almacenamiento_temporal.Bebidas);
            Agregar("Chocolates", Almacenamiento_temporal.Chocolates);
            Agregar("Cafes", Almacenamiento_temporal.Cafes);
            Agregar("Atoles", Almacenamiento_temporal.Atoles);
            Agregar("Licuados", Almacenamiento_temporal.Licuados);
            Agregar("Tes", Almacenamiento_temporal.Tes);

            Agregar("Tres Leches", Almacenamiento_temporal.TresLeches);
            Agregar("Quesadillas", Almacenamiento_temporal.Quesadillas);
            Agregar("Flanes", Almacenamiento_temporal.Flanes);
            Agregar("Pastel de chocolate", Almacenamiento_temporal.pastel);
            Agregar("Tartaletas", Almacenamiento_temporal.Tartaletas);
            Agregar("Pastel de limón", Almacenamiento_temporal.Pastel_de_limon);

            // Mostrar total (puedes usar Label)
            lblTotal.Text = "Total: $" + totalGeneral.ToString("0.00");
        }
    

        private void Resumen_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 4;

            dataGridView1.Columns[0].Name = "Producto";
            dataGridView1.Columns[1].Name = "Cantidad";
            dataGridView1.Columns[2].Name = "Precio Unitario";
            dataGridView1.Columns[3].Name = "Subtotal";

            CargarPedidos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarPedidos();
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            // Mostrar cuadro de diálogo de confirmación
            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que deseas regresar al menú?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Verificar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {

                // O si es un formulario específico:
                this.Hide();
                Menú newForm = new Menú();
                newForm.ShowDialog();

            }
            // Si el usuario selecciona No, no hace nada y permanece en la aplicación
        }

        private void salir_Click(object sender, EventArgs e)
        {
            // Mostrar cuadro de diálogo de confirmación
            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que deseas salir?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Verificar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                // Cerrar la aplicación
                Application.Exit();
                // O si es un formulario específico: this.Close();
            }
            // Si el usuario selecciona No, no hace nada y permanece en la aplicación
        }

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
                    
            }
        }


        private void butEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string producto = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                DialogResult r = MessageBox.Show("¿Eliminar este producto?", "Confirmar", MessageBoxButtons.YesNo);

                if (r == DialogResult.Yes)
                {
                    // 🔥 1. BORRAR DE LA CLASE (LO MÁS IMPORTANTE)
                    EliminarDeMemoria(producto);

                    // 🔥 2. RECARGAR (esto ya actualiza el grid)
                    CargarPedidos();
                }
            
        }
            else
            {
                MessageBox.Show("Selecciona una fila");
            }
        }
    }
    }

