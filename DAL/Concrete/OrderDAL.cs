using DAL.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Concrete
{
    public class OrderDAL : ADalCrud<Order>
    {

        public OrderDAL() : base()
        {
        }

        // class ADalRead
        protected override string GetTableName()
        {
            return "[tblOrder]";
        }

        protected override Order CreateInstance(ICollection<string> args)
        {
            List<string> parameters = args.ToList<string>();
            Order order = new Order()
            {
                Id = Convert.ToInt32(parameters[Convert.ToInt32(EOrder.ID)]),
                Count = Convert.ToInt32(parameters[Convert.ToInt32(EOrder.COUNT)]),
                Id_Product = Convert.ToInt32(parameters[Convert.ToInt32(EOrder.PRODUCTID)]),
                Id_User = Convert.ToInt32(parameters[Convert.ToInt32(EOrder.USERID)]),

            };
            return order;
        }

        // class ADalCrud
        protected override IDictionary<string, string> GetValues(Order order)
        {
            // TODO Use Enum
            IDictionary<string, string> result = new Dictionary<string, string>();
            result.Add(EOrder.ID.ToString().ToLower(), order.Id.ToString());
            result.Add(EOrder.COUNT.ToString().ToLower(), order.Count.ToString());
            result.Add(EOrder.PRODUCTID.ToString().ToLower(), order.Id_Product.ToString());
            result.Add(EOrder.USERID.ToString().ToLower(), order.Id_User.ToString());

            return result;
        }

        public void PrintOrder(Order order)
        {
            Console.WriteLine(
                "\nID: " + order.Id.ToString() +
                "\nCount: " + order.Count.ToString() +
                "\nId_Product: " + order.Id_Product.ToString() +
                "\nId_User: " + order.Id_User.ToString()
                );
        }

        public void PrintListOfOrder(IList<Order> orders)
        {
            foreach (Order order in orders)
            {
                PrintOrder(order);
            }
        }

        protected override string GetTableIdName()
        {
            return "Order";
        }
    }
}

