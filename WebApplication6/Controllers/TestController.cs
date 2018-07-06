using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Xsl;

namespace WebApplication6.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {

            string outfile = Path.GetTempFileName().Replace(".tmp", ".html");
            XslCompiledTransform transform = new XslCompiledTransform();
            transform.Load("C:\\Users\\ismet\\Desktop\\deneme2.xslt");
            transform.Transform("C:\\Users\\ismet\\Desktop\\deneme1.xml", outfile);


            ViewBag.cikti = outfile;
            return View();
        }
    }
}