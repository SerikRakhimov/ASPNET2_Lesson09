using Repository.Interfases;
using Repository.Interfases.Release;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Repository.Controllers
{
    public class HomeController : Controller
    {
        IRepository repo;

        public HomeController()
        {
//        repo = new JsonRepository();
          repo = new SQLRepository();
        }
        public ActionResult Index()
        {
      
            IEnumerable<MOCK_DATA> list = repo.List();

            return View(list);

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}