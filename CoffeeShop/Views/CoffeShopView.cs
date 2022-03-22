using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Controllers;
using CoffeeShop.Models;
using System.Windows.Forms;

namespace CoffeeShop.Views
{
    public partial class CoffeShopView : Form
    {
        CoffeeShopController coffeeShopController = new CoffeeShopController();

        public CoffeShopView()
        {
            InitializeComponent();
        }
    
        private void CoffeShopForm_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void RefreshTable()
        {
            dgvCoffees.DataSource = coffeeShopController.GetAll();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Table table = new Table();
            table.SortType = txtCreate.Text;
            table.SortPrice = int.Parse(txtPrice.Text);
            table.SortQuantity = int.Parse(txtQuantity.Text);
            coffeeShopController.CreateSort(table);
            RefreshTable();
        }
    }
}
