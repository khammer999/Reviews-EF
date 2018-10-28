﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReviewSite.Controllers
{
    public class CategoryController : Controller
    {
        // GET: /<controller>/
        public ViewResult Index()
        {

            var model = categoryRepo.GetAll();
            return View(model);

        }
    }
}
