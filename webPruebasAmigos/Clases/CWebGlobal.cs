using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webPruebasAmigos.Clases
{
    public static class CWebGlobal
    {
        //Inicio Cambios David 26/04/2015
        //Incorporación de Regiones         
        #region Constantes    
        //Ruta de conexión a la base de datos
        public const string cadenaConexion = "Server=85.10.205.173;Database=amigosddbb;User Id=amigo1user;Password=amigo1pass;";
    
        public const Decimal iva = 0.21m;
        #endregion
        //Fin Cambios David 26/04/2015

        public static int idPaisEspania = 1;
        //'Ruta a las imagenes que dependen del idioma
        //'Public Shared Property rutaImagenesIdioma As String = "~/imagesESP/"
        //'Public Shared Property rutaImagenesIdioma As String = "~/imagesESP/"
        public static string formateaFecha(DateTime fecha, string idioma)
        {     
           if (idioma.Contains("English") == true)
            {
                
               return fecha.ToString("MM/dd/yyyy");
            }
            else
            {
                return fecha.ToString("dd/MM/yyyy");
            }
        }
    }
}