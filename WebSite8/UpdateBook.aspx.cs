using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Configuration;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class UpdateBook : System.Web.UI.Page
{
    MySqlConnection connect = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                connect.Open();
                string book_id = Request.QueryString["id"];
                if (book_id == null)
                {
                    Response.Redirect("BookList.aspx");
                }
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM book_list WHERE book_id=@book_id;", connect);
                cmd.Parameters.AddWithValue("@book_id", book_id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtTitle.Text = reader["title"].ToString();
                    txtPublisher.Text = reader["publisher"].ToString();
                    txtAuthor.Text = reader["author"].ToString();
                    txtEdition.Text = reader["edition"].ToString();
                    txtNoofpage.Text = reader["pages"].ToString();
                    txtPrice.Text = reader["price"].ToString();
                    txtPublishDate.Text = Convert.ToDateTime(reader["publish_date"]).Date.ToString("yyyy-MM-dd");
                }
            }
            catch (MySqlException mex)
            {
                message.InnerText = "Error: " + mex.Message;
            }
            finally
            {
                connect.Close();
            }
        }
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        errTitle.InnerText = errPublisher.InnerText = errAuthor.InnerText = errEdition.InnerText = errNoofpage.InnerText = errPrice.InnerText = errPublishDate.InnerText = String.Empty;
        string book_id = Request.QueryString["id"];
        if (book_id == null)
        {
            Response.Redirect("BookList.aspx");
        }
        string title = txtTitle.Text;
        string publisher = txtPublisher.Text;
        string author = txtAuthor.Text;
        string edition = txtEdition.Text;
        string pages = txtNoofpage.Text;
        string price = txtPrice.Text;
        string publish_date = txtPublishDate.Text;

        int error = 0;
        if (String.IsNullOrEmpty(title))
        {
            errTitle.InnerText = "Please enter title.";
            error++;
        }
        if (String.IsNullOrEmpty(publisher))
        {
            errPublisher.InnerText = "Please enter publisher.";
            error++;
        }
        if (String.IsNullOrEmpty(author))
        {
            errAuthor.InnerText = "Please enter author.";
            error++;
        }
        if (String.IsNullOrEmpty(edition))
        {
            errEdition.InnerText = "Please enter edition.";
            error++;
        }
        if (String.IsNullOrEmpty(pages))
        {
            errNoofpage.InnerText = "Please enter no of pages.";
            error++;
        }
        if (String.IsNullOrEmpty(price))
        {
            errPrice.InnerText = "Please enter price.";
            error++;
        }
        if (String.IsNullOrEmpty(publish_date))
        {
            errPublishDate.InnerText = "Please enter publish date.";
            error++;
        }

        if (error == 0)
        {
            try
            {
                connect.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE book_list SET title=@title, publisher=@publisher, author=@author, edition=@edition, pages=@pages, price=@price, publish_date=@publish_date WHERE book_id=@book_id", connect);
                int no_of_pages = int.Parse(pages);
                int book_price = int.Parse(price);
                cmd.Parameters.AddWithValue("@book_id", book_id);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@publisher", publisher);
                cmd.Parameters.AddWithValue("@author", author);
                cmd.Parameters.AddWithValue("@edition", edition);
                cmd.Parameters.AddWithValue("@pages", no_of_pages);
                cmd.Parameters.AddWithValue("@price", book_price);
                cmd.Parameters.AddWithValue("@publish_date", publish_date);
                cmd.ExecuteNonQuery();
                message.InnerText = "Book updated successfully!";
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
    }
    protected void btnView_Click(object sender, EventArgs e)
    {
        Response.Redirect("BookList.aspx");
    }
}