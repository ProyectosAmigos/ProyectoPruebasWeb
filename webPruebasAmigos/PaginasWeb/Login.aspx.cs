using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql;
using MySql.Data.MySqlClient;
using MySql.Web;
using webPruebasAmigos.Clases;


namespace webPruebasAmigos.PaginasWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MySqlConnection myCon = new MySqlConnection(CWebGlobal.cadenaConexion);

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
            }
           
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection myCon = new MySqlConnection(CWebGlobal.cadenaConexion);
            MySqlCommand cmd  = new MySqlCommand("SELECT USERID,USERPASS FROM USERS WHERE USERID = '" + 
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
                    }
                }
                else
                { 
                    lblMensaje.Text = "Usuario o contraseña incorrecta";
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
            
        }
    }
}