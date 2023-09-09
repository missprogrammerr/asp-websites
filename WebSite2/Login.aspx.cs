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
        //get username and password
        string username = txtUsername.Text;
        string password = txtPassword.Text;
        int errCount = 0;
        //reset error message
        errPassword.InnerText = errUsername.InnerText = String.Empty;
        //check username for empty and null value
        if (String.IsNullOrEmpty(txtUsername.Text)) {
            errCount++;
            errUsername.InnerText = "Please enter username";
        }
        //check password for empty and null value
        if (String.IsNullOrEmpty(txtPassword.Text)) {
            errCount++;
            errPassword.InnerText = "Please enter password";
        }
        if (errCount == 0)
        {
            if (username == "astra" && password == "paradox")
            {   //store data into session
                Session.Add("username", username);

                //store data into cookie
                HttpCookie cookie = new HttpCookie("userinfo");
                cookie.Value = username;
                cookie.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(cookie);

                Response.Redirect("Dashboard.aspx");
            }
            else
            {
                errLogin.InnerText = "Login failed!";
            }
        }
    }
}
