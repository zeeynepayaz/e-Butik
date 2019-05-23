using Butik.WebUI.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Butik.WebUI.Repository.Concrete.EntityFramework
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private readonly ButikContext dbContext;
        public EfUnitOfWork(ButikContext _dbContext)
        {
            dbContext = _dbContext ?? throw new ArgumentNullException("dbcontext can not be null!");
        }

        private IProductRepository _products;
        private ICategoryRepository _categories;

        public IProductRepository Products
        {
            get
            {
                return _products ?? (_products = new EfProductRepository(dbContext));
            }
        }

        public ICategoryRepository Categories
        {
            get
            {
                return _categories ?? (_categories = new EfCategoryRepository(dbContext));
            }
        }

        public void Dispose()
        {
            dbContext.Dispose();
        }

        public int SaveChanges()
        {
            try
            {
               return dbContext.SaveChanges();
            }
            catch(Exception)
            {
                throw;
            }
            
        }
    }
}
