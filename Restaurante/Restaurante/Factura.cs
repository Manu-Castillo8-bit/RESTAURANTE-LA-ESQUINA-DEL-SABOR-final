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

        private void R_f_m_Click(object sender, EventArgs e)
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


       



        private void Calcular_total_Click(object sender, EventArgs e)
        {

            // Primero asegurarse de que los cálculos estén hechos
            if (string.IsNullOrEmpty(precio_final.Text) || precio_final.Text == "0")
            {
                MessageBox.Show("Primero calcule el total antes de generar la factura",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GenerarFacturaTXT();



/*
            try
            {
                string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Desktop\Etapa de informarse\Usuarios.accdb;";


                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = @"INSERT INTO Ventas 
                            ([Dólares de pupusas], [Cena], [Panes con pollo], [Tortas], [Bebidas enlatadas],
                             [Chocolates], [Cafés], [Atoles], [Tres leches], [Quesadillas], [Flanes], [Pastel de chocolate]) 
                            VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    {
                        double pupusas, cena, panes, torta, soda, chocolate, cafe, atol, leches, quesadilla, pastel_chocolate, flan;

                        pupusas = Convert.ToDouble( Almacenamiento_temporal.Pupusas);
                        cena = Convert.ToDouble(Almacenamiento_temporal.Cena);
                        panes= Convert.ToDouble(Almacenamiento_temporal.Panes);
                        torta = Convert.ToDouble(Almacenamiento_temporal.Tortas);
                        soda = Convert.ToDouble(Almacenamiento_temporal.Bebidas);
                        cafe = Convert.ToDouble(Almacenamiento_temporal.Cafes);
                        chocolate = Convert.ToDouble(Almacenamiento_temporal.Chocolates);
                        atol = Convert.ToDouble(Almacenamiento_temporal.Atoles);
                        leches = Convert.ToDouble(Almacenamiento_temporal.TresLeches);
                        quesadilla = Convert.ToDouble(Almacenamiento_temporal.Quesadillas);
                        pastel_chocolate = Convert.ToDouble(Almacenamiento_temporal.pastel);
                        flan = Convert.ToDouble(Almacenamiento_temporal.Flanes);

                        comando.Parameters.AddWithValue("?",Convert.ToDouble(pupusas*1.00));
                        comando.Parameters.AddWithValue("?",Convert.ToDouble( cena*3.50));
                        comando.Parameters.AddWithValue("?", Convert.ToDouble(panes*1.50));
                        comando.Parameters.AddWithValue("?", Convert.ToDouble(torta*2.00));
                        comando.Parameters.AddWithValue("?",Convert.ToDouble( soda*1.00));
                        comando.Parameters.AddWithValue("?", Convert.ToDouble(chocolate * 1.00));
                        comando.Parameters.AddWithValue("?", Convert.ToDouble(cafe * 1.00));
                        comando.Parameters.AddWithValue("?", Convert.ToDouble(atol * 1.00));
                        comando.Parameters.AddWithValue("?", Convert.ToDouble(leches*3.00));
                        comando.Parameters.AddWithValue("?", Convert.ToDouble(quesadilla*2.00));
                        comando.Parameters.AddWithValue("?", Convert.ToDouble(flan*1.50));
                        comando.Parameters.AddWithValue("?", Convert.ToDouble(pastel_chocolate*3.50));

                        int resultado = comando.ExecuteNonQuery();

                        if (resultado > 0)
                        {
                            MessageBox.Show("Venta guardada correctamente ");
                            Almacenamiento_temporal.Limpiar(); // Limpiar para la próxima venta
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }*/

        }

        private void Total_Click(object sender, EventArgs e)
        {
            //ENTRADAS

            double papas = Convert.ToDouble(Almacenamiento_temporal.Papas);
            double sopas = Convert.ToDouble(Almacenamiento_temporal.Sopas);
            double tamales = Convert.ToDouble(Almacenamiento_temporal.Tamales);
            double torrejas = Convert.ToDouble(Almacenamiento_temporal.Torrejas);
            double ensalada = Convert.ToDouble(Almacenamiento_temporal.Ensaladas);
            double sandwich = Convert.ToDouble(Almacenamiento_temporal.Sandwiches);
            double ad_papas = Convert.ToDouble(Almacenamiento_temporal.Ad_papas);
            double ad_ensaladas = Convert.ToDouble(Almacenamiento_temporal.Ad_ensaladas);
            double ad_sandwiches = Convert.ToDouble(Almacenamiento_temporal.Ad_sandwiches);



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



            //...................................................................................................................................



            // PLATILLOS

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

            double total_platillos = pupusas_mas_ade + cena_mas_ade + panes_mas_ade + tortas_mas_ade + p_lasaña + p_carne;

            //......................................................................................................................

            // BEBIDAS

            double soda = Convert.ToDouble(Almacenamiento_temporal.Bebidas);
            double chocolate = Convert.ToDouble(Almacenamiento_temporal.Chocolates);
            double cafe = Convert.ToDouble(Almacenamiento_temporal.Cafes);
            double atol = Convert.ToDouble(Almacenamiento_temporal.Atoles);
            double licuado = Convert.ToDouble(Almacenamiento_temporal.Licuados);
            double te = Convert.ToDouble(Almacenamiento_temporal.Tes);

            double p_soda = soda * 1.00;
            double p_chocolate = chocolate * 1.00;
            double p_cafe = cafe * 1.00;
            double p_atol = atol * 1.00;
            double p_licuado = licuado * 1.00;
            double p_te = te * 1.00;

            soda_f.Text = Convert.ToString(p_soda);
            chocolate_f.Text = Convert.ToString(p_chocolate);
            cafe_f.Text = Convert.ToString(p_cafe);
            atol_f.Text = Convert.ToString(p_atol);
            licuado_f.Text = Convert.ToString(p_licuado);
            te_f.Text =Convert.ToString(p_te);

            double total_bebidas = ((soda * 1.00) + chocolate * 1.00 + cafe * 1.00 + atol * 1.00 + licuado * 1.00 + te * 1.00);

            //......................................................................................................................


            //POSTRES

            double tres_l = Convert.ToDouble(Almacenamiento_temporal.TresLeches);
            double quesadillas = Convert.ToDouble(Almacenamiento_temporal.Quesadillas);
            double flan = Convert.ToDouble(Almacenamiento_temporal.Flanes);
            double pastel = Convert.ToDouble(Almacenamiento_temporal.pastel);
            double tartaleta = Convert.ToDouble(Almacenamiento_temporal.Tartaletas);
            double pastel_li = Convert.ToDouble(Almacenamiento_temporal.Pastel_de_limon);

            double p_tres_l = tres_l * 3.00;
            double p_quesadillas = quesadillas * 2.00;
            double p_flan = flan * 1.50;
            double p_pastel = pastel * 3.50;
            double p_tartaleta = tartaleta * 1.50;
            double p_pastel_li = pastel_li * 3.50;

            tres_l_f.Text = Convert.ToString(p_tres_l);
            quesadillas_f.Text = Convert.ToString(p_quesadillas);
            flan_f.Text = Convert.ToString(p_flan);
            pastel_f.Text = Convert.ToString(p_pastel);
            tartaleta_f.Text = Convert.ToString(p_tartaleta);
            pastel_li_f.Text = Convert.ToString(p_pastel_li);

            double total_postres = (tres_l * 3.00) + quesadillas * 2.00 + flan * 1.50 + pastel * 3.50 + tartaleta * 1.50 + pastel_li * 3.50;










           textBox14.Text= papas_mas_ade.ToString("F2");
            textBox13.Text = p_sopas.ToString("F2");
            textBox12.Text = p_tamales.ToString("F2");
            textBox10.Text = p_torrejas.ToString("F2");
            textBox6.Text =ensalada_mas_ade.ToString("F2"); 
            textBox2.Text =sandwich_mas_ade.ToString("F2");

            a.Text = pupusas_mas_ade.ToString("F2");
            b.Text = cena_mas_ade.ToString("F2");
            c.Text = panes_mas_ade.ToString("F2");
            d.Text = tortas_mas_ade.ToString("F2");
            textBox1.Text = p_lasaña.ToString("F2");
            textBox3.Text = p_carne.ToString("F2");

            e_.Text = p_soda.ToString("F2");
            f.Text = p_chocolate.ToString("F2");
            g.Text = p_cafe.ToString("F2");
            h.Text = p_atol.ToString("F2");
            textBox5.Text = p_licuado.ToString("F2");
            textBox7.Text = p_te.ToString("F2");


            i.Text=p_tres_l.ToString("F2");
            j.Text=p_quesadillas.ToString("F2");
            k.Text=p_flan.ToString("F2");
            l.Text=p_pastel.ToString("F2");
            textBox9.Text = p_tartaleta.ToString("F2");
            textBox11.Text = p_pastel_li.ToString("F2");




















            t_entradas.Text = Convert.ToString(total_entradas);
            t_platillos.Text = Convert.ToString(total_platillos);
            t_bebidas.Text = Convert.ToString(total_bebidas);
            t_postres.Text = Convert.ToString(total_postres);

            precio_final.Text = Convert.ToString(total_entradas+total_platillos+ total_bebidas + total_postres);

            Calcular_total.Visible = true;
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

        private void GenerarFacturaTXT()
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
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

            // ========== ENTRADAS ==========
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

            // ========== PLATILLOS ==========
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

            // ========== BEBIDAS ==========
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

            // ========== POSTRES ==========
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
    }
}
