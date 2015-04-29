using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.HttpContext;

namespace webPruebasAmigos.Clases
{
    public class CSesion
    {
        //Declaración VariablesPrivadas(Atributos)
        private String      Usuario;
        private DateTime    FechaCreacion;
        private int         SesionID;
        
        //Declaración de propiedades
        #region Propiedades

        //Propiedad para cadena de texto
        public string _Usuario
        {
            get
            {
                return _Usuario;
            } 
            set
            {
                this.Usuario = _Usuario;
            }
        }

        //Propiedad para fecha
        public DateTime _FechaCreacion
        {
            get
            {
                return DateTime.Now;
            } 
            set
            {
                this.FechaCreacion = _FechaCreacion;
            }
        }

        //Propiedad para int
        public int _SesionID
        {
            get
            {
                return _SesionID;
            }
            set
            {
                this.SesionID = _SesionID;
            }
        }

        #endregion

        //Declaracion de contructores
        #region Constructores

        private CSesion()
        {
            _Usuario = "Usuario por defecto";
            _FechaCreacion = DateTime.Now;
            _SesionID = 1;
        }
        #endregion
        // Gets the current session.
        public static CSesion Current
        {
            get
            {
                CSesion session = (CSesion)HttpContext.Current.Session["SesionActiva"];
                if (session == null)
                {
                    session = new CSesion();
                    HttpContext.Current.Session["SesionActiva"] = session;
                }
                return session;
            }
        }

    }  
}