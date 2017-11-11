using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebProject
{
    public partial class BooksForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string sqlDB = "ConnectionString";
            if (!this.IsPostBack)
            {
                string connectionString =
                     WebConfigurationManager.ConnectionStrings[sqlDB].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionString);
                string querySQL = "SELECT * FROM Books;";
                try
                {
                    using (SqlConnection connect = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(querySQL, connection))
                        {
                            using (SqlDataAdapter setData = new SqlDataAdapter())
                            {
                                command.Connection = connection;
                                setData.SelectCommand = command;
                                using (DataSet dataSet = new DataSet())
                                {
                                    setData.Fill(dataSet);
                                    repeaterBook.DataSource = dataSet.Tables[0];
                                    repeaterBook.DataBind();
                                }
                            }
                        }
                    }
                }
                catch 
                {
                    if (Context.Error is FormatException)
                    {
                        Response.Redirect(string.Format
                            ("/ComponentError.aspx?errorSource={0}&errorType={1}",
                            Request.Path,
                            Context.Error.GetType()));
                    }
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        protected void RepeaterItemDataBound(object sender, RepeaterItemEventArgs e)
        {
                        
        }
    }
}