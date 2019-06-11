using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Butik.WebUI.Repository.Abstract;
using Butik.WebUI.Entity;

namespace Butik.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository repository;
        private IUnitOfWork uow;

        public HomeController(IUnitOfWork _uow,IProductRepository _repository)
        {
            repository = _repository;
            uow = _uow;
        }

        //public IActionResult Index()
        //{
        //    return View(uow.Products.GetAll().Where(i => i.IsApproved && i.IsHome).ToList());
        //}
        public IActionResult Details(int id)
        {
            return View(repository.Get(id));
        }

        public IActionResult Create()
        {
            var prd = new Product(){ ProductName ="Yeni Ürün",Price=1000 };
            uow.Products.Add(prd);
            uow.SaveChanges();
            return RedirectToAction("Index");
        }
       
        public ViewResult Index(string sortOrder, string searchString)
        {
            var products = from s in uow.Products.GetAll()
                           select s;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.PriceSortParm = sortOrder == "Price" ? "price_desc" : "Price";
            //ViewBag.PriceSortParmDes = sortOrder == "price_desc";
           
            
            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.ProductName.Contains(searchString)
                                       || s.Description.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    products = products.OrderByDescending(s => s.ProductName);
                    break;
                case "Price":
                    products = products.OrderBy(s => s.Price);
                    break;
                case "price_desc":
                    products = products.OrderByDescending(s => s.Price);
                    break;
                default:
                    products = products.OrderBy(s => s.ProductName);
                    break;
            }
                
            
            return View(products.ToList());

        }
      
      
    }
}