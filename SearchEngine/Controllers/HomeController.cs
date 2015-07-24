using SearchEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace SearchEngine.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult PerformSearchResults(SearchCriteria criteria)
        {
            IEnumerable<MockPost> mockPosts = new List<MockPost>();

            if (criteria != null && !string.IsNullOrEmpty(criteria.SearchString))
            {

                using (var client = new WebClient())
                {
                    var json = client.DownloadString("http://jsonplaceholder.typicode.com/posts");
                    var serializer = new JavaScriptSerializer();
                    mockPosts = serializer.Deserialize<List<MockPost>>(json);
                }
            }

            return Json(mockPosts);
        }

    }
}
