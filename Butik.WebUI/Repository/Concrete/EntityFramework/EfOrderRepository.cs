using Butik.WebUI.Entity;
using Butik.WebUI.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Butik.WebUI.Repository.Concrete.EntityFramework
{
    public class EfOrderRepository : EfGenericRepository<Order>,IOrderRepository
    {

        public EfOrderRepository(ButikContext context) : base(context)
        {
        }
    }
}
