using ReviewSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite
{
    public class ReviewRepository:IReviewRepository
    {

        Review reviewOne = new Review() { Id = 123, Title = "War And Peace" };
        Review reviewTwo = new Review() { Id = 456, Title = "Confederates In The Attic" };
        Review reviewThree = new Review() { Id = 789, Title = "Hunt For Red Oktober" };

        Dictionary<int, Review> allReviews = new Dictionary<int, Review>();

        public ReviewRepository()
        {
            allReviews.Add(reviewOne.Id, reviewOne);
            allReviews.Add(reviewOne.Id, reviewTwo);
            allReviews.Add(reviewOne.Id, reviewThree);
        }
       

        public Review FindOneReviewById(int key)
        {
            return allReviews[key];
            
        }

        public List<Review> GetAll() //method returns dictionary of all reviews
        {


            return allReviews.Values.ToList();

        }





    }
}
