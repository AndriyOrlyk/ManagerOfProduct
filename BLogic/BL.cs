using DAL.Concrete;
using Entity.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace BLogic
{
    public class BL
    {
        LoginDAL loginDAL;
        OrderDAL orderDAL;
        ProductDAL productDAL;
        SaleHistoryDAL historyDAL;
        UserDAL userDAL;
        UserLoginDAL userLoginDAL;

        public BL()
        {
            loginDAL = new LoginDAL();
            orderDAL = new OrderDAL();
            productDAL = new ProductDAL();
            historyDAL = new SaleHistoryDAL();
            userDAL = new UserDAL();
            userLoginDAL = new UserLoginDAL();
        }


        /// <summary>
        /// Add product into the DataBase
        /// </summary>
        /// <param name="product"></param>
        public void AddProduct(Product product)
        {
            productDAL.Insert(product);
        }

        /// <summary>
        /// Insert user into the DataBase
        /// </summary>
        /// <param name="user">User to insert</param>
        public void AddUser(User user)
        {
            userDAL.Insert(user);
        }


        /// <summary>
        /// Get user by login and password
        /// </summary>
        /// <param name="login">User login</param>
        /// <param name="password">User password</param>
        /// <returns>Null if user is not exists</returns>
        public User GetUser(string login, string password)
        {
            var userLogin = userLoginDAL.GetAll().Where((ul) => ul.Login == login && ul.Password == password).FirstOrDefault();

            var user = new User()
            {
                Id = userLogin.UserId,
                Name = userLogin.Name,
            };

            return user ?? null;

        }

        /// <summary>
        /// Get all products from DateBase
        /// </summary>
        /// <returns>List of all products</returns>
        public List<Product> GetProducts()
        {
            return productDAL.GetAll().ToList();
        }

        /// <summary>
        /// Insert order into the DateBase and update count of product
        /// </summary>
        /// <param name="order"></param>
        public void AddOrder(Order order)
        {
            Product product = productDAL.GetById(order.Id_Product);
            product.Count += order.Count;
            productDAL.UpdateByEntity(product);
            orderDAL.Insert(order);
        }
    }
}
