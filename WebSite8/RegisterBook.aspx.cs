using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using MySql.Data.MySqlClient;

public partial class RegisterBook : System.Web.UI.Page
{
    MySqlConnection connect = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        errBookid.InnerText = errTitle.InnerText = errPublisher.InnerText = errAuthor.InnerText = errEdition.InnerText = errNoofpage.InnerText = errPrice.InnerText = errPublishDate.InnerText = String.Empty;
        string book_id = txtBookid.Text;
        string title = txtTitle.Text;
        string publisher = txtPublisher.Text;
        string author = txtAuthor.Text;
        string edition = txtEdition.Text;
        string pages = txtNoofpage.Text;
        string price = txtPrice.Text;
        string publish_date = txtPublishDate.Text;

        int error = 0;
        if (String.IsNullOrEmpty(book_id))
        {
            errBookid.InnerText = "Please enter book id.";
            error++;
        }
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
            try{
                connect.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO book_list(book_id, title, publisher, author, edition, pages, price, publish_date) VALUES (@book_id, @title, @publisher, @author, @edition, @pages, @price, @publish_date)", connect);
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
                message.InnerText = "Book Registered Successfully!";
            }catch (MySqlException mex){
                message.InnerText = "Register Error: "+mex.Message;
            }finally{
                connect.Close();
            }
        }

    }
    protected void btnView_Click(object sender, EventArgs e)
    {
        Response.Redirect("BookList.aspx");
    }
}