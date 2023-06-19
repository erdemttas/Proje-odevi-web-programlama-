using BusinessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webProject_erdemTas.Controllers
{
	public class MovieController : Controller
	{
		MovieManager mm = new MovieManager();

		public ActionResult MovieCard()
		{
			var movievalues = mm.getAllBL();
			return View(movievalues);
		}

		//ekleme sayfası
		[HttpGet]
		public ActionResult AddMovie()
		{
			return View();
		}

		//ekleme işlemi
		[HttpPost]
		public ActionResult AddMovie(Movie p)
		{
			mm.MovieAddBL(p);
			return RedirectToAction("MovieCard");
		}

		//id'si alınınan veriyi yazdırma
		[HttpGet]
		public ActionResult PageMovie(int id)
		{
			var movievalues=mm.getById(id);
			return View(movievalues);
		}


	}
}