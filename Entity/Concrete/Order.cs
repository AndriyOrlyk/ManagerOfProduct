using Entity.Abstract;

namespace Entity.Concrete
{
    public enum EOrder
    {
        ID = 0,
        COUNT,
        USERID,
        PRODUCTID
    }
    public class Order : IEntity
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public int Id_User { get; set; }
        public int Id_Product { get; set; }
        public Order(int count, int id_User, int id_Product)
        {
            Count = count;
            Id_User = id_User;
            Id_Product = id_Product;
        }

        public Order()
        {
        }
    }
}

