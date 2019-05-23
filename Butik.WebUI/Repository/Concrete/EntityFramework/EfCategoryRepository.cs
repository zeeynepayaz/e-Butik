using Butik.WebUI.Entity;
using Butik.WebUI.Models;
using Butik.WebUI.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Butik.WebUI.Repository.Concrete.EntityFramework
{
    public class EfCategoryRepository : EfGenericRepository<Category>, ICategoryRepository
    {
        public EfCategoryRepository(ButikContext context):base(context)
        {
                
        }

        public ButikContext ButikContext
        {
            get { return context as ButikContext; }
        }

        public IEnumerable<CategoryModel> GetAllWithProductCount()
        {
            return GetAll().Select(i => new CategoryModel{
                CategoryId = i.CategoryId,
                CategoryName=i.CategoryName,
                Count = i.ProductCategories.Count()
            });
        }
        public Category GetByName(string name)
        {
            return ButikContext.Categories.Where(i => i.CategoryName == name).FirstOrDefault();
        }
    }
}
