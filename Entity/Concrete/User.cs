using Entity.Abstract;

namespace Entity.Concrete
{
    public enum EUser
    {
        ID = 0,
        NAME
    }
    public class User : IEntity
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public User(string name)
        {
            Name = name;
        }

        public User()
        {
        }
    }
}
