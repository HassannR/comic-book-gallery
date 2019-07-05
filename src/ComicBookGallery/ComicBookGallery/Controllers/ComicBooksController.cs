using ComicBookGallery.Models;
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

            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescrptionHtml = "<p>Final issue! Witness the final hours of Doc Oc's life and his one, last,great, act of revenge! Even ifSpider-Man survives... <strong>will peter Parker?</strong></p>",

                Artists = new Artist[]
                    {

                        new Artist() { Name = "Hamada", Role = "Pencils" },
                        new Artist() { Name = "Dann Slott", Role = "Script" },
                        new Artist() { Name = "Ronaldo", Role = "Colors" },
                        new Artist() { Name = "Hassan Ragab" , Role = "Letters"}

                        }
                    };
                    
                

          

            return View(comicBook);
           
        }

    }
}