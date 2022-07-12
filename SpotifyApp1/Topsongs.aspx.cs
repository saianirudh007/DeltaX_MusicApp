using SpotifyApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data;
using System.Text;

namespace SpotifyApp1
{
    public partial class Topsongs : System.Web.UI.Page
    {
        SpotifyEntities context = new SpotifyEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<int> lst = (from emp in context.UserRatings
                             group emp by emp.SID into empg
                             orderby empg.Average(emp => emp.Rating) descending
                             select empg.Key).Take(10).ToList();

            ArrayList ar1 = new ArrayList();
            foreach (int id in lst)
            {
                var s = context.Songs.FirstOrDefault(x => x.SongId == id);

                ar1.Add(s);
            }

            DataTable dt = new DataTable();
            DataColumn dc0 = new DataColumn("Image");
            DataColumn dc1 = new DataColumn("SongName");
            DataColumn dc2 = new DataColumn("SongDate");
            DataColumn dc3 = new DataColumn("ArtistNames");
            dt.Columns.Add(dc0);
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);

            foreach (Song song in ar1) 
            {
                DataRow dr = dt.NewRow();
                dr["Image"] = "SongImages//" + song.Image;
                dr["SongName"] = song.Name;
                dr["SongDate"] = song.DateOf_Release.ToShortDateString();

                var artdata=song.Artists.ToList();

                string finard = "";
                foreach (Artist ar in artdata) 
                {
                    finard = finard + ar.Name+",";
                }

                StringBuilder strB = new StringBuilder(finard);

                strB[strB.Length - 1] = ' ';

                

                dr["ArtistNames"] = strB;

                dt.Rows.Add(dr);

            }

            Response.Write("<table class='table table-hover'><thead class='table-success'><tr class='text-center'><th>Image</th><th>Songs</th><th>Released Date</th><th>Artists</th></tr></thead><tbody class='text-center'>");
            foreach (DataRow drow in dt.Rows)
            {
                Response.Write("<tr>");
                Response.Write("<td><img width='100' height='100' src='" + drow["Image"].ToString() + "'></td>");
                Response.Write("<td><b>" + drow["SongName"].ToString() + "</b></td>");
                Response.Write("<td><b>" + drow["SongDate"].ToString() + "</b></td>");
                Response.Write("<td><b>" + drow["ArtistNames"].ToString() + "</b></td>");
                Response.Write("</tr>");
            }
            Response.Write("</tbody></table>");

        }
    }
}