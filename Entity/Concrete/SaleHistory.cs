using Entity.Abstract;
using System;

namespace ENTITY
{
    public enum ESaleHistory
    {
        ID = 0,
        COUNT,
        DATEORDERED,
        DATEDELIVERY,
        PRODUCTID
    }

    public class SaleHistory : IEntity
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public string DateOrdered { get; set; }
        public string DateDelivery { get; set; }
        public int Id_Product { get; set; }

        public SaleHistory(int count, string dateOrdered, string dateDelivery, int id_Product)
        {
            Count = count;
            DateOrdered = dateOrdered;
            DateDelivery = dateDelivery;
            Id_Product = id_Product;
        }

        public SaleHistory()
        {
        }
    }
}
