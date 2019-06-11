using Butik.WebUI.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Butik.WebUI.Components
{
    public class SortProducts : ViewComponent
    {
        private IProductRepository repository;
        public SortProducts(IProductRepository _repository)
        {
            repository = _repository;
        }
        public IViewComponentResult Invoke()
        {
            return View(repository.GetAll().ToList());
        }
    }
}
