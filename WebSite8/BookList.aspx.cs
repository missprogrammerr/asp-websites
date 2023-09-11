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

    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {

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