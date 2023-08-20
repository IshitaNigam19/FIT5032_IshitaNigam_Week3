using FIT5032_MyCodeSnippet_1.Models.Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FIT5032_MyCodeSnippet_1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "FIT5032";

            HelloWorld.Hello hello = new HelloWorld.Hello();
            ViewBag.Message = hello.GetHello();

            Models.Exercise.ExampleDictionary ed = new ExampleDictionary();
            ed.Example();
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}