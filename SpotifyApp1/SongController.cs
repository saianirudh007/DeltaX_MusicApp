
using System;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
//using System.Web.Http;
using Newtonsoft.Json;
//using Microsoft.AspNetCore.Mvc;

namespace SpotifyApp1
{
    public class SongController : Controller
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }


       [Route("Song/Jango")]
        public string Jango()
        {
            return "Test";
        }
 
    }
}