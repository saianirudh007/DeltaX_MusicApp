using SpotifyApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SpotifyApp1
{
    public partial class NewArtist : System.Web.UI.Page
    {
        SpotifyEntities context = new SpotifyEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Artist a1 = new Artist();
            a1.Name = TextBox1.Text;
            a1.DOB = Convert.ToDateTime(Calendar1.Text);
            a1.Bio = TextBox2.Text;

            context.Artists.Add(a1);
            context.SaveChanges();

            Response.Redirect("~/NewSong.aspx");
        }
    }
}