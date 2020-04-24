using Entity.Abstract;

namespace Entity.Concrete
{
    public enum EUserLogin
    {
        ID = 0,
        Login,
        Password,
        UserIdFK,
        UserId,
        Name,

    }
    public class UserLogin : IEntity
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int UserIdFK { get; set; }

        public int UserId { get; set; }
        public string Name { get; set; }

        public UserLogin()
        {

        }
    }
}
