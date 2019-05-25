using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Butik.WebUI.Entity;

namespace Butik.WebUI.Models
{
    public class CatalogListModel
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
    }
}
