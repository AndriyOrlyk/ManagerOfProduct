using BLogic;
using Entity.Concrete;

namespace WPF
{
    class LoginPageViewModel
    {
        BL BL;
        public LoginPageViewModel()
        {
            BL = new BL();
        }

        public User GetUser(string login, string password)
        {
            return BL.GetUser(login, password);
        }

    }
}
