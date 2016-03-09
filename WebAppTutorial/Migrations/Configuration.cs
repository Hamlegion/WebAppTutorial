namespace WebAppTutorial.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAppTutorial.Models.TutorialDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "WebAppTutorial.Models.TutorialDb";
        }

        protected override void Seed(WebAppTutorial.Models.TutorialDb context)
        {
            context.Restaurants.AddOrUpdate(r => r.Name,
                new Restaurant
                {
                    Name = "CevaNume",
                    City = "Bucur",
                    Country = "'Murica",
                    Reviews =
                        new List<RestaurantReview>
                        {
                            new RestaurantReview { Rating = 9, Body = "Good Food" }
                        }
                });
        }
    }
}
