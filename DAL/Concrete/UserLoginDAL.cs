using DAL.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Concrete
{
    public class UserLoginDAL : ADalRead<UserLogin>
    {
        public UserLoginDAL() : base()
        {
        }

        protected override UserLogin CreateInstance(ICollection<string> args)
        {
            List<string> parameters = args.ToList();
            var userLogin = new UserLogin()
            {
                Id = Convert.ToInt32(parameters[Convert.ToInt32(EUserLogin.ID)]),
                Login = parameters[Convert.ToInt32(EUserLogin.Login)],
                Name = parameters[Convert.ToInt32(EUserLogin.Name)],
                Password = parameters[Convert.ToInt32(EUserLogin.Password)],
                UserId = Convert.ToInt32(parameters[Convert.ToInt32(EUserLogin.UserId)]),
                UserIdFK = Convert.ToInt32(parameters[Convert.ToInt32(EUserLogin.UserIdFK)]),
            };

            return userLogin;
        }

        protected override string GetTableIdName()
        {
            return "";
        }

        protected override string GetTableName()
        {
            return " [tblLogin] JOIN [tblUser] ON [tblLogin].UserId = [tblUser].UserID";
        }
    }
}
