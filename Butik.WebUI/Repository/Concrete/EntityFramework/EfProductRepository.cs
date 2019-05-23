using Butik.WebUI.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Butik.WebUI.Entity;
using System.Linq.Expressions;

namespace Butik.WebUI.Repository.Concrete.EntityFramework
{
    public class EfProductRepository : EfGenericRepository<Product>, IProductRepository
    {
        public EfProductRepository(ButikContext context) : base(context)
        {

        }
        public ButikContext ButikContext
        {
            get { return context as ButikContext; }
        }
        public List<Product> Get5TopProducts()
        {
            return ButikContext.Products.OrderByDescending(i => i.ProductId).Take(5).ToList();
        }
    }
}
