using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Configuration;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class Register : System.Web.UI.Page
{
    MySqlConnection connect = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        errGender.InnerText = errName.InnerText = errEmail.InnerText = errPhone.InnerText = errFaculty.InnerText = errPassword1.InnerText = errPassword2.InnerText = String.Empty;
            //get form data
            string password1 = txtPassword1.Text;
            string password2 = txtPassword2.Text;
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string gender = rdoGender.Text;
            string faculty = drpFaculty.Text;
            

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
            if (String.IsNullOrEmpty(gender))
            {
                errGender.InnerText = "Choose gender";
                error++;
            }
            if (String.IsNullOrEmpty(faculty))
            {
                errFaculty.InnerText = "Choose faculty";
                error++;
            }
            if (String.IsNullOrEmpty(password1))
            {
                errPassword1.InnerText = "Enter password";
                error++;
            }
            if (String.IsNullOrEmpty(password2))
            {
                errPassword2.InnerText = "Re-type password";
                error++;
            }

            if (error == 0)
            {
                //database connection
                try
                {
                    connect.Open();
                    MySqlCommand cmd = new MySqlCommand("insert into students(name,email,phone,faculty,gender,password) values (@n,@e,@ph,@f,@g,@p)", connect);
                    cmd.Parameters.AddWithValue("@n", name);
                    cmd.Parameters.AddWithValue("@e", email);
                    cmd.Parameters.AddWithValue("@ph", phone);
                    cmd.Parameters.AddWithValue("@f", faculty);
                    cmd.Parameters.AddWithValue("@g", gender);
                    cmd.Parameters.AddWithValue("@p", password1);
                    cmd.ExecuteNonQuery();
                    error_messsage.InnerText = "Register Success";

                }
                catch (MySqlException mex)
                {
                    error_messsage.InnerText = "Error at Register Page" + mex.Message;
                }
                finally
                {
                    connect.Close();
                }
            }

        }
}
