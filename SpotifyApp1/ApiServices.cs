using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SpotifyApp1
{
    public class ApiServices:WebService
    {
        [WebMethod]
        public string test()
        {
            return "Test";
        }
    }
}