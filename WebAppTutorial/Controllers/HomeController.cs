using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppTutorial.Models;

namespace WebAppTutorial.Controllers
{
    public class HomeController : Controller
    {
        TutorialDb _db = new TutorialDb();

        public ActionResult Index(string searchTerm = null)
        {
            //var model = from r in _db.Restaurants
            //            orderby r.Reviews.Average(review => review.Rating) descending
            //            select new
            //            {
            //                r.Id,
            //                r.Name,
            //                r.City,
            //                r.Country,
            //                NumberOfReviews = r.Reviews.Count()
            //            };

            var model =
                _db.Restaurants.OrderByDescending(r => r.Reviews.Average(review => review.Rating))
                .Where(r=>searchTerm == null || r.Name.StartsWith(searchTerm))
                .Select(r => new RestaurantReviewListModel
                {
                    Id = r.Id,
                    Name = r.Name,
                    City = r.City,
                    Country = r.Country,
                    NumberOfReviews = r.Reviews.Count()
                });

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        protected override void Dispose(bool disposing)
        {
            if(_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}