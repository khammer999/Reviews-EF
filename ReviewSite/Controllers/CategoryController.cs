using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ReviewSite.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryRepository categoryRepo;

        public CategoryController(ICategoryRepository categoryRepo)
        {
            this.categoryRepo = categoryRepo;
        }

        public ViewResult Index()
        {
            var model = categoryRepo.GetAll();
            return View(model);

        }

        public ViewResult Details(int id)
        {
            var model = categoryRepo.FindOneCategoryById(id);
            return View(model);

        }

     
    }
}
