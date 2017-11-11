using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebProject.Books
{
    public partial class DeleteData : System.Web.UI.Page
    {
        Database database = new Database();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void acceptDeleting(object sender, EventArgs e)
        {
            database.deleteString();
            Response.Redirect("/Books/BooksForm.aspx");
        }

        protected void cancelDeleting(object sender, EventArgs e)
        {
            Response.Redirect("/Books/BooksForm.aspx");
        }
    }
}