using SpotifyApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SpotifyApp1
{
    public partial class Signup : System.Web.UI.Page
    {
        SpotifyEntities context = new SpotifyEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UserDetail u = new UserDetail();
            u.Name = TextBox1.Text;
            u.Email = TextBox2.Text;
            u.Password = TextBox3.Text;
            context.UserDetails.Add(u);
            context.SaveChanges();

            Response.Redirect("~/Login.aspx");
        }
    }
}