using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Configuration;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;


public partial class Login : System.Web.UI.Page
{
    MySqlConnection connect = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string email = txtEmail.Text;
        string password = txtPassword.Text;
        if (String.IsNullOrEmpty(email) || String.IsNullOrEmpty(password))
        {
            errLogin.InnerText = "Invalid Credentials";
        }
        else
        {
            try
            {
                connect.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM students WHERE email=email AND password=password;", connect);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    Session["email"] = email;
                    Session["LoggedIn"] = true;
                    Response.Redirect("Dashboard.aspx");
                }
                else
                {
                    errLogin.InnerText = "Invalid Credentials!";
                }

            }
            catch (MySqlException mex)
            {
                errLogin.InnerText = "Login Error: " + mex.Message;
            }
            finally
            {
                connect.Close();
            }
        }

    }
}