using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class simple_intrest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnResult_Click(object sender, EventArgs e)
    {
        if (txtPrincipal.Text == "" || txtTime.Text == "" || txtRate.Text == "")
        {
            errResult.InnerText = "Please enter proper values!";
        }
        else
        {
            errResult.InnerText = "";
            string principal = txtPrincipal.Text;
            string time = txtTime.Text;
            string rate = txtRate.Text;
            int p = int.Parse(principal);
            int t = int.Parse(time);
            int r = int.Parse(rate);
            int si = (p * t * r) / 100;
            int total = p + si;
            intrest.InnerText = "Intrest: "+si.ToString();
            totalplusintrest.InnerText = "Total plus intrest: "+total.ToString();
        }
    }
}