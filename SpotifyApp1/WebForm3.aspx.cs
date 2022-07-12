using SpotifyApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Web.Services;

namespace SpotifyApp1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        SpotifyEntities context = new SpotifyEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            string uname = Convert.ToString(Session["username"]);

            int userid = context.UserDetails.FirstOrDefault(x => x.Name == uname).UserId;

            string songentered = Request.QueryString["song"].ToString();

            Song songdemo = context.Songs.FirstOrDefault(x => x.Name == songentered);

            int songnum = songdemo.SongId;

            int rate = Convert.ToInt32(Request.QueryString["rate"].ToString());

            UserRating u1 = new UserRating();
            u1.SID = songnum;
            u1.UID = userid;
            u1.Rating = rate;

            var allsongs = context.UserRatings.FirstOrDefault(x => x.UID == userid && x.SID == songnum);

            if (allsongs != null)
            {
                allsongs.Rating = rate;
                context.SaveChanges();
            }
            else 
            {
                context.UserRatings.Add(u1);
                context.SaveChanges();
            }

            

            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string songentered = TextBox1.Text;

            Song song = context.Songs.FirstOrDefault(x => x.Name == songentered);

            int songnum = song.SongId;

            int rate = Convert.ToInt32(TextBox2.Text);

            UserRating u1 = new UserRating();
            u1.SID = songnum;
            u1.UID = 4;
            u1.Rating = rate;

            context.UserRatings.Add(u1);
            context.SaveChanges();

            Label1.Text = "Rating Submitted Successfully";
        }

        
        protected void Button2_Click(object sender, EventArgs e)
        {
            //var l1 = context.UserRatings.SqlQuery("Select Top 3 SID,AVG(Rating) From UserRating Group By SID Order By AVG(Rating) DESC ").ToList();
            //var lst = context.UserRatings.GroupBy(x => x.SID).Select(g => g.Key);

            List<int> lst = (from emp in context.UserRatings
                                group emp by emp.SID into empg
                                orderby empg.Average(emp=>emp.Rating) descending
                                select empg.Key).Take(3).ToList();

            ArrayList ar1 = new ArrayList();
            foreach (int id in lst) 
            {
                var s = context.Songs.FirstOrDefault(x => x.SongId == id);

                ar1.Add(s.Name);
            }



            DropDownList1.DataSource = ar1;
            DropDownList1.DataBind();

            //ArrayList ar2 = new ArrayList();

            

            //foreach (int id in lst) 
            //{
            //   var lst1=context.Songs.FirstOrDefault(x => x.SongId == id).Artists.Select(x => x.ArtistId).ToList();
            //   ar2.Add(lst1);
                
            //}

            //List<int> fin = new List<int>();

            //foreach (List<int> i in ar2) 
            //{
            //    foreach (int j in i) 
            //    {
            //        fin.Add(j);

            //    }
            //}

            //ArrayList arfin = new ArrayList();

            //foreach (int id in fin) 
            //{
            //    var s1 = context.Artists.FirstOrDefault(x => x.ArtistId == id);
            //    arfin.Add(s1.Name);
            //}
            

            





            //TOP ARTISTS//

            var art1 = context.Artists.Select(x => x.ArtistId).ToList();

            ArrayList arr1 = new ArrayList();

            foreach (int id in art1) 
            {
                var art2=context.Artists.FirstOrDefault(x => x.ArtistId == id).Songs.Select(x=>x.SongId).ToList();
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

                double avg = Queryable.Average(a.AsQueryable());

                art4.Add(avg);
            }

            Dictionary<int, double> My_dict1 = new Dictionary<int, double>();
            for (int x = 0; x < art4.Count; x++) 
            {
                My_dict1.Add(art1[x], art4[x]);
            }

            List<int> finid = new List<int>();
            foreach (KeyValuePair<int, double> author in My_dict1.OrderByDescending(key => key.Value))
            {
                finid.Add(author.Key);
            }

            List<string> finname = new List<string>();
            foreach (int id in finid) 
            {
                var res1 = context.Artists.FirstOrDefault(x => x.ArtistId == id).Name;
                finname.Add(res1);
            }

            DropDownList2.DataSource = finname;
            DropDownList2.DataBind();


        }
    }
}