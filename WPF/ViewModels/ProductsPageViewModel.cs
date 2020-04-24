using BLogic;
using Entity.Concrete;
using System.Collections.Generic;

namespace WPF
{
    class ProductsPageViewModel
    {
        private BL BL;
        public List<Product> Products { get; set; }
        public ProductsPageViewModel()
        {
            BL = new BL();
            Products = BL.GetProducts();
        }

    }
}
