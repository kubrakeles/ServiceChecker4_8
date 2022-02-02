using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExcelDataReader;
using ServiceChecker4_8.Models;

namespace ServiceChecker4_8.Controllers
{
    public class HomeController : Controller
    {
        

        [HttpGet]
        public ActionResult Index()
        {
            
            return View(new List<excModel>());
        }
        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
           
            return View();
        }
    }
}
