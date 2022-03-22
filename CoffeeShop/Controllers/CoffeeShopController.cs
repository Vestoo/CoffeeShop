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
            using (CoffeeShopBDEntities ex = new CoffeeShopBDEntities())
            {
                return ex.Tables.ToList();
            }
        }


        //CREATE METHOD
        public void CreateSort(Table table)
        {
            using (CoffeeShopBDEntities cf = new CoffeeShopBDEntities())
            {
                var lastSort = cf.Tables.ToList().LastOrDefault();
                if (lastSort == null)
                {
                    lastSort = new Table();
                    lastSort.Id = 0;
                }

                table.Id = lastSort.Id + 1;
                cf.Tables.Add(table);
                cf.SaveChanges();
            }
        }

    }
}
