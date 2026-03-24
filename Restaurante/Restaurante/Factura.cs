using System;
using System.Data.OleDb;
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

        // Constructor unificado: recibe ambos valores (opcionales)
        /*public Factura(string valorPupusas = null, string valorCenas = null, string valorPanes=null, string valorTortas=null, string valorSoda=null, string valorChocolate = null, string valorCafe=null, string valorAtol=null, string valor_tres_leches=null, string valorQuesadillas=null, string valorFlan=null, string valorPastel=null)
        {
            InitializeComponent();
            string pupusasRecibidas = valorPupusas;
            cenasRecibidas = valorCenas;
            panesRecibidos = valorPanes;
            tortasRecibidas = valorTortas;

            sodasRecibidas= valorSoda;
            chocolatesRecibidos = valorChocolate;
            cafesRecibidos = valorCafe;
            atolesRecibidos = valorAtol;

            tres_leches_Recibidos = valor_tres_leches;
            quesadillasRecibidas = valorQuesadillas;
            flanesRecibidos = valorFlan;
            pastelesRecibidos = valorPastel;
        }*/


        private void R_f_m_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menú newForm = new Menú();
            newForm.Show();
        }

        private void Calcular_total_Click(object sender, EventArgs e)
        {
            /*pupusas_f.Text = pupusasRecibidas;
            cena_f.Text = cenasRecibidas;
            panes_f.Text = panesRecibidos;
            torta_f.Text = tortasRecibidas;

            soda_f.Text = sodasRecibidas;
            chocolate_f.Text = chocolatesRecibidos;
            cafe_f.Text = cafesRecibidos;
            atol_f.Text = atolesRecibidos;

            tres_l_f.Text = tres_leches_Recibidos;
            quesadillas_f.Text = quesadillasRecibidas;
            flan_f.Text = flanesRecibidos;
            pastel_f.Text = pastelesRecibidos;*/




            /*double pupusas, cena = 0, panes = 0, torta = 0;
            double soda = 0, chocolate = 0, cafe = 0, atol = 0;
            double t_l = 0, quesadillas = 0, flan = 0, pastel = 0;

            double.TryParse(pupusas_f.Text, out pupusas);
            double.TryParse(cena_f.Text, out cena);
            double.TryParse(panes_f.Text, out panes);
            double.TryParse(torta_f.Text, out torta);

            double.TryParse(soda_f.Text, out soda);
            double.TryParse(chocolate_f.Text, out chocolate);
            double.TryParse(cafe_f.Text, out cafe);
            double.TryParse(atol_f.Text, out atol);

            double.TryParse(tres_l_f.Text, out t_l);
            double.TryParse(quesadillas_f.Text, out quesadillas);
            double.TryParse(flan_f.Text, out flan);
            double.TryParse(pastel_f.Text, out pastel);

            double total_platillos = pupusas * 1.00 + cena * 3.50 + panes * 1.50 + torta * 2.00;

            t_platillos.Text = total_platillos.ToString("F2");*/

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
            }

        }

        private void Total_Click(object sender, EventArgs e)
        {

            // PLATILLOS
            pupusas_f.Text = Almacenamiento_temporal.Pupusas;
            cena_f.Text = Almacenamiento_temporal.Cena;
            panes_f.Text = Almacenamiento_temporal.Panes;
            torta_f.Text = Almacenamiento_temporal.Tortas;
            lasaña_f.Text = Almacenamiento_temporal.Lasaña;
            carne_f.Text = Almacenamiento_temporal.Carne;

            double pupusas = Convert.ToDouble(Almacenamiento_temporal.Pupusas);
            double cena = Convert.ToDouble(Almacenamiento_temporal.Cena);
            double panes = Convert.ToDouble(Almacenamiento_temporal.Panes);
            double tortas = Convert.ToDouble(Almacenamiento_temporal.Tortas);
            double lasaña = Convert.ToDouble(Almacenamiento_temporal.Lasaña);
            double carne = Convert.ToDouble(Almacenamiento_temporal.Carne);

            double p_pupusas= pupusas * 1.00;
            double p_cena= cena * 3.50;
            double p_panes= panes * 1.50;
            double p_tortas= tortas * 2.00;
            double p_lasaña = lasaña * 1.50;
            double p_carne = carne * 1.50;

            double total_platillos = pupusas * 1.00 + cena * 3.50 + panes * 1.50 + tortas * 2.00 + lasaña*1.50 + carne*1.50;


            // BEBIDAS
            soda_f.Text = Almacenamiento_temporal.Bebidas;
            chocolate_f.Text = Almacenamiento_temporal.Chocolates;
            cafe_f.Text = Almacenamiento_temporal.Cafes;
            atol_f.Text = Almacenamiento_temporal.Atoles;
            licuado_f.Text = Almacenamiento_temporal.Licuados;
            te_f.Text = Almacenamiento_temporal.Tes;

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

            double total_bebidas = (soda * 1.00 + chocolate * 1.00 + cafe * 1.00 + atol * 1.00 + licuado * 1.00 + te * 1.00);


            //POSTRES

            tres_l_f.Text = Almacenamiento_temporal.TresLeches;
            quesadillas_f.Text = Almacenamiento_temporal.Quesadillas;
            flan_f.Text = Almacenamiento_temporal.Flanes;
            pastel_f.Text = Almacenamiento_temporal.pastel;
            tartaleta_f.Text = Almacenamiento_temporal.pastel;
            pastel_li_f.Text = Almacenamiento_temporal.pastel;

            double tres_l = Convert.ToDouble(Almacenamiento_temporal.TresLeches);
            double quesadillas = Convert.ToDouble(Almacenamiento_temporal.Quesadillas);
            double flan = Convert.ToDouble(Almacenamiento_temporal.Flanes);
            double pastel = Convert.ToDouble(Almacenamiento_temporal.pastel);
            double tartaleta = Convert.ToDouble(Almacenamiento_temporal.pastel);
            double pastel_li = Convert.ToDouble(Almacenamiento_temporal.pastel);

            double p_tres_l = tres_l * 3.00;
            double p_quesadillas = quesadillas * 2.00;
            double p_flan = flan * 1.50;
            double p_pastel = pastel * 3.50;
            double p_tartaleta = tartaleta * 1.50;
            double p_pastel_li = pastel_li * 3.50;

            double total_postres = tres_l * 3.00 + quesadillas * 2.00 + flan * 1.50 + pastel * 3.50 + tartaleta* 1.50 + pastel_li *3.50 ;

            a.Text=p_pupusas.ToString("F2");
            b.Text=p_cena.ToString("F2");
            c.Text=p_panes.ToString("F2");
            d.Text=p_tortas.ToString("F2");
            textBox1.Text=p_lasaña.ToString("F2");
            textBox3.Text=p_carne.ToString("F2");

            e_.Text=p_soda.ToString("F2");
            f.Text=p_chocolate.ToString("F2");
            g.Text=p_cafe.ToString("F2");
            h.Text=p_atol.ToString("F2");
            i.Text=p_tres_l.ToString("F2");
            j.Text=p_quesadillas.ToString("F2");
            k.Text=p_flan.ToString("F2");
            l.Text=p_pastel.ToString("F2");

            t_platillos.Text = Convert.ToString(total_platillos);
            t_bebidas.Text = Convert.ToString(total_bebidas);
            t_postres.Text = Convert.ToString(total_postres);

            precio_final.Text = Convert.ToString(total_platillos+ total_bebidas + total_postres);

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
    }
}
