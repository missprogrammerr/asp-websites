using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //reset error message
        errPassword.InnerText = errUsername.InnerText = String.Empty;
        //check username for empty and null value
        if (String.IsNullOrEmpty(txtUsername.Text)) {
            errUsername.InnerText = "Please enter username";
        }
        //check password for empty and null value
        if (String.IsNullOrEmpty(txtPassword.Text)) {
            errPassword.InnerText = "Please enter password";
        }
    }
}