using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    public static class Almacenamiento_temporal
    {
        public static string Papas { get; set; } = "0";
        public static string Sopas { get; set; } = "0";
        public static string Tamales { get; set; } = "0";
        public static string Torrejas { get; set; } = "0";
        public static string Ensaladas { get; set; } = "0";
        public static string Sandwiches { get; set; } = "0";


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
        public static string Tartaletas { get; set; } = "0";
        public static string Pastel_de_limon { get; set; } = "0";

        public static void Limpiar()
        {
            Papas = "0";
            Sopas = "0";
            Tamales = "0";
            Torrejas = "0";
            Ensaladas = "0";
            Sandwiches = "0";

            Pupusas = "0";
            Cena = "0";
            Panes = "0";
            Tortas = "0";
            Lasaña = "0";
            Carne= "0";

            Bebidas = "0";
            Chocolates = "0";
            Cafes = "0";
            Atoles = "0";
            Licuados= "0";
            Tes= "0";

            TresLeches = "0";
            Quesadillas = "0";
            Flanes = "0";
            pastel = "0";
            Tartaletas = "0";
            Pastel_de_limon = "0";
        }
    }
}
