using SpotifyApp1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SpotifyApp1
{
    public partial class HomePage : System.Web.UI.Page
    {
        SpotifyEntities context = new SpotifyEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            var songdata = context.Songs.ToList();

            DataTable dt = new DataTable();
            DataColumn dc0 = new DataColumn("ArtWork");
            DataColumn dc1 = new DataColumn("Song");
            DataColumn dc2 = new DataColumn("Songreleased");
            DataColumn dc3 = new DataColumn("Artists");
            dt.Columns.Add(dc0);
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);

            foreach (Song song in songdata)
            {
                DataRow dr = dt.NewRow();

                dr["ArtWork"]= "SongImages//" + song.Image;
                
                
                dr["Song"] = song.Name;
                dr["Songreleased"] = song.DateOf_Release.ToShortDateString();

                var artdata = song.Artists.ToList();

                string finard = "";
                foreach (Artist ar in artdata)
                {
                    finard = finard + ar.Name + ",";
                }

                StringBuilder strB = new StringBuilder(finard);

                strB[strB.Length - 1] = ' ';



                dr["Artists"] = strB;

                dt.Rows.Add(dr);

            }

            
            
            Response.Write("<table class='table table-hover'><thead class='table-success'><tr class='text-center'><th>Image</th><th>Songs</th><th>Released Date</th><th>Artists</th><th>Rating</th><th></th></tr></thead><tbody class='text-center'>");

            foreach (DataRow drow in dt.Rows) 
            {
                Response.Write("<tr>");
                Response.Write("<td><img width='100' height='100' src='" + drow["ArtWork"].ToString() + "'></td>");
                Response.Write("<td>"+drow["Song"].ToString()+"</td>");
                Response.Write("<td>" + drow["Songreleased"].ToString() + "</td>");
                Response.Write("<td>" + drow["Artists"].ToString() + "</td>");
                Response.Write("<td class='d-flex' id='"+drow["Song"]+"'><p class='bi bi-star' id='1' title='" + drow["Song"]+ "' onclick='change(this)'></p><p class='bi bi-star' id='2' title='" + drow["Song"] + "' onclick='change(this)'></p><p class='bi bi-star' id='3' title='" + drow["Song"] + "' onclick='change(this)'></p><p class='bi bi-star' id='4' title='" + drow["Song"] + "' onclick='change(this)'></p><p class='bi bi-star' id='5' title='" + drow["Song"] + "' onclick='change(this)'></p></td>");
                Response.Write("<td><button class='btn btn-success' id='" + drow["Song"] + "' onclick='postData(this)'>Submit</button></td>");
                Response.Write("</tr>");
            }
            Response.Write("</tbody></table>");

            //GridView1.DataSource = dt;
            //GridView1.DataBind();

           

            

        }



        
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/NewSong.aspx");
        }

       
    }
}