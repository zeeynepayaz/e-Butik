using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Butik.WebUI.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Butik.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryRepository repository;

        public CategoryController(ICategoryRepository _repository)
        {
            repository = _repository;
        }
        public IActionResult Index()
        {
            return View(repository.GetByName("Tisort"));
        }
    }
}