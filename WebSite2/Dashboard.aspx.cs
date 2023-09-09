using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dashboard : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            Response.Redirect("Login.aspx");
        }else{
            HttpCookie cookie = Request.Cookies["userinfo"];
            if(cookie != null){
                string cookieUser = cookie.Value;
                greetUser.InnerText = "Welcome back "+cookieUser;
            }
        }
    }
    protected void btnLogout_Click(object sender, EventArgs e)
    {
        //remove session
        Session.Clear();
        Response.Redirect("Login.aspx");
    }
}
