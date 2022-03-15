using CoffeeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Controllers
{
    class CoffeeShopController
    {
        public List<Table> GetAll()
        {
            using (CoffeeDbEntities entities = new CoffeeDbEntities())
            {
                return entities.Tables.ToList();
            }
        }

        public void CreateSort(Table table)
        {
            using (CoffeeDbEntities cf = new CoffeeDbEntities())
            {
                var lastSort = cf.Tables.ToList().LastOrDefault();
                if (lastSort == null)
                {
                    lastSort = new Table();
                    lastSort.Id = 0;
                }
            }
        }
    }
}
