using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebProject.Books
{
    public class Database
    {
        private string querySQL = "";
        private static string sqlDB = "ConnectionString";
        static string connectionString = WebConfigurationManager.ConnectionStrings[sqlDB].ConnectionString;
        static SqlConnection connection = new SqlConnection(connectionString);
        private int id;

        public void viewData(Page page, Repeater repeaterBook)
        {
            if (!page.IsPostBack)
            {
                querySQL = "SELECT * FROM Books;";
                connectDB(page, repeaterBook, querySQL);
            }
        }

        public void deleteString()
        {
            deleteData(id);
        }

        public void insertQuery(Page page, Repeater repeaterBook, TextBox Title, TextBox Genre, TextBox Release, TextBox Author)
        {
            string title = Convert.ToString(Title.Text), genre = Convert.ToString(Genre.Text), release = Convert.ToString(Release.Text);
            string author = Convert.ToString(Author.Text);
            querySQL = "INSERT INTO Books(Book_title, Book_genre, Book_release, Book_author)" + " VALUES('" + title + "', '" + genre + "', '" + release + "', '" + author + "');";
            querySQL += " select * from Books";
            connectDB(page, repeaterBook, querySQL);
        }

        public void connectDB(Page page,Repeater repeaterBook, string query)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
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
            catch (Exception exception)
            {
                page.Response.Write("Произошла ошибка " + exception.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void deleteData(int ID)
        {
            this.id = ID;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(@"Delete from Book 
                                                     Where ID = @ID", con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        public static void insertData(Page page, TextBox Title, TextBox Genre, TextBox Release, TextBox Author)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("Insert into Book(Book_title, Book_genre, Book_release, Book_author) values(@Title, @Genre, @Release, @Author)", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@Title", Title);
                        cmd.Parameters.AddWithValue("@Genre", Genre);
                        cmd.Parameters.AddWithValue("@Release", Release);
                        cmd.Parameters.AddWithValue("@Author", Author);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            catch (Exception exception)
            {
                page.Response.Write("Произошла ошибка " + exception.Message);
            }
            finally
            {
                connection.Close();
                Title.Text = null;
                Genre.Text = null;
                Release.Text = null;
                Author.Text = null;
            }
        }

        public void clearFill(TextBox Title, TextBox Genre, TextBox Release, TextBox Author)
        {
                    Title.Text = null;
                    Genre.Text = null;
                    Release.Text = null;
                    Author.Text = null;
        }
    }
}