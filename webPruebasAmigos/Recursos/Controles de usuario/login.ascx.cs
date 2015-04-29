using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using webPruebasAmigos.Clases;

namespace webPruebasAmigos.Recursos.Controles_de_usuario
{
    public partial class login : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (CSesion.clienteAutentificado.idCliente > 0)
            {
                lblLogin.Text = GetGlobalResourceObject("GlobalLocalMessages", "lblLoginCorrecto").ToString() + ", " & CSesion.clienteAutentificado.email;
                base.btnLogin.Text = GetGlobalResourceObject("GlobalLocalMessages", "btnLogin").ToString();
            }
            else
            {
                //lblLogin.Text = "Introduzca su email y contraseña."
                //Me.btnLogin.Text = "Entrar"
            }
        }


    }
}