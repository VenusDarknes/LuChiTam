using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LuChiTam.Models;

namespace LuChiTam.Controllers
{
    public class RubikController : Controller
    {
        // GET: Rubik
        MyData data = new MyData();
        public ActionResult Index()
        {
            var all_rubik = from s in data.Rubiks select s;
            return View(all_rubik);
        }
    }
}