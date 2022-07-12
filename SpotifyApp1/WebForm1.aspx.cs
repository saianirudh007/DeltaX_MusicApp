using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SpotifyApp1.Models;

namespace SpotifyApp1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SpotifyEntities context = new SpotifyEntities();
        //int count = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            //count = count + 1;
            //if (IsPostBack) 
            //{
            //    string artiname=Request["ArtistName"].ToString();
            //    DropDownList1.Items.Add(artiname);
            //}

            //if (Session["artiname"] != null) 
            //{
            //    DropDownList1.Items.Add(Session["artiname"].ToString());
            //}
            //if (!IsPostBack)
            //{
            //    List<string> artlist = context.Artists.Select(x => x.Name).ToList();
            //    DropDownList1.DataSource = artlist;
            //    DropDownList1.DataBind();
            //}

            

            if (!IsPostBack)
            {
                List<string> artlist = context.Artists.Select(x => x.Name).ToList();
                listbox1.DataSource = artlist;
                listbox1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm2.aspx");

            

            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpPostedFile postedFile = FileUpload1.PostedFile;
            string filename = Path.GetFileName(postedFile.FileName);
            string fileextension = Path.GetExtension(filename);
            int filesize = postedFile.ContentLength;

            Stream stream = postedFile.InputStream;
            BinaryReader binaryReader = new BinaryReader(stream);
            byte[] bytes = binaryReader.ReadBytes((int)stream.Length);
            string strbase64 = Convert.ToBase64String(bytes);

            Image1.ImageUrl = "data:Image/png;base64," + strbase64;

            Song s1 = new Song();
            s1.Name = TextBox1.Text;

            s1.DateOf_Release = Convert.ToDateTime(TextBox2.Text);
            s1.Image = "C:/Images/";

            context.Songs.Add(s1);
            context.SaveChanges();

            Label1.Text = "Song Details Added Successfully";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //Artist art1 = context.Artists.FirstOrDefault(x => x.Name == DropDownList1.SelectedValue);

            //context.Songs.FirstOrDefault(x => x.Name == TextBox1.Text).Artists.Add(art1);


            //context.SaveChanges();

            List<string> lsname = new List<string>();
            int c = 0;
            for (int i = 0; i < listbox1.Items.Count; i++) 
            {
                if (listbox1.Items[i].Selected) 
                {
                    lsname.Add(listbox1.Items[i].Text);
                    Label2.Text = lsname[c];
                    c = c + 1;
                }
            }

            foreach (string nm in lsname)
            {
                Artist art1 = context.Artists.FirstOrDefault(x => x.Name == nm);

                context.Songs.FirstOrDefault(x => x.Name == TextBox1.Text).Artists.Add(art1);


                context.SaveChanges();
            }







        }

        
    }
}