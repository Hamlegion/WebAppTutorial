using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAppTutorial.Models
{
    public class TutorialDb : DbContext
    {
        public TutorialDb() : base("DefaultConnection")
        {
            Database.SetInitializer<TutorialDb>(new CreateDatabaseIfNotExists<TutorialDb>());
        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantReview> Reviews { get; set; }
    }
}