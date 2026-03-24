using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    public static class Almacenamiento_temporal
    {
        public static string Pupusas { get; set; } = "0";
        public static string Cena { get; set; } = "0";
        public static string Panes { get; set; } = "0";
        public static string Tortas { get; set; } = "0";
        public static string Lasaña { get; set; } = "0";
        public static string Carne { get; set; } = "0";


        public static string Bebidas { get; set; } = "0";
        public static string Chocolates { get; set; } = "0";
        public static string Cafes { get; set; } = "0";
        public static string Atoles { get; set; } = "0";
        public static string Licuados { get; set; } = "0";
        public static string Tes { get; set; } = "0";


        public static string TresLeches { get; set; } = "0";
        public static string Quesadillas { get; set; } = "0";
        public static string Flanes { get; set; } = "0";
        public static string pastel { get; set; } = "0";

        public static void Limpiar()
        {
            Pupusas = "0";
            Cena = "0";
            Panes = "0";
            Tortas = "0";
            Lasaña = "0";

            Bebidas = "0";
            Chocolates = "0";
            Cafes = "0";
            Atoles = "0";
            TresLeches = "0";
            Quesadillas = "0";
        }
    }
}
