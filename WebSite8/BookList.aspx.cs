using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

public partial class BookList : System.Web.UI.Page
{
    MySqlConnection connect = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        getDataForGrid();
    }
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        string book_id = txtBookid.Text;
        Response.Redirect("UpdateBook.aspx?id=" + book_id);
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        int deleteId = int.Parse(txtBookid.Text);
        try
        {
            connect.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM book_list WHERE book_id=@book_id;", connect);
            cmd.Parameters.AddWithValue("@book_id", deleteId);
            cmd.ExecuteNonQuery();
            message.InnerText = "Book deleted successfully!";
            getDataForGrid();
            txtBookid.Text = "";
        }
        catch (MySqlException mex)
        {
            message.InnerText = "Update Error: " + mex.Message;
        }
        finally
        {
            connect.Close();
        }

    }
    private void getDataForGrid()
    {
        using (connect)
        {
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM book_list"))
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter())
                {
                    cmd.Connection = connect;
                    da.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        gridListBooks.DataSource = dt;
                        gridListBooks.DataBind();
                    }
                }
            }
        }
    }
}