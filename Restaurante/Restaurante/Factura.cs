using System;
using System.Data.OleDb;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace Restaurante
{
    public partial class Factura : Form
    {
        private string pupusasRecibidas;
        private string cenasRecibidas;
        private string panesRecibidos;
        private string tortasRecibidas;

        private string sodasRecibidas;
        private string chocolatesRecibidos;
        private string cafesRecibidos;
        private string atolesRecibidos;

        private string tres_leches_Recibidos;
        private string quesadillasRecibidas;
        private string flanesRecibidos;
        private string pastelesRecibidos;



 public Factura()
        {
            InitializeComponent();

        }


        //--------------------BOTON DE REGRESO AL MENÚ------------------🔙
        private void R_f_m_Click(object sender, EventArgs e)
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
        //-----------------------------------------------------------------




        //--------------------------------ESTE METODO CREA LA FACTURA EN UN ARCHIVO .TXT--------------------------------
        private void GenerarFacturaTXT()
        {

            string fecha = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");    //Obtiene la fecha 
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //lo guarda en el escritorio
            string rutaCompleta = Path.Combine(rutaEscritorio, $"Factura_{fecha}.txt");

            StringBuilder contenido = new StringBuilder();

            // ========== ENCABEZADO ==========
            contenido.AppendLine("╔══════════════════════════════════════════════════════════════════════════════╗");
            contenido.AppendLine("║                                    SABOR RESTAURANTE                         ║");
            contenido.AppendLine("║                                    FACTURA DE COMPRA                         ║");
            contenido.AppendLine("╠══════════════════════════════════════════════════════════════════════════════╣");
            contenido.AppendLine($"║  Fecha: {DateTime.Now:dd/MM/yyyy HH:mm:ss}                                   ║");
            contenido.AppendLine("╠══════════════════════════════════════════════════════════════════════════════╣");
            contenido.AppendLine("");

            // ==========PRECIOS DE LAS ENTRADAS ==========
            if (textBox14.Text != "0" || textBox13.Text != "0" || textBox12.Text != "0" || textBox10.Text != "0" || textBox6.Text != "0" || textBox2.Text != "0")
            {
                contenido.AppendLine("║  ENTRADAS:");
                contenido.AppendLine("║  ────────────────────────────────────────────────────────────────────────");
                contenido.AppendLine($"║  Papas:                                    ${textBox14.Text.PadLeft(10)}");
                contenido.AppendLine($"║  Sopas:                                    ${textBox13.Text.PadLeft(10)}");
                contenido.AppendLine($"║  Tamales:                                  ${textBox12.Text.PadLeft(10)}");
                contenido.AppendLine($"║  Torrejas:                                 ${textBox10.Text.PadLeft(10)}");
                contenido.AppendLine($"║  Ensaladas:                                ${textBox6.Text.PadLeft(10)}");
                contenido.AppendLine($"║  Sandwiches:                               ${textBox2.Text.PadLeft(10)}");
                contenido.AppendLine("");
                contenido.AppendLine($"║  Aderezo de papas:                         ${ade_papas.Text.PadLeft(10)}");
                contenido.AppendLine($"║  Aderezo de ensaladas:                     ${ade_ensaladas.Text.PadLeft(10)}");
                contenido.AppendLine($"║  Aderezo de sandwiches:                    ${ade_sandwiches.Text.PadLeft(10)}");
                contenido.AppendLine("");
                contenido.AppendLine($"║  Subtotal Entradas:                        ${t_entradas.Text.PadLeft(10)}");
                contenido.AppendLine("");
            }

            // ========== PRECIOS DE LOS PLATILLOS ==========
            if (a.Text != "0" || b.Text != "0" || c.Text != "0" || d.Text != "0" || textBox1.Text != "0" || textBox3.Text != "0")
            {
                contenido.AppendLine("║  PLATILLOS:");
                contenido.AppendLine("║  ────────────────────────────────────────────────────────────────────────");
                contenido.AppendLine($"║  Pupusas:                                  ${a.Text.PadLeft(10)}");
                contenido.AppendLine($"║  Cena:                                     ${b.Text.PadLeft(10)}");
                contenido.AppendLine($"║  Panes:                                    ${c.Text.PadLeft(10)}");
                contenido.AppendLine($"║  Tortas:                                   ${d.Text.PadLeft(10)}");
                contenido.AppendLine($"║  Lasaña:                                   ${textBox1.Text.PadLeft(10)}");
                contenido.AppendLine($"║  Carne:                                    ${textBox3.Text.PadLeft(10)}");
                contenido.AppendLine("");
                contenido.AppendLine($"║  Aderezo de pupusas:                       ${ade_pupusas.Text.PadLeft(10)}");
                contenido.AppendLine($"║  Aderezo de panes:                         ${ade_panes.Text.PadLeft(10)}");
                contenido.AppendLine($"║  Aderezo de cenas:                         ${ade_cenas.Text.PadLeft(10)}");
                contenido.AppendLine($"║  Aderezo de tortas:                        ${ade_tortas.Text.PadLeft(10)}");
                contenido.AppendLine("");
                contenido.AppendLine($"║  Subtotal Platillos:                       ${t_platillos.Text.PadLeft(10)}");
                contenido.AppendLine("");
            }

            // ========== PRECIOS DE LAS BEBIDAS ==========
            if (e_.Text != "0" || f.Text != "0" || g.Text != "0" || h.Text != "0" || textBox5.Text != "0" || textBox7.Text != "0")
            {
                contenido.AppendLine("║  BEBIDAS:");
                contenido.AppendLine("║  ────────────────────────────────────────────────────────────────────────");
                contenido.AppendLine($"║  Bebidas enlatadas:                        ${e_.Text.PadLeft(10)}");
                contenido.AppendLine($"║  Chocolates:                               ${f.Text.PadLeft(10)}");
                contenido.AppendLine($"║  Cafés:                                    ${g.Text.PadLeft(10)}");
                contenido.AppendLine($"║  Atoles:                                   ${h.Text.PadLeft(10)}");
                contenido.AppendLine($"║  Licuados:                                 ${textBox5.Text.PadLeft(10)}");
                contenido.AppendLine($"║  Tés:                                      ${textBox7.Text.PadLeft(10)}");
                contenido.AppendLine("");
                contenido.AppendLine($"║  Subtotal Bebidas:                         ${t_bebidas.Text.PadLeft(10)}");
                contenido.AppendLine("");
            }

            // ========== PRECIOS DE LOS POSTRES ==========
            if (i.Text != "0" || j.Text != "0" || k.Text != "0" || l.Text != "0" || textBox9.Text != "0" || textBox11.Text != "0")
            {
                contenido.AppendLine("║  POSTRES:");
                contenido.AppendLine("║  ────────────────────────────────────────────────────────────────────────");
                contenido.AppendLine($"║  Tres Leches:                              ${i.Text.PadLeft(10)}");
                contenido.AppendLine($"║  Quesadillas:                              ${j.Text.PadLeft(10)}");
                contenido.AppendLine($"║  Flanes:                                   ${k.Text.PadLeft(10)}");
                contenido.AppendLine($"║  Pastel de chocolate:                      ${l.Text.PadLeft(10)}");
                contenido.AppendLine($"║  Tartaletas:                               ${textBox9.Text.PadLeft(10)}");
                contenido.AppendLine($"║  Pastel de limón:                          ${textBox11.Text.PadLeft(10)}");
                contenido.AppendLine("");
                contenido.AppendLine($"║  Subtotal Postres:                         ${t_postres.Text.PadLeft(10)}");
                contenido.AppendLine("");
            }

            // ========== TOTAL FINAL ==========
            contenido.AppendLine("╠════════════════════════════════════════════════════════════════════════════════╣");
            contenido.AppendLine($"║                                                                                ║");
            contenido.AppendLine($"║  TOTAL A PAGAR:                             ${precio_final.Text.PadLeft(10)}   ║");
            contenido.AppendLine($"║                                                                                ║");
            contenido.AppendLine("║  ¡GRACIAS POR SU COMPRA!                                                       ║");
            contenido.AppendLine("║  VUELVA PRONTO                                                                 ║");
            contenido.AppendLine("║                                                                                ║");
            contenido.AppendLine("╚════════════════════════════════════════════════════════════════════════════════╝");

            // Guardar el archivo
            try
            {
                File.WriteAllText(rutaCompleta, contenido.ToString());

                DialogResult resultado = MessageBox.Show(
                    $"Factura guardada en:\n{rutaCompleta}\n\n¿Desea abrir el archivo?",
                    "Factura Generada",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );

                if (resultado == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("notepad.exe", rutaCompleta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------




        //----------------------------BOTON DE GENERAR FACTURA---------------------------------
        private void Calcular_total_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(precio_final.Text) || precio_final.Text == "0")
            {
                MessageBox.Show("Primero calcule el total antes de generar la factura",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            GuardarFacturaEnBD();

            GenerarFacturaTXT();
        }
        //--------------------------------------------------------------------------------------











        private void Total_Click(object sender, EventArgs e)

        {
           // VerNombresEnTablas();
            //VerPlatillosExistentes();

        //....................................................ENTRADAS.................................................................


            //-------Convierte las cantidades de cada producto a double para poder realizar los cálculos---------
        double papas = Convert.ToDouble(Almacenamiento_temporal.Papas);
            double sopas = Convert.ToDouble(Almacenamiento_temporal.Sopas);
            double tamales = Convert.ToDouble(Almacenamiento_temporal.Tamales);
            double torrejas = Convert.ToDouble(Almacenamiento_temporal.Torrejas);
            double ensalada = Convert.ToDouble(Almacenamiento_temporal.Ensaladas);
            double sandwich = Convert.ToDouble(Almacenamiento_temporal.Sandwiches);
            double ad_papas = Convert.ToDouble(Almacenamiento_temporal.Ad_papas);
            double ad_ensaladas = Convert.ToDouble(Almacenamiento_temporal.Ad_ensaladas);
            double ad_sandwiches = Convert.ToDouble(Almacenamiento_temporal.Ad_sandwiches);
            //----------------------------------------------------------------------------------------------------



            //--------------------------Calcula el precio de cada producto---------------------------------------------
            double p_papas = (papas * 1.00);
            double papas_mas_ade = p_papas + ad_papas;      //Guarda el precio de las papas más el aderezo
            double p_sopas = sopas * 1.50;
            double p_tamales = tamales * 1.00;
            double p_torrejas = torrejas * 2.00;
            double p_ensalada = (ensalada * 1.50);
            double ensalada_mas_ade = p_ensalada + ad_ensaladas; //Guarda el precio de la ensalada más el aderezo
            double p_sandwich = (sandwich * 1.50);
            double sandwich_mas_ade = p_sandwich + ad_sandwiches; //Guarda el precio de los sandwiches más el aderezo
            
            double total_entradas = papas_mas_ade + p_sopas + p_tamales + p_torrejas + ensalada_mas_ade + sandwich_mas_ade;
            //--------------------------------------------------------------------------------------------------------------



            //-------------MUESTRA LOS PRECIOS EN PANTALLA-----------------------

            papas_f.Text = Convert.ToString(p_papas);
            sopas_f.Text = Convert.ToString(p_sopas);
            tamales_f.Text = Convert.ToString(p_tamales);
            torrejas_f.Text = Convert.ToString(p_torrejas);
            ensalada_f.Text = Convert.ToString(p_ensalada);
            sandwich_f.Text = Convert.ToString(p_sandwich);

            //Aderezos de papas, ensaladas y sandwiches
            ade_papas.Text = Almacenamiento_temporal.Ad_papas;
            ade_ensaladas.Text = Almacenamiento_temporal.Ad_ensaladas;
            ade_sandwiches.Text = Almacenamiento_temporal.Ad_sandwiches;
            //--------------------------------------------------------------------










            //........................................PLATILLOS...........................................................................................




            //-------Convierte las cantidades de cada producto a double para poder realizar los cálculos---------

            double pupusas = Convert.ToDouble(Almacenamiento_temporal.Pupusas);
            double cena = Convert.ToDouble(Almacenamiento_temporal.Cena);
            double panes = Convert.ToDouble(Almacenamiento_temporal.Panes);
            double tortas = Convert.ToDouble(Almacenamiento_temporal.Tortas);
            double lasaña = Convert.ToDouble(Almacenamiento_temporal.Lasaña);
            double carne = Convert.ToDouble(Almacenamiento_temporal.Carne);
            double ad_pupusas = Convert.ToDouble(Almacenamiento_temporal.Ad_pupusas);
            double ad_panes = Convert.ToDouble(Almacenamiento_temporal.Ad_panes);
            double ad_cenas = Convert.ToDouble(Almacenamiento_temporal.Ad_cenas);
            double ad_tortas = Convert.ToDouble(Almacenamiento_temporal.Ad_tortas);
            //----------------------------------------------------------------------------------------------------




            //--------------------------Calcula el precio de cada producto---------------------------------------
            double p_pupusas = (pupusas * 1.00);
            double pupusas_mas_ade = p_pupusas + ad_pupusas; //Guarda el precio de las pupusas más el aderezo
            double p_cena = (cena * 3.50);
            double cena_mas_ade = p_cena + ad_cenas; //Guarda el precio de la cena más el aderezo
            double p_panes = (panes * 1.50);
            double panes_mas_ade = p_panes + ad_panes; //Guarda el precio de los panes más el aderezo
            double p_tortas = (tortas * 2.00);
            double tortas_mas_ade = p_tortas + ad_tortas; //Guarda el precio de las tortas más el aderezo
            double p_lasaña = lasaña * 1.50;
            double p_carne = carne * 1.50;
            //----------------------------------------------------------------------------------------------------



            //-------------MUESTRA LOS PRECIOS EN PANTALLA-----------------------
            pupusas_f.Text = Convert.ToString(p_pupusas);
            cena_f.Text = Convert.ToString(p_cena);
            panes_f.Text = Convert.ToString(p_panes);
            torta_f.Text = Convert.ToString(p_tortas);
            lasaña_f.Text = Convert.ToString(p_lasaña);
            carne_f.Text = Convert.ToString(p_carne);

            //Aderezos de pupusas, panes, cenas y tortas
            ade_pupusas.Text = Almacenamiento_temporal.Ad_pupusas;
            ade_panes.Text = Almacenamiento_temporal.Ad_panes;
            ade_cenas.Text = Almacenamiento_temporal.Ad_cenas;
            ade_tortas.Text = Almacenamiento_temporal.Ad_tortas;

            double total_platillos = pupusas_mas_ade + cena_mas_ade + panes_mas_ade +
                tortas_mas_ade + p_lasaña + p_carne;
            //----------------------------------------------------------------------











            //.........................................BEBIDAS.............................................................................




            //-------Convierte las cantidades de cada producto a double para poder realizar los cálculos---------
            double soda = Convert.ToDouble(Almacenamiento_temporal.Bebidas);
            double chocolate = Convert.ToDouble(Almacenamiento_temporal.Chocolates);
            double cafe = Convert.ToDouble(Almacenamiento_temporal.Cafes);
            double atol = Convert.ToDouble(Almacenamiento_temporal.Atoles);
            double licuado = Convert.ToDouble(Almacenamiento_temporal.Licuados);
            double te = Convert.ToDouble(Almacenamiento_temporal.Tes);
            //----------------------------------------------------------------------------------------------------



            //-----------------------Calcula el precio de cada producto--------------------
            double p_soda = soda * 1.00;
            double p_chocolate = chocolate * 1.00;
            double p_cafe = cafe * 1.00;
            double p_atol = atol * 1.00;
            double p_licuado = licuado * 1.00;
            double p_te = te * 1.00;
            //----------------------------------------------------------------------------------


            //-------------MUESTRA LOS PRECIOS EN PANTALLA----------------------
            soda_f.Text = Convert.ToString(p_soda);
            chocolate_f.Text = Convert.ToString(p_chocolate);
            cafe_f.Text = Convert.ToString(p_cafe);
            atol_f.Text = Convert.ToString(p_atol);
            licuado_f.Text = Convert.ToString(p_licuado);
            te_f.Text = Convert.ToString(p_te);

            double total_bebidas = ((soda * 1.00) + chocolate * 1.00 +
                cafe * 1.00 + atol * 1.00 + licuado * 1.00 + te * 1.00);
            //--------------------------------------------------------------------------------









            //.............................................POSTRES......................................................................................



            //-------Convierte las cantidades de cada producto a double para poder realizar los cálculos---------
            double tres_l = Convert.ToDouble(Almacenamiento_temporal.TresLeches);
            double quesadillas = Convert.ToDouble(Almacenamiento_temporal.Quesadillas);
            double flan = Convert.ToDouble(Almacenamiento_temporal.Flanes);
            double pastel = Convert.ToDouble(Almacenamiento_temporal.pastel);
            double tartaleta = Convert.ToDouble(Almacenamiento_temporal.Tartaletas);
            double pastel_li = Convert.ToDouble(Almacenamiento_temporal.Pastel_de_limon);
            //----------------------------------------------------------------------------------------------------




            //-----------------------Calcula el precio de cada producto--------------------
            double p_tres_l = tres_l * 3.00;
            double p_quesadillas = quesadillas * 2.00;
            double p_flan = flan * 1.50;
            double p_pastel = pastel * 3.50;
            double p_tartaleta = tartaleta * 1.50;
            double p_pastel_li = pastel_li * 3.50;
            //  ----------------------------------------------------------------------------------



            //-------------MUESTRA LOS PRECIOS EN PANTALLA----------------------
            tres_l_f.Text = Convert.ToString(p_tres_l);
            quesadillas_f.Text = Convert.ToString(p_quesadillas);
            flan_f.Text = Convert.ToString(p_flan);
            pastel_f.Text = Convert.ToString(p_pastel);
            tartaleta_f.Text = Convert.ToString(p_tartaleta);
            pastel_li_f.Text = Convert.ToString(p_pastel_li);

            double total_postres = (tres_l * 3.00) + quesadillas * 2.00 + flan * 1.50 +
                pastel * 3.50 + tartaleta * 1.50 + pastel_li * 3.50;
            //----------------------------------------------------------------------------------







            //-------------MUESTRA LOS PRECIOS EN FORMATO DE MONDEDA EN PANTALLA-----------------------
            papas_f.Text = p_papas.ToString("F2");
            sopas_f.Text = p_sopas.ToString("F2");
            tamales_f.Text = p_tamales.ToString("F2");
            torrejas_f.Text = p_torrejas.ToString("F2");
            ensalada_f.Text = p_ensalada.ToString("F2");
            sandwich_f.Text = p_sandwich.ToString("F2");

            textBox14.Text = papas_mas_ade.ToString("F2");
            textBox13.Text = p_sopas.ToString("F2");
            textBox12.Text = p_tamales.ToString("F2");
            textBox10.Text = p_torrejas.ToString("F2");
            textBox6.Text = ensalada_mas_ade.ToString("F2");
            textBox2.Text = sandwich_mas_ade.ToString("F2");


            pupusas_f.Text = p_pupusas.ToString("F2");
            cena_f.Text = p_cena.ToString("F2");
            panes_f.Text = p_panes.ToString("F2");
            torta_f.Text = p_tortas.ToString("F2");
            lasaña_f.Text = p_lasaña.ToString("F2");
            carne_f.Text = p_carne.ToString("F2");

            a.Text = pupusas_mas_ade.ToString("F2");
            b.Text = cena_mas_ade.ToString("F2");
            c.Text = panes_mas_ade.ToString("F2");
            d.Text = tortas_mas_ade.ToString("F2");
            textBox1.Text = p_lasaña.ToString("F2");
            textBox3.Text = p_carne.ToString("F2");

            soda_f.Text = p_soda.ToString("F2");
            chocolate_f.Text = p_chocolate.ToString("F2");
            cafe_f.Text = p_cafe.ToString("F2");
            atol_f.Text = p_atol.ToString("F2");
            licuado_f.Text = p_licuado.ToString("F2");
            te_f.Text = p_te.ToString("F2");

            e_.Text = p_soda.ToString("F2");
            f.Text = p_chocolate.ToString("F2");
            g.Text = p_cafe.ToString("F2");
            h.Text = p_atol.ToString("F2");
            textBox5.Text = p_licuado.ToString("F2");
            textBox7.Text = p_te.ToString("F2");

            tres_l_f.Text = p_tres_l.ToString("F2");
            quesadillas_f.Text = p_quesadillas.ToString("F2");
            flan_f.Text = p_flan.ToString("F2");
            pastel_f.Text= p_pastel.ToString("F2");
            tartaleta_f.Text = p_tartaleta.ToString("F2");
            pastel_li_f.Text = p_pastel_li.ToString("F2");

            i.Text = p_tres_l.ToString("F2");
            j.Text = p_quesadillas.ToString("F2");
            k.Text = p_flan.ToString("F2");
            l.Text = p_pastel.ToString("F2");
            textBox9.Text = p_tartaleta.ToString("F2");
            textBox11.Text = p_pastel_li.ToString("F2");


            t_entradas.Text = Convert.ToString(total_entradas);
            t_platillos.Text = Convert.ToString(total_platillos);
            t_bebidas.Text = Convert.ToString(total_bebidas);
            t_postres.Text = Convert.ToString(total_postres);

            precio_final.Text = Convert.ToString(total_entradas + total_platillos + total_bebidas + total_postres);

            Calcular_total.Visible = true;
            // Guardar en la base de datos

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //Ignorar
        }

        private void a_TextChanged(object sender, EventArgs e)
        {
            //Ignorar
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
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













        // Método principal para guardar la factura
        private void GuardarFacturaEnBD()
        {
            if (!ConfiguracionDB.ValidarBaseDatos())
                return;

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(ConfiguracionDB.CadenaConexion))
                {
                    conexion.Open();
                    OleDbTransaction transaccion = conexion.BeginTransaction();

                    try
                    {
                        // 🔥 Verificar qué ID de cliente está obteniendo
                        int idCliente = InsertarCliente(conexion, transaccion);
                        MessageBox.Show($"ID Cliente obtenido: {idCliente}"); // ← Depuración

                        if (idCliente <= 0)
                        {
                            MessageBox.Show("Error: ID de cliente inválido (0 o negativo)");
                            transaccion.Rollback();
                            return;
                        }

                        int idPedido = InsertarPedido(conexion, transaccion, idCliente);
                        MessageBox.Show($"ID Pedido: {idPedido}"); // ← Depuración

                        int idDetalle = InsertarDetalle(conexion, transaccion, idPedido);
                        MessageBox.Show($"ID Detalle: {idDetalle}"); // ← Depuración

                  //      InsertarAgregados(conexion, transaccion, idCliente, idDetalle);

                        transaccion.Commit();

                        MessageBox.Show($"¡Factura guardada exitosamente!\nCliente: {Almacenamiento_temporal.usuario_temp}\nNúmero de Pedido: {idPedido}",
                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        transaccion.Rollback();
                        MessageBox.Show($"Error al guardar: {ex.Message}\n\nDetalle: {ex.StackTrace}",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error de conexión: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int InsertarCliente(OleDbConnection conexion, OleDbTransaction transaccion)
        {
            string nombreUsuario = Almacenamiento_temporal.usuario_temp;

            if (string.IsNullOrEmpty(nombreUsuario) || nombreUsuario == "0")
                nombreUsuario = "Cliente General";

            // 🔥 Verificar si el cliente ya existe
            string queryVerificar = "SELECT id_cliente FROM tb_cliente WHERE nombre_cliente = ?";

            using (OleDbCommand cmdVerificar = new OleDbCommand(queryVerificar, conexion, transaccion))
            {
                cmdVerificar.Parameters.AddWithValue("?", nombreUsuario);
                object resultado = cmdVerificar.ExecuteScalar();

                if (resultado != null && resultado != DBNull.Value)
                {
                    int idExistente = Convert.ToInt32(resultado);
                    MessageBox.Show($"Cliente existente encontrado. ID: {idExistente}"); // Depuración
                    return idExistente;
                }
            }

            // Insertar nuevo cliente
            string queryInsertar = @"INSERT INTO tb_cliente (nombre_cliente, telefono, correo) 
                             VALUES (?, ?, ?)";

            using (OleDbCommand cmd = new OleDbCommand(queryInsertar, conexion, transaccion))
            {
                cmd.Parameters.AddWithValue("?", nombreUsuario);
                cmd.Parameters.AddWithValue("?", "00000000");
                cmd.Parameters.AddWithValue("?", "sin@correo.com");

                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT @@IDENTITY";
                int nuevoId = Convert.ToInt32(cmd.ExecuteScalar());
                MessageBox.Show($"Nuevo cliente insertado. ID: {nuevoId}"); // Depuración
                return nuevoId;
            }
        }
        private int InsertarPedido(OleDbConnection conexion, OleDbTransaction transaccion, int idCliente)
        {
            try
            {
                double total = ObtenerValorDecimal(precio_final.Text);
                string nombreCliente = Almacenamiento_temporal.usuario_temp;

                if (string.IsNullOrEmpty(nombreCliente) || nombreCliente == "0")
                    nombreCliente = "Cliente General";

                // 🔥 PRIMERO: Verificar la estructura de la tabla
                string queryVerificar = "SELECT * FROM tb_pedido WHERE 1=0";
                using (OleDbCommand cmdVerificar = new OleDbCommand(queryVerificar, conexion, transaccion))
                {
                    using (OleDbDataReader reader = cmdVerificar.ExecuteReader())
                    {
                        string campos = "Campos encontrados: ";
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            campos += reader.GetName(i) + ", ";
                        }
                        MessageBox.Show(campos); // Ver qué campos existen
                    }
                }

                // 🔥 SEGUNDO: Insertar usando SOLO los campos que existen
                // PRUEBA SOLO CON ID_CLIENTE Y TOTAL (sin fecha ni nombre)
                string query = @"INSERT INTO tb_pedido (id_cliente, total) VALUES (?, ?)";

                using (OleDbCommand cmd = new OleDbCommand(query, conexion, transaccion))
                {
                    cmd.Parameters.AddWithValue("?", idCliente);
                    cmd.Parameters.AddWithValue("?", (decimal)total);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "SELECT @@IDENTITY";
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en InsertarPedido: {ex.Message}");
                throw;
            }
        }
        private int InsertarDetalle(OleDbConnection conexion, OleDbTransaction transaccion, int idPedido)
        {
            // Obtener cantidades y totales
            int cantPlatillos = ObtenerCantidadPlatillos();
            decimal totalPlatillos = (decimal)ObtenerValorDecimal(t_platillos.Text);

            int cantBebidas = ObtenerCantidadBebidas();
            decimal totalBebidas = (decimal)ObtenerValorDecimal(t_bebidas.Text);

            int cantEntradas = ObtenerCantidadEntradas();
            decimal totalEntradas = (decimal)ObtenerValorDecimal(t_entradas.Text);

            int cantPostres = ObtenerCantidadPostres();
            decimal totalPostres = (decimal)ObtenerValorDecimal(t_postres.Text);

            decimal subtotalBase = totalPlatillos + totalBebidas + totalEntradas + totalPostres;

            string nombreCliente = Almacenamiento_temporal.usuario_temp;
            if (string.IsNullOrEmpty(nombreCliente) || nombreCliente == "0")
                nombreCliente = "Cliente General";

            // 🔥 OBTENER IDs REALES (pueden ser NULL)
            var ids = ObtenerIdsProductosComprados();

            string query = @"INSERT INTO tb_detalle (
                id_pedido, 
                id_platillo,
                nombre_cliente,
                nombre_platillo, 
                cantidad_platillo, 
                total_platillo,
                id_bebida,
                nombre_bebida, 
                cantidad_bebida, 
                total_bebida,
                id_entrada,
                nombre_entrada, 
                cantidad_entrada, 
                total_entrada,
                id_postre,
                nombre_postre, 
                cantidad_postre, 
                total_postre,
                subtotal_base
             ) VALUES (
                ?, ?, ?, ?, ?, ?,
                ?, ?, ?, ?,
                ?, ?, ?, ?,
                ?, ?, ?, ?,
                ?
             )";

            using (OleDbCommand cmd = new OleDbCommand(query, conexion, transaccion))
            {
                // Campos de platillos
                cmd.Parameters.AddWithValue("?", idPedido);

                // 🔥 id_platillo: NULL si no hay cantidad
                if (ids.idPlatillo.HasValue && cantPlatillos > 0)
                    cmd.Parameters.AddWithValue("?", ids.idPlatillo.Value);
                else
                    cmd.Parameters.AddWithValue("?", DBNull.Value);

                cmd.Parameters.AddWithValue("?", nombreCliente);
                cmd.Parameters.AddWithValue("?", ObtenerNombrePlatilloConCantidad());
                cmd.Parameters.AddWithValue("?", cantPlatillos);
                cmd.Parameters.AddWithValue("?", totalPlatillos);

                // Campos de bebidas
                // 🔥 id_bebida: NULL si no hay cantidad
                if (ids.idBebida.HasValue && cantBebidas > 0)
                    cmd.Parameters.AddWithValue("?", ids.idBebida.Value);
                else
                    cmd.Parameters.AddWithValue("?", DBNull.Value);

                cmd.Parameters.AddWithValue("?", ObtenerNombreBebidaConCantidad());
                cmd.Parameters.AddWithValue("?", cantBebidas);
                cmd.Parameters.AddWithValue("?", totalBebidas);

                // Campos de entradas
                // 🔥 id_entrada: NULL si no hay cantidad
                if (ids.idEntrada.HasValue && cantEntradas > 0)
                    cmd.Parameters.AddWithValue("?", ids.idEntrada.Value);
                else
                    cmd.Parameters.AddWithValue("?", DBNull.Value);

                cmd.Parameters.AddWithValue("?", ObtenerNombreEntradaConCantidad());
                cmd.Parameters.AddWithValue("?", cantEntradas);
                cmd.Parameters.AddWithValue("?", totalEntradas);

                // Campos de postres
                // 🔥 id_postre: NULL si no hay cantidad
                if (ids.idPostre.HasValue && cantPostres > 0)
                    cmd.Parameters.AddWithValue("?", ids.idPostre.Value);
                else
                    cmd.Parameters.AddWithValue("?", DBNull.Value);

                cmd.Parameters.AddWithValue("?", ObtenerNombrePostreConCantidad());
                cmd.Parameters.AddWithValue("?", cantPostres);
                cmd.Parameters.AddWithValue("?", totalPostres);

                // Subtotal
                cmd.Parameters.AddWithValue("?", subtotalBase);

                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT @@IDENTITY";
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        private void InsertarAgregados(OleDbConnection conexion, OleDbTransaction transaccion, int idCliente, int idDetalle)
        {
            // 🔥 Validar que los IDs sean válidos
            if (idCliente <= 0)
            {
                MessageBox.Show($"Error: idCliente inválido ({idCliente}) para insertar agregados");
                return;
            }

            if (idDetalle <= 0)
            {
                MessageBox.Show($"Error: idDetalle inválido ({idDetalle}) para insertar agregados");
                return;
            }

            string query = @"INSERT INTO tb_detalle_agregado (id_cliente, id_detalle, nombre_agregado, precio_cobrado) 
                     VALUES (?, ?, ?, ?)";

            var aderezos = new[]
            {
        new { Nombre = "Aderezo de Papas", Precio = ObtenerValorDecimal(ade_papas.Text) },
        new { Nombre = "Aderezo de Ensaladas", Precio = ObtenerValorDecimal(ade_ensaladas.Text) },
        new { Nombre = "Aderezo de Sandwiches", Precio = ObtenerValorDecimal(ade_sandwiches.Text) },
        new { Nombre = "Aderezo de Pupusas", Precio = ObtenerValorDecimal(ade_pupusas.Text) },
        new { Nombre = "Aderezo de Panes", Precio = ObtenerValorDecimal(ade_panes.Text) },
        new { Nombre = "Aderezo de Cenas", Precio = ObtenerValorDecimal(ade_cenas.Text) },
        new { Nombre = "Aderezo de Tortas", Precio = ObtenerValorDecimal(ade_tortas.Text) }
    };

            int contador = 0;
            foreach (var aderezo in aderezos)
            {
                if (aderezo.Precio > 0)
                {
                    using (OleDbCommand cmd = new OleDbCommand(query, conexion, transaccion))
                    {
                        cmd.Parameters.AddWithValue("?", idCliente);
                        cmd.Parameters.AddWithValue("?", idDetalle);
                        cmd.Parameters.AddWithValue("?", aderezo.Nombre);
                        cmd.Parameters.AddWithValue("?", (decimal)aderezo.Precio);
                        cmd.ExecuteNonQuery();
                        contador++;
                    }
                }
            }

            if (contador > 0)
                MessageBox.Show($"Se insertaron {contador} aderezos correctamente"); // Depuración
        }

        // Métodos auxiliares para obtener cantidades
        private int ObtenerCantidadPlatillos()
        {
            int cantidad = 0;
            if (!string.IsNullOrEmpty(Almacenamiento_temporal.Pupusas))
                cantidad += Convert.ToInt32(Almacenamiento_temporal.Pupusas);
            if (!string.IsNullOrEmpty(Almacenamiento_temporal.Cena))
                cantidad += Convert.ToInt32(Almacenamiento_temporal.Cena);
            if (!string.IsNullOrEmpty(Almacenamiento_temporal.Panes))
                cantidad += Convert.ToInt32(Almacenamiento_temporal.Panes);
            if (!string.IsNullOrEmpty(Almacenamiento_temporal.Tortas))
                cantidad += Convert.ToInt32(Almacenamiento_temporal.Tortas);
            if (!string.IsNullOrEmpty(Almacenamiento_temporal.Lasaña))
                cantidad += Convert.ToInt32(Almacenamiento_temporal.Lasaña);
            if (!string.IsNullOrEmpty(Almacenamiento_temporal.Carne))
                cantidad += Convert.ToInt32(Almacenamiento_temporal.Carne);
            return cantidad;
        }

        private int ObtenerCantidadBebidas()
        {
            int cantidad = 0;
            if (!string.IsNullOrEmpty(Almacenamiento_temporal.Bebidas))
                cantidad += Convert.ToInt32(Almacenamiento_temporal.Bebidas);
            if (!string.IsNullOrEmpty(Almacenamiento_temporal.Chocolates))
                cantidad += Convert.ToInt32(Almacenamiento_temporal.Chocolates);
            if (!string.IsNullOrEmpty(Almacenamiento_temporal.Cafes))
                cantidad += Convert.ToInt32(Almacenamiento_temporal.Cafes);
            if (!string.IsNullOrEmpty(Almacenamiento_temporal.Atoles))
                cantidad += Convert.ToInt32(Almacenamiento_temporal.Atoles);
            if (!string.IsNullOrEmpty(Almacenamiento_temporal.Licuados))
                cantidad += Convert.ToInt32(Almacenamiento_temporal.Licuados);
            if (!string.IsNullOrEmpty(Almacenamiento_temporal.Tes))
                cantidad += Convert.ToInt32(Almacenamiento_temporal.Tes);
            return cantidad;
        }

        private int ObtenerCantidadEntradas()
        {
            int cantidad = 0;
            if (!string.IsNullOrEmpty(Almacenamiento_temporal.Papas))
                cantidad += Convert.ToInt32(Almacenamiento_temporal.Papas);
            if (!string.IsNullOrEmpty(Almacenamiento_temporal.Sopas))
                cantidad += Convert.ToInt32(Almacenamiento_temporal.Sopas);
            if (!string.IsNullOrEmpty(Almacenamiento_temporal.Tamales))
                cantidad += Convert.ToInt32(Almacenamiento_temporal.Tamales);
            if (!string.IsNullOrEmpty(Almacenamiento_temporal.Torrejas))
                cantidad += Convert.ToInt32(Almacenamiento_temporal.Torrejas);
            if (!string.IsNullOrEmpty(Almacenamiento_temporal.Ensaladas))
                cantidad += Convert.ToInt32(Almacenamiento_temporal.Ensaladas);
            if (!string.IsNullOrEmpty(Almacenamiento_temporal.Sandwiches))
                cantidad += Convert.ToInt32(Almacenamiento_temporal.Sandwiches);
            return cantidad;
        }

        private int ObtenerCantidadPostres()
        {
            int cantidad = 0;
            if (!string.IsNullOrEmpty(Almacenamiento_temporal.TresLeches))
                cantidad += Convert.ToInt32(Almacenamiento_temporal.TresLeches);
            if (!string.IsNullOrEmpty(Almacenamiento_temporal.Quesadillas))
                cantidad += Convert.ToInt32(Almacenamiento_temporal.Quesadillas);
            if (!string.IsNullOrEmpty(Almacenamiento_temporal.Flanes))
                cantidad += Convert.ToInt32(Almacenamiento_temporal.Flanes);
            if (!string.IsNullOrEmpty(Almacenamiento_temporal.pastel))
                cantidad += Convert.ToInt32(Almacenamiento_temporal.pastel);
            if (!string.IsNullOrEmpty(Almacenamiento_temporal.Tartaletas))
                cantidad += Convert.ToInt32(Almacenamiento_temporal.Tartaletas);
            if (!string.IsNullOrEmpty(Almacenamiento_temporal.Pastel_de_limon))
                cantidad += Convert.ToInt32(Almacenamiento_temporal.Pastel_de_limon);
            return cantidad;
        }

        private double ObtenerValorDecimal(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return 0;

            double valor;
            if (double.TryParse(texto, out valor))
                return valor;
            return 0;
        }

        private void VerPlatillosExistentes()
        {
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(ConfiguracionDB.CadenaConexion))
                {
                    conexion.Open();
                    string query = "SELECT id_platillo, nombre_platillo FROM tb_platillo";
                    using (OleDbCommand cmd = new OleDbCommand(query, conexion))
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            string mensaje = "Platillos existentes:\n";
                            while (reader.Read())
                            {
                                mensaje += $"ID: {reader["id_platillo"]} - {reader["nombre_platillo"]}\n";
                            }
                            MessageBox.Show(mensaje);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }



        /// <summary>
        /// Obtiene el ID de cualquier tabla por el nombre del producto
        /// </summary>
        /// <param name="nombreTabla">Nombre de la tabla (Bebidas, Entradas, Postres, tb_platillo)</param>
        /// <param name="nombreColumnaId">Nombre de la columna ID</param>
        /// <param name="nombreColumnaNombre">Nombre de la columna que contiene el nombre</param>
        /// <param name="nombreProducto">Nombre del producto a buscar</param>
        /// <returns>ID del producto, o 1 si no se encuentra</returns>
        private int ObtenerIdPorNombre(string nombreTabla, string nombreColumnaId, string nombreColumnaNombre, string nombreProducto)
        {
            if (string.IsNullOrEmpty(nombreProducto))
                return 1;

            string query = $"SELECT {nombreColumnaId} FROM {nombreTabla} WHERE {nombreColumnaNombre} = ?";

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(ConfiguracionDB.CadenaConexion))
                {
                    conexion.Open();
                    using (OleDbCommand cmd = new OleDbCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("?", nombreProducto);
                        object resultado = cmd.ExecuteScalar();

                        if (resultado != null && resultado != DBNull.Value)
                        {
                            int id = Convert.ToInt32(resultado);
                            return id;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener ID de {nombreTabla}: {ex.Message}");
            }

            return 1; // Valor por defecto
        }



        // Obtener ID de bebida desde la tabla Bebidas
        private int ObtenerIdBebida(string nombreBebida)
        {
            return ObtenerIdPorNombre("Bebidas", "id_bebida", "nombre", nombreBebida);
        }

        // Obtener ID de entrada desde la tabla Entradas
        private int ObtenerIdEntrada(string nombreEntrada)
        {
            return ObtenerIdPorNombre("Entradas", "id_entrada", "nombre", nombreEntrada);
        }

        // Obtener ID de postre desde la tabla Postres
        private int ObtenerIdPostre(string nombrePostre)
        {
            return ObtenerIdPorNombre("Postres", "id_postre", "nombre", nombrePostre);
        }

        // Obtener ID de platillo desde la tabla tb_platillo
        private int ObtenerIdPlatillo(string nombrePlatillo)
        {
            return ObtenerIdPorNombre("tb_platillo", "id_platillo", "nombre_platillo", nombrePlatillo);
        }




        private (int? idPlatillo, int? idBebida, int? idEntrada, int? idPostre) ObtenerIdsProductosComprados()
        {
            int? idPlatillo = null;
            int? idBebida = null;
            int? idEntrada = null;
            int? idPostre = null;

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(ConfiguracionDB.CadenaConexion))
                {
                    conexion.Open();

                    // 🔥 OBTENER PLATILLO (solo si hay cantidad)
                    if (ObtenerCantidadPlatillos() > 0)
                    {
                        string nombrePlatillo = ObtenerNombrePlatilloConCantidad();
                        if (!string.IsNullOrEmpty(nombrePlatillo))
                        {
                            string query = "SELECT id_platillo FROM tb_platillo WHERE nombre_platillo = @nombre";
                            using (OleDbCommand cmd = new OleDbCommand(query, conexion))
                            {
                                cmd.Parameters.AddWithValue("@nombre", nombrePlatillo);
                                object result = cmd.ExecuteScalar();
                                if (result != null && result != DBNull.Value)
                                {
                                    idPlatillo = Convert.ToInt32(result);
                                }
                            }
                        }
                    }

                    // 🔥 OBTENER BEBIDA (solo si hay cantidad)
                    if (ObtenerCantidadBebidas() > 0)
                    {
                        string nombreBebida = ObtenerNombreBebidaConCantidad();
                        if (!string.IsNullOrEmpty(nombreBebida))
                        {
                            string query = "SELECT id_bebida FROM Bebidas WHERE nombre_bebida = @nombre";
                            using (OleDbCommand cmd = new OleDbCommand(query, conexion))
                            {
                                cmd.Parameters.AddWithValue("@nombre", nombreBebida);
                                object result = cmd.ExecuteScalar();
                                if (result != null && result != DBNull.Value)
                                {
                                    idBebida = Convert.ToInt32(result);
                                }
                            }
                        }
                    }

                    // 🔥 OBTENER ENTRADA (solo si hay cantidad)
                    if (ObtenerCantidadEntradas() > 0)
                    {
                        string nombreEntrada = ObtenerNombreEntradaConCantidad();
                        if (!string.IsNullOrEmpty(nombreEntrada))
                        {
                            string query = "SELECT id_entrada FROM Entradas WHERE nombre_entrada = @nombre";
                            using (OleDbCommand cmd = new OleDbCommand(query, conexion))
                            {
                                cmd.Parameters.AddWithValue("@nombre", nombreEntrada);
                                object result = cmd.ExecuteScalar();
                                if (result != null && result != DBNull.Value)
                                {
                                    idEntrada = Convert.ToInt32(result);
                                }
                            }
                        }
                    }

                    // 🔥 OBTENER POSTRE (solo si hay cantidad)
                    if (ObtenerCantidadPostres() > 0)
                    {
                        string nombrePostre = ObtenerNombrePostreConCantidad();
                        if (!string.IsNullOrEmpty(nombrePostre))
                        {
                            string query = "SELECT id_postre FROM Postres WHERE nombre_postre = @nombre";
                            using (OleDbCommand cmd = new OleDbCommand(query, conexion))
                            {
                                cmd.Parameters.AddWithValue("@nombre", nombrePostre);
                                object result = cmd.ExecuteScalar();
                                if (result != null && result != DBNull.Value)
                                {
                                    idPostre = Convert.ToInt32(result);
                                }
                            }
                        }
                    }

                    // Mensaje de depuración
                    string mensaje = $"IDs encontrados:\n" +
                                    $"Platillo: {(idPlatillo.HasValue ? idPlatillo.ToString() : "NULL")}\n" +
                                    $"Bebida: {(idBebida.HasValue ? idBebida.ToString() : "NULL")}\n" +
                                    $"Entrada: {(idEntrada.HasValue ? idEntrada.ToString() : "NULL")}\n" +
                                    $"Postre: {(idPostre.HasValue ? idPostre.ToString() : "NULL")}";
                    MessageBox.Show(mensaje, "IDs obtenidos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener IDs: {ex.Message}");
            }

            return (idPlatillo, idBebida, idEntrada, idPostre);
        }
        private string ObtenerNombrePlatilloConCantidad()
        {
            if (Convert.ToInt32(Almacenamiento_temporal.Pupusas) > 0) return "Pupusas";
            if (Convert.ToInt32(Almacenamiento_temporal.Cena) > 0) return "Cena";
            if (Convert.ToInt32(Almacenamiento_temporal.Panes) > 0) return "Panes";
            if (Convert.ToInt32(Almacenamiento_temporal.Tortas) > 0) return "Tortas";
            if (Convert.ToInt32(Almacenamiento_temporal.Lasaña) > 0) return "Lasaña";
            if (Convert.ToInt32(Almacenamiento_temporal.Carne) > 0) return "Carne";
            return "";
        }

        private string ObtenerNombreBebidaConCantidad()
        {
            if (Convert.ToInt32(Almacenamiento_temporal.Bebidas) > 0) return "Bebidas enlatadas";
            if (Convert.ToInt32(Almacenamiento_temporal.Chocolates) > 0) return "Chocolate";
            if (Convert.ToInt32(Almacenamiento_temporal.Cafes) > 0) return "Café";
            if (Convert.ToInt32(Almacenamiento_temporal.Atoles) > 0) return "Atol";
            if (Convert.ToInt32(Almacenamiento_temporal.Licuados) > 0) return "Licuado";
            if (Convert.ToInt32(Almacenamiento_temporal.Tes) > 0) return "Té";
            return "";
        }

        private string ObtenerNombreEntradaConCantidad()
        {
            if (Convert.ToInt32(Almacenamiento_temporal.Papas) > 0) return "Papas";
            if (Convert.ToInt32(Almacenamiento_temporal.Sopas) > 0) return "Sopas";
            if (Convert.ToInt32(Almacenamiento_temporal.Tamales) > 0) return "Tamales";
            if (Convert.ToInt32(Almacenamiento_temporal.Torrejas) > 0) return "Torresjas"; // ⚠️ OJO: tiene typo en tu BD
            if (Convert.ToInt32(Almacenamiento_temporal.Ensaladas) > 0) return "Ensaladas";
            if (Convert.ToInt32(Almacenamiento_temporal.Sandwiches) > 0) return "Sandwiches";
            return "";
        }

        private string ObtenerNombrePostreConCantidad()
        {
            if (Convert.ToInt32(Almacenamiento_temporal.TresLeches) > 0) return "Tres Leches";
            if (Convert.ToInt32(Almacenamiento_temporal.Quesadillas) > 0) return "Quesadillas";
            if (Convert.ToInt32(Almacenamiento_temporal.Flanes) > 0) return "Flan";
            if (Convert.ToInt32(Almacenamiento_temporal.pastel) > 0) return "Pastel de chocolate";
            if (Convert.ToInt32(Almacenamiento_temporal.Tartaletas) > 0) return "Tartaleta";
            if (Convert.ToInt32(Almacenamiento_temporal.Pastel_de_limon) > 0) return "Pastel de limón";
            return "";
        }
        private void VerNombresEnTablas()
        {
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(ConfiguracionDB.CadenaConexion))
                {
                    conexion.Open();

                    // Ver Bebidas
                    string queryBebidas = "SELECT id_bebida, nombre FROM Bebidas";
                    using (OleDbCommand cmd = new OleDbCommand(queryBebidas, conexion))
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            string mensaje = "=== BEBIDAS ===\n";
                            while (reader.Read())
                            {
                                mensaje += $"ID: {reader["id_bebida"]}, Nombre: {reader["nombre"]}\n";
                            }

                            // Ver Entradas
                            string queryEntradas = "SELECT id_entrada, nombre FROM Entradas";
                            cmd.CommandText = queryEntradas;
                            using (OleDbDataReader reader2 = cmd.ExecuteReader())
                            {
                                mensaje += "\n=== ENTRADAS ===\n";
                                while (reader2.Read())
                                {
                                    mensaje += $"ID: {reader2["id_entrada"]}, Nombre: {reader2["nombre"]}\n";
                                }
                            }

                            // Ver Postres
                            string queryPostres = "SELECT id_postre, nombre FROM Postres";
                            cmd.CommandText = queryPostres;
                            using (OleDbDataReader reader3 = cmd.ExecuteReader())
                            {
                                mensaje += "\n=== POSTRES ===\n";
                                while (reader3.Read())
                                {
                                    mensaje += $"ID: {reader3["id_postre"]}, Nombre: {reader3["nombre"]}\n";
                                }
                            }

                            // Ver tb_platillo
                            string queryPlatillos = "SELECT id_platillo, nombre_platillo FROM tb_platillo";
                            cmd.CommandText = queryPlatillos;
                            using (OleDbDataReader reader4 = cmd.ExecuteReader())
                            {
                                mensaje += "\n=== PLATILLOS ===\n";
                                while (reader4.Read())
                                {
                                    mensaje += $"ID: {reader4["id_platillo"]}, Nombre: {reader4["nombre_platillo"]}\n";
                                }
                            }

                            MessageBox.Show(mensaje, "Nombres en la Base de Datos");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

    }
}
   
        
