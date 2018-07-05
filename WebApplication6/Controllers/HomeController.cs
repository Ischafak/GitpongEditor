using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Xsl;
using System.Xml.XPath;
using System.IO;

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Xslt()
        {
            return View();
        }

        public ActionResult Xml()
        {


            ViewBag.mesaj = System.IO.File.ReadAllText("C:\\Users\\ismet\\source\\repos\\XsltCreator-1\\WebApplication6\\lib\\qqqq.xml");
           



            return View();
        }
      
    }
}