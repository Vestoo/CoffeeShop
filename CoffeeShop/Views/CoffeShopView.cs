using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Controllers;
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
            dgvCoffeeShop.DataSource = coffeeShopController.GetAll();
        }
    }
}
