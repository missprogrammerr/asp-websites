using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace PNCWebAPP1
{
    public partial class Register : System.Web.UI.Page
    {
        private string conn;
        private MySqlConnection connect;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            errGender.InnerText = errName.InnerText = errEmail.InnerText = errPhone.InnerText = errAddress.InnerText = errUsername.InnerText = errPassword.InnerText = String.Empty;
            //get form data
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            string gender = rdoGender.Text;

            int error = 0;
            if (String.IsNullOrEmpty(name))
            {
                errName.InnerText = "Enter name";
                error++;
            }
            if (String.IsNullOrEmpty(email))
            {
                errEmail.InnerText = "Enter email";
                error++;
            }
            if (String.IsNullOrEmpty(phone))
            {
                errPhone.InnerText = "Enter phone";
                error++;
            }
            if (String.IsNullOrEmpty(address))
            {
                errAddress.InnerText = "Enter address";
                error++;
            }
            if (String.IsNullOrEmpty(gender))
            {
                errGender.InnerText = "Enter gender";
                error++;
            }
            if (String.IsNullOrEmpty(username))
            {
                errUsername.InnerText = "Enter uername";
                error++;
            }
            if (password == "")
            {
                errPassword.InnerText = "Enter password";
                error++;
            }

            if (error == 0)
            {
                //database connection
                try
                {
                    conn = "Server=localhost;Database=college;Uid=root;Pwd=;";
                    connect = new MySqlConnection(conn);
                    connect.Open();
                    MySqlCommand cmd = new MySqlCommand("insert into students(name,email,phone,address,gender,username,password,status) values (@n,@e,@ph,@a,@g,@u,@p,@s)", connect);
                    cmd.Parameters.AddWithValue("@n", name);
                    cmd.Parameters.AddWithValue("@e", email);
                    cmd.Parameters.AddWithValue("@ph", phone);
                    cmd.Parameters.AddWithValue("@a", address);
                    cmd.Parameters.AddWithValue("@g", gender);
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", password);
                    cmd.Parameters.AddWithValue("@s", true);
                    cmd.ExecuteNonQuery();
                    error_messsage.InnerText = "Register Success";

                }
                catch (MySqlException mex)
                {
                    error_messsage.InnerText = "Error at Register Page" + mex.Message;
                }
            }

        }
    }
}