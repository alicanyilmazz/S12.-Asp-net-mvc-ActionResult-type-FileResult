using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FileResult_sample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult homepage()
        {
            return View();
        }

        public FileResult Show_File()
        {
            string file_path = Server.MapPath("~/Files/java.pdf");

            return new FilePathResult(file_path, "application/pdf");
        }
    }
}