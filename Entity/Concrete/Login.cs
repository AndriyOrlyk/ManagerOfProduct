using Entity.Abstract;

namespace Entity.Concrete
{
    public enum ELogin
    {
        LoginID,
        Login,
        Password,
        UserId,
    }
    public class Login : IEntity
    {
        public int Id { get; set; }
        public string Login_ { get; set; }
        public string Password { get; set; }
        public int UserId { get; set; }
    }
}
