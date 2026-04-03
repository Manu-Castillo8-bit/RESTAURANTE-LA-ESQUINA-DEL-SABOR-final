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
    public partial class Datos_papas : Form
    {
        public Datos_papas()
        {
            InitializeComponent();
        }

        private void Datos_Click(object sender, EventArgs e)
        {
            Almacenamiento_temporal.Papas = Papas_.Text;
            Calcular_aderezos();

            this.Close(); // Solo cierra, NO hace INSERT
            Entradas entradas = new Entradas(this);
            entradas.Show();
        }

        private void R_Dtos_papas_Click(object sender, EventArgs e)
        {
            this.Close(); // Solo cierra, NO hace INSERT
            Entradas entradas = new Entradas(this);
            entradas.Show();
        }

        public void Calcular_aderezos()
        {
            double Aderezo_de_papas = 0;

            // Sumar $1.50 por cada CheckBox seleccionado
            if (ketchup.Checked) Aderezo_de_papas += 1.50;
            if (salsa_tomate.Checked) Aderezo_de_papas += 1.50;
            if (pepinesa.Checked) Aderezo_de_papas += 1.50;
            if (mayonesa.Checked) Aderezo_de_papas += 1.50;
            if (salsa_aguacate.Checked) Aderezo_de_papas += 1.50;
            if (salsa_blanca.Checked) Aderezo_de_papas += 1.50;



            Almacenamiento_temporal.Ad_papas = Convert.ToString(Aderezo_de_papas);
        }

    }

}
