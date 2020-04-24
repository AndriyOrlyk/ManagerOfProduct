using DAL.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace DAL.Concrete
{
    public class LoginDAL : ADalCrud<Login>
    {
        public LoginDAL() : base()
        {
        }

        // class ADalRead
        protected override string GetTableName()
        {
            return "tblLogin";
        }

        protected override Login CreateInstance(ICollection<string> args)
        {
            List<string> parameters = args.ToList<string>();
            Login login = new Login()
            {
                Id = Convert.ToInt32(parameters[Convert.ToInt32(ELogin.LoginID)]),
                Login_ = parameters[Convert.ToInt32(ELogin.Login)],
                Password = parameters[Convert.ToInt32(ELogin.Password)],
                UserId = Convert.ToInt32(parameters[Convert.ToInt32(ELogin.UserId)])
            };
            return login;
        }

        // class ADalCrud
        protected override IDictionary<string, string> GetValues(Login login)
        {
            // TODO Use Enum
            IDictionary<string, string> result = new Dictionary<string, string>
            {
                { ELogin.LoginID.ToString().ToLower(), login.Id.ToString() },
                { ELogin.Login.ToString().ToLower(), login.Login_.ToString() },
                { ELogin.Password.ToString().ToLower(), login.Password.ToString() },
                { ELogin.UserId.ToString().ToLower(), login.UserId.ToString() }
            };

            return result;
        }
        public long CheckLogin(string login, string password)
        {
            long s = 0;
            ConnectionManager.Get().GetConnection();
            SqlCommand comm = ConnectionManager.Get().GetConnection().CreateCommand();
            comm.CommandText = "Select UserID FROM tblLogin where Login=@Login and Password=@Password;";
            comm.Parameters.Clear();
            Console.WriteLine(login);
            Console.WriteLine(password);
            comm.Parameters.AddWithValue("@Login", login);
            comm.Parameters.AddWithValue("@Password", password);
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                s = Convert.ToInt64(reader["UserID"]);
                Console.WriteLine(s);
            }
            reader.Close();
            ConnectionManager.Get().GetConnection().Close();
            return s;
        }
        public string GetHashStringSHA256(string str)
        {
            SHA256 sHA256 = SHA256.Create();
            byte[] hashPassword = sHA256.ComputeHash(Encoding.UTF8.GetBytes(str));
            string result = "";
            foreach (byte b in hashPassword)
            {
                result += b.ToString();
            }
            return result;
        }

        protected override string GetTableIdName()
        {
            return "Login";
        }
    }
}
