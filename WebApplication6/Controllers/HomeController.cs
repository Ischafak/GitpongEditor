﻿using System;
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
           

            string outfile = Path.GetTempFileName().Replace(".tmp", ".html");
            XslCompiledTransform transform = new XslCompiledTransform();
            transform.Load("C:\\Users\\ismet\\Desktop\\deneme2.xslt");
            transform.Transform("C:\\Users\\ismet\\Desktop\\deneme1.xml", outfile);


            ViewBag.cikti = outfile;
            return View();
        }
        public ActionResult Xslt()
        {
            return View();
        }

        public ActionResult Xml()
        {

            return View();

        }
        

    }
}