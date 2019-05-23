using Butik.WebUI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Butik.WebUI.Repository.Abstract
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        List<Product> Get5TopProducts();

    }
}
