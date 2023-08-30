using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class calculator : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (num1.Text == "" || num2.Text == "")
        {
            result.InnerText = "Please enter proper values!";
        }
        else
        {
            string n1 = num1.Text;
            string n2 = num2.Text;
            int a = int.Parse(n1);
            int b = int.Parse(n2);
            int sum = a + b;
            result.InnerText = "Result " + sum.ToString();
        }
    }
    protected void btnSubtract_Click(object sender, EventArgs e)
    {
        if (num1.Text == "" || num2.Text == "")
        {
            result.InnerText = "Please enter proper values!";
        }
        else
        {
            string n1 = num1.Text;
            string n2 = num2.Text;
            int a = int.Parse(n1);
            int b = int.Parse(n2);
            int sub = a - b;
            result.InnerText = "Result " + sub.ToString();
        }
    }
    protected void btnDivide_Click(object sender, EventArgs e)
    {
        if (num1.Text == "" || num2.Text == "")
        {
            result.InnerText = "Please enter proper values!";
        }
        else
        {
            string n1 = num1.Text;
            string n2 = num2.Text;
            int a = int.Parse(n1);
            int b = int.Parse(n2);
            int div = a / b;
            result.InnerText = "Result " + div.ToString();
        }
    }
    protected void btnMultiply_Click(object sender, EventArgs e)
    {
        if (num1.Text == "" || num2.Text == "")
        {
            result.InnerText = "Please enter proper values!";
        }
        else
        {
            string n1 = num1.Text;
            string n2 = num2.Text;
            int a = int.Parse(n1);
            int b = int.Parse(n2);
            int mul = a * b;
            result.InnerText = "Result " + mul.ToString();
        }
    }
}