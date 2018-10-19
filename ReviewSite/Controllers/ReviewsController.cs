using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite.Controllers
{
    public class ReviewsController: Controller
    {
        private IReviewRepository reviewRepo;

        public ReviewsController(IReviewRepository reviewRepo)
        {
            this.reviewRepo = reviewRepo;
        }

        public ViewResult Index()
        {
            var model = reviewRepo.GetAll();
            return View(model);

        }

        public ViewResult Details(int id)
        {
            var model = reviewRepo.FindOneReviewById(id);
            return View(model);

        }



    }
}
