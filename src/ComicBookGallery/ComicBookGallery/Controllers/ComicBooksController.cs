using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController  : Controller
    {
        public ActionResult Detail()
        {
           ViewBag.SeriesTitle = "The Amazing Spider-Man";
           ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final issue! Witness the final hours of Doc Oc's life and his one, last,great, act of revenge! Even ifSpider-Man survives... <strong>will peter Parker?</strong></p>";
            ViewBag.Artists = new string[]
                {
                    "Script: Dann Slott",
                    "Pencils: Hamada",
                    "Colors: Ronaldo",
                    "Letters: Hassan Ragab"

                };

            return View();
           
        }

    }
}