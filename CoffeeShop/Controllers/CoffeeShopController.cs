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

        //UPDATE METHOD
        public void UpdateSort(int id, Table table)
        {
            using (CoffeeShopBDEntities ex = new CoffeeShopBDEntities())
            {
                var coffeUpdate = ex.Tables.Where(p => p.Id == id).FirstOrDefault();
                if (coffeUpdate != null)
                {
                    coffeUpdate.Id = table.Id;
                    coffeUpdate.SortPrice = table.SortPrice;
                    coffeUpdate.SortQuantity = table.SortQuantity;
                    coffeUpdate.SortType = table.SortType;
                    ex.SaveChanges();
                }
            }
        }

        //DELETE METHOD
        public void DeleteSort(int id)
        {
            using (CoffeeShopBDEntities ex = new CoffeeShopBDEntities())
            {
                var SortToDelete = ex.Tables.Where(p => p.Id == id).FirstOrDefault();
                if (SortToDelete != null)
                {
                    ex.Tables.Remove(SortToDelete);
                    ex.SaveChanges();
                }
            }

        }
    }
}
