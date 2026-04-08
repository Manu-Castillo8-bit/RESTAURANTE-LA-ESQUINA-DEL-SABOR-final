/*using System;
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
*/

using System;
using System.Deployment.Application;
using System.IO;
using System.Windows.Forms;

namespace Restaurante
{
    public static class ConfiguracionDB
    {
        // Cadena de conexión usando |DataDirectory|
        public static string CadenaConexion
        {
            get
            {
                return $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\La esquina del sabor new.accdb;";
            }
        }

        // Método para verificar si la BD existe en el DataDirectory
        public static bool ValidarBaseDatos()
        {
            // Construye la ruta real de la carpeta de datos
            string rutaDataDirectory = AppDomain.CurrentDomain.GetData("DataDirectory") as string;
            string rutaCompletaBD = Path.Combine(rutaDataDirectory, "La esquina del sabor new.accdb");

            if (!File.Exists(rutaCompletaBD))
            {
                MessageBox.Show(
                    $"No se encontró la base de datos en:\n{rutaCompletaBD}\n\n" +
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