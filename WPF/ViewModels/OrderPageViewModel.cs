using BLogic;
using Entity.Concrete;
using System.Collections.Generic;

namespace WPF
{
    class OrderPageViewModel
    {
        public User User { get; set; }
        public List<Product> Products { get; set; }
        private BL bL;
        public OrderPageViewModel()
        {
            bL = new BL();
            Products = bL.GetProducts();
        }
    }
}
