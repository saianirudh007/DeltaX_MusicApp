using SpotifyApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SpotifyApp1
{
    public partial class Login : System.Web.UI.Page
    {
        SpotifyEntities context = new SpotifyEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var det=context.UserDetails.FirstOrDefault(x => x.Name == TextBox1.Text && x.Password == TextBox2.Text);
            if (det == null)
            {
                Label1.Text = "Incorrect User Details";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            else 
            {
                Session["username"] = TextBox1.Text;
                Response.Redirect("~/HomePageDisplay.aspx");
            }
            
        }
    }
}