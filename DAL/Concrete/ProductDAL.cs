

using DAL.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Concrete
{
    public class ProductDAL : ADalCrud<Product>
    {
        public ProductDAL() : base()
        {
        }

        // class ADalRead
        protected override string GetTableName()
        {
            return "tblProduct";
        }

        protected override Product CreateInstance(ICollection<string> args)
        {
            List<string> parameters = args.ToList<string>();
            Product product = new Product()
            {
                Id = Convert.ToInt32(parameters[Convert.ToInt32(EProduct.ID)]),
                Name = parameters[Convert.ToInt32(EProduct.NAME)],
                Price = Convert.ToDouble(parameters[Convert.ToInt32(EProduct.PRICE)]),
                Count = Convert.ToInt32(parameters[Convert.ToInt32(EProduct.Count)]),
                Description = parameters[Convert.ToInt32(EProduct.DESCRIPTION)],
                Company = parameters[Convert.ToInt32(EProduct.COMPANY)]

            };
            return product;
        }

        // class ADalCrud
        protected override IDictionary<string, string> GetValues(Product product)
        {
            // TODO Use Enum
            IDictionary<string, string> result = new Dictionary<string, string>();
            result.Add(EProduct.ID.ToString().ToLower(), product.Id.ToString());
            result.Add(EProduct.NAME.ToString(), product.Name.ToString());
            result.Add(EProduct.PRICE.ToString(), product.Price.ToString());
            result.Add(EProduct.Count.ToString(), product.Count.ToString());
            result.Add(EProduct.DESCRIPTION.ToString(), product.Description.ToString());
            result.Add(EProduct.COMPANY.ToString(), product.Company.ToString());

            return result;
        }

        protected override string GetTableIdName()
        {
            return "Product";
        }
    }
}
