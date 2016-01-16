using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using 家計簿試作品.Models;

namespace 家計簿試作品.Controllers
{
    public class SampleController : Controller
    {
        private Context db = new Context();

        // GET: Sample
        public ActionResult Index()
        {
            return View(db.Members);
        }

        public ActionResult List()
        {
            return View(db.Members);
        }
    }
}