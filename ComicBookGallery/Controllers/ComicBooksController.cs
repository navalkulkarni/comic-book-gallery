using ComicBookGallery.Data;
using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail(int? id)
        {
            var comicBook = new ComicBook();
            if (id == null)
                return HttpNotFound();
            else
                comicBook = ComicBookRepository.GetComicBook(id.Value);

            
            return View(comicBook);
        }

        public ActionResult Index()
        {
            var comicBooks = ComicBookRepository.GetComicBooks();
            return View(comicBooks);
        }
    }
}