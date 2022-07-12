using SpotifyApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SpotifyApp1
{
    public partial class NewSong : System.Web.UI.Page
    {
        SpotifyEntities context = new SpotifyEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<string> artlist = context.Artists.Select(x => x.Name).ToList();
                listbox1.DataSource = artlist;
                listbox1.DataBind();
            }
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            Song s1 = new Song();
            s1.Name = TextBox1.Text;

            s1.DateOf_Release = Convert.ToDateTime(TextBox2.Text);
            FileUpload1.SaveAs(Server.MapPath("SongImages//" + FileUpload1.FileName));
            s1.Image = FileUpload1.FileName;

            context.Songs.Add(s1);
            context.SaveChanges();

            List<string> lsname = new List<string>();
            
            for (int i = 0; i < listbox1.Items.Count; i++)
            {
                if (listbox1.Items[i].Selected)
                {
                    lsname.Add(listbox1.Items[i].Text);
                    
                }
            }

            foreach (string nm in lsname)
            {
                Artist art1 = context.Artists.FirstOrDefault(x => x.Name == nm);

                context.Songs.FirstOrDefault(x => x.Name == TextBox1.Text).Artists.Add(art1);


                context.SaveChanges();
            }

            Response.Redirect("~/HomePageDisplay.aspx");
        }
    }
}