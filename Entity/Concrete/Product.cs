using Entity.Abstract;

namespace Entity.Concrete
{
    public enum EProduct
    {
        ID = 0,
        NAME,
        PRICE,
        Count,
        DESCRIPTION,
        COMPANY
    }
    public class Product : IEntity
    {
        public int Id { get; set; } = 5;

        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }
        public string Company { get; set; }

        public Product(string name, double price, int count, string description, string company)
        {
            Name = name;
            Price = price;
            Count = count;
            Description = description;
            Company = company;
        }

        public Product()
        {
        }
    }
}
