using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webPruebasAmigos.ClasesGenerales;
using webPruebasAmigos.Recursos.Controles_de_usuario;

namespace webPruebasAmigos.PaginasWeb
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        { 
            CSesion sesion = new CSesion();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        { 
            if (CSesion.Current._Usuario != "Anonimo" && CSesion.Current._Usuario != null)
            {
                lblHome.Text = "Bienvenido a la web de pruebas del proyecto web amigos, gracias por registrarte " + CSesion.Current._Usuario;
            }
            else
            { 
                lblHome.Text = "Bienvenido a la web de pruebas del proyecto web amigos, te invitamos a que te registres " + CSesion.Current._Usuario;
            }
        }
    }
}