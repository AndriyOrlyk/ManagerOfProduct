using DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Entity.Concrete
{
    public class UserDAL : ADalCrud<User>
    {
        public UserDAL() : base()
        {
        }

        // class ADalRead
        protected override string GetTableName()
        {
            return "tblUser";
        }

        protected override User CreateInstance(ICollection<string> args)
        {
            List<string> parameters = args.ToList<string>();
            User user = new User(parameters[Convert.ToInt32(EUser.NAME)])
            {
                Id = Convert.ToInt32(parameters[Convert.ToInt32(EUser.ID)]),
                Name = parameters[Convert.ToInt32(EUser.NAME)]
            };
            return user;
        }

        // class ADalCrud
        protected override IDictionary<string, string> GetValues(User user)
        {
            // TODO Use Enum
            IDictionary<string, string> result = new Dictionary<string, string>();
            result.Add(EUser.ID.ToString().ToLower(), user.Id.ToString());
            result.Add(EUser.NAME.ToString().ToLower(), user.Name);
            return result;
        }

        protected override string GetTableIdName()
        {
            return "User";
        }
    }
}
