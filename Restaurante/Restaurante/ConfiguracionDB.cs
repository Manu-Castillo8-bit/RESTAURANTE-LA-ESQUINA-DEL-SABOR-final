using System;
using System.IO;
using System.Windows.Forms;

namespace Restaurante
{
    public static class ConfiguracionDB
    {
        // Propiedad para obtener la ruta correcta de la BD
        public static string RutaBaseDatos
        {
            get
            {
                string nombreBD = "La esquina del sabor new.accdb";
                string rutaData = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", nombreBD);
                string rutaRaiz = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nombreBD);

                if (File.Exists(rutaData))
                    return rutaData;
                else
                    return rutaRaiz;
            }
        }

        // Cadena de conexión dinámica
        public static string CadenaConexion
        {
            get
            {
                return $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={RutaBaseDatos};";
            }
        }

        // Método para verificar si la BD existe
        public static bool ValidarBaseDatos()
        {
            if (!File.Exists(RutaBaseDatos))
            {
                MessageBox.Show(
                    $"No se encontró la base de datos en:\n{RutaBaseDatos}\n\n" +
                    "Asegúrate de que el archivo 'La esquina del sabor new.accdb' esté en la carpeta Data",
                    "Error de Base de Datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
