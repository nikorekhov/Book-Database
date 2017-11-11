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
using WebProject.Books;

namespace WebProject
{
    public partial class BooksForm : System.Web.UI.Page
    {
        Database database = new Database();
        private int id; 

        protected void Page_Load(object sender, EventArgs e)
        {
            database.viewData(this.Page, repeaterBook);
        }

        protected void RepeaterItemDataBound(object sender, RepeaterItemEventArgs e)
        {

        }

        protected void insertData(object sender, EventArgs e)
        {
            database.insertQuery(this.Page, repeaterBook, Title, Genre, Release, Author);
        }
        
        protected void deleteData(object sender, EventArgs e)
        {
            
        }
    }
}