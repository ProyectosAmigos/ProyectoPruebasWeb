﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webPruebasAmigos.Clases
{
    public static class CWebGlobal
    {
        
    
    //Ruta de conexión a la base de datos
    public const string cadenaConexion = "Server=85.10.205.173;Database=amigosddbb;User Id=amigo1user;Password=amigo1pass;";
    
    public const Decimal iva = 0.21m;

    public static int idPaisEspania = 1;

    //'Ruta a las imagenes que dependen del idioma
    //'Public Shared Property rutaImagenesIdioma As String = "~/imagesESP/"

    /*public static fun formateaFecha(fecha As Date, idioma As String) As String
        If idioma.Contains("English") Then
            Return Format(fecha, "MM/dd/yyyy")
        Else
            Return Format(fecha, "dd/MM/yyyy")
        End If
    End Function*/
    }

}