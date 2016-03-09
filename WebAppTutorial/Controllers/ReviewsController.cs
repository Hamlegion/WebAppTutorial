using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppTutorial.Models;

namespace WebAppTutorial.Controllers
{
    public class ReviewsController : Controller
    {
        TutorialDb _db = new TutorialDb();
        
        // GET: Reviews
        public ActionResult Index([Bind(Prefix ="id")] int id)
        {
            var restaurant = _db.Restaurants.Find(id);
            if(restaurant !=null)
            {
                return View(restaurant);
            }
            return HttpNotFound();
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}