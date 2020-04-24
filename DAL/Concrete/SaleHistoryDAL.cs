using DAL.Abstract;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Concrete
{
    public class SaleHistoryDAL : ADalCrud<SaleHistory>
    {
        public SaleHistoryDAL() : base()
        {
        }

        // class ADalRead
        protected override string GetTableName()
        {
            return "[tblSaleHistory]";
        }

        protected override SaleHistory CreateInstance(ICollection<string> args)
        {
            List<string> parameters = args.ToList<string>();
            SaleHistory order = new SaleHistory()
            {
                Id = Convert.ToInt32(parameters[Convert.ToInt32(ESaleHistory.ID)]),
                Count = Convert.ToInt32(parameters[Convert.ToInt32(ESaleHistory.COUNT)]),
                DateOrdered = parameters[Convert.ToInt32(ESaleHistory.DATEORDERED)],
                DateDelivery = parameters[Convert.ToInt32(ESaleHistory.DATEDELIVERY)],
                Id_Product = Convert.ToInt32(parameters[Convert.ToInt32(ESaleHistory.PRODUCTID)])
            };
            return order;
        }

        // class ADalCrud
        protected override IDictionary<string, string> GetValues(SaleHistory saleHistory)
        {
            // TODO Use Enum
            IDictionary<string, string> result = new Dictionary<string, string>();
            result.Add(ESaleHistory.ID.ToString().ToLower(), saleHistory.Id.ToString());
            result.Add(ESaleHistory.COUNT.ToString().ToLower(), saleHistory.Count.ToString());
            result.Add(ESaleHistory.DATEORDERED.ToString().ToLower(), saleHistory.DateOrdered.ToString());
            result.Add(ESaleHistory.DATEDELIVERY.ToString().ToLower(), saleHistory.DateDelivery.ToString());
            result.Add(ESaleHistory.PRODUCTID.ToString().ToLower(), saleHistory.Id_Product.ToString());

            return result;
        }

        public void PrintSaleHistory(SaleHistory saleHistory)
        {
            Console.WriteLine(
                "\nID: " + saleHistory.Id.ToString() +
                "\nCount: " + saleHistory.Count.ToString() +
                "\nDateOrdered: " + saleHistory.DateOrdered +
                "\nDateDelivery: " + saleHistory.DateDelivery +
                "\nId_Product: " + saleHistory.Id_Product
                );
        }

        public void PrintListOfSaleHistory(IList<SaleHistory> saleHistories)
        {
            foreach (SaleHistory saleHistory in saleHistories)
            {
                PrintSaleHistory(saleHistory);
            }
        }

        protected override string GetTableIdName()
        {
            return "SaleHistory";
        }
    }
}
