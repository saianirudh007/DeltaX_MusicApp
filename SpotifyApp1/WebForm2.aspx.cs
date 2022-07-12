using SpotifyApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace SpotifyApp1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SpotifyEntities context = new SpotifyEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Artist a1 = new Artist();
            a1.Name = TextBox1.Text;
            a1.DOB = Calendar1.SelectedDate;
            a1.Bio = TextBox2.Text;
            //var date = Calendar1.SelectedDate;
            Label1.Text = " Artist Data Added Successfully";
            
            context.Artists.Add(a1);
            context.SaveChanges();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["artiname"] = TextBox1.Text;
            Response.Redirect("~/WebForm1.aspx");
        }
    }
}