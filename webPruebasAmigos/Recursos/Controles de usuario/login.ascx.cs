using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using webPruebasAmigos.Clases;
using MySql.Data.MySqlClient;

namespace webPruebasAmigos.Recursos.Controles_de_usuario
{
    public partial class login : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          //Comprobación establecer conexión
           /*MySqlConnection myCon = new MySqlConnection(CWebGlobal.cadenaConexion);

            try
            {
                myCon.Open();
                lblMensaje.Text = "Correcto";
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
            finally
            {
                myCon.Close();
            }*/
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            CSesion sesion = new CSesion();
            MySqlConnection myCon = new MySqlConnection(CWebGlobal.cadenaConexion);
            MySqlCommand cmd = new MySqlCommand("SELECT USERID,USERPASS FROM USERS WHERE USERID = '" +
                txtUserName.Text + "' AND USERPASS = '" + txtUserPassword.Text + "'", myCon);
            MySqlDataReader drResultado;
            MySqlDataAdapter da = new MySqlDataAdapter();
            try
            {
                myCon.Open();
                drResultado = cmd.ExecuteReader();
                if (drResultado.HasRows == true)
                {
                    if (drResultado.Read())
                    {
                        lblMensaje.Text = "Bienvenido usuario " + drResultado.GetString("USERID");
                        CSesion.Current._SesionID = 2;
                        CSesion.Current._Usuario = drResultado.GetString("USERID");
                        CSesion.Current._FechaCreacion = DateTime.UtcNow;
                    }
                }
                else
                {
                    lblMensaje.Text = "Usuario o contraseña incorrecta";
                    CSesion.Current._SesionID = sesion._SesionID;
                    CSesion.Current._Usuario = sesion._Usuario;
                    CSesion.Current._FechaCreacion = sesion._FechaCreacion;
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

    }
}