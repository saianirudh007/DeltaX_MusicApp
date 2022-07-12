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
    public partial class Topartists : System.Web.UI.Page
    {
        SpotifyEntities context = new SpotifyEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var artobj = context.Artists.ToList();
            var art1 = context.Artists.Select(x => x.ArtistId).ToList();

            ArrayList arr1 = new ArrayList();

            foreach (int id in art1)
            {
                var art2 = context.Artists.FirstOrDefault(x => x.ArtistId == id).Songs.Select(x => x.SongId).ToList();
                arr1.Add(art2);
            }

            List<double> art4 = new List<double>();
            foreach (List<int> i in arr1)
            {
                List<int> a = new List<int>();
                foreach (var j in i)
                {
                    var res = context.UserRatings.Where(x => x.SID == j).Select(y => y.Rating).ToList();
                    a.AddRange(res);
                }

                double avg;
                if (a.Count == 0) 
                {
                    avg = 0;
                }
                else 
                {
                    avg = Queryable.Average(a.AsQueryable());
                }
                

                art4.Add(avg);
            }

            Dictionary<Artist, double> My_dict1 = new Dictionary<Artist, double>();
            for (int x = 0; x < art4.Count; x++)
            {
                My_dict1.Add(artobj[x], art4[x]);
            }

            List<Artist> finid = new List<Artist>();
            foreach (KeyValuePair<Artist, double> author in My_dict1.OrderByDescending(key => key.Value))
            {
                finid.Add(author.Key);
            }

            ArrayList ar1 = new ArrayList();
            for (int i = 0; i < 10; i++) 
            {
                ar1.Add(finid[i]);
            }


            DataTable dt = new DataTable();
            DataColumn dc1 = new DataColumn("ArtistName");
            DataColumn dc2 = new DataColumn("DateOfBirth");
            DataColumn dc4 = new DataColumn("Artist Bio");
            DataColumn dc3 = new DataColumn("SongNames");
            
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            dt.Columns.Add(dc4);

            foreach (Artist arti in ar1)
            {
                DataRow dr = dt.NewRow();
                dr["ArtistName"] = arti.Name;
                dr["DateOfBirth"] = arti.DOB.ToShortDateString();
                dr["Artist Bio"] = arti.Bio;

                var songdata = arti.Songs.ToList(); 

                string finard = "";
                foreach (Song sr in songdata)
                {
                    finard = finard + sr.Name + ",";
                }

                StringBuilder strB = new StringBuilder(finard);

                strB[strB.Length - 1] = ' ';



                dr["SongNames"] = strB;

                dt.Rows.Add(dr);

            }

            Response.Write("<table class='table table-hover'><thead class='table-success'><tr class='text-center'><th>Artists</th><th>Date Of Birth</th><th>Bio</th><th>Songs</th></tr></thead><tbody class='text-center'>");
            foreach (DataRow drow in dt.Rows)
            {
                Response.Write("<tr>");
                Response.Write("<td><b>" + drow["ArtistName"].ToString() + "</b></td>");
                Response.Write("<td><b>" + drow["DateOfBirth"].ToString() + "</b></td>");
                Response.Write("<td><b>" + drow["Artist Bio"].ToString() + "</b></td>");
                Response.Write("<td><b>" + drow["SongNames"].ToString() + "</b></td>");
                Response.Write("</tr>");
            }
            Response.Write("</tbody></table>");
        }
    }
}