using DAL;
using DAL.Concrete;
using Entity.Concrete;
using ENTITY;
using System;

namespace ManagerOfProduct1
{
    public class Menu : ConnectionManager
    {
        public void ChooseTable()
        {
            Console.Clear();
            Console.WriteLine("Welcome to start page!\n\n");
            Console.WriteLine("What table you want to choose?\n1. Users\n2. SaleHistory\n3. Order\n4. Product ");
            Console.WriteLine("\nYour selection: ");
            string ch = Console.ReadLine();

            switch (ch)
            {
                case "1":
                    {
                        ChooseUser();
                        break;
                    }

                case "2":
                    {
                        ChooseSaleHistory();
                        break;
                    }

                case "3":
                    {
                        ChooseOrder();
                        break;
                    }

                case "4":
                    {
                        ChooseProduct();
                        break;
                    }
                default:
                    Console.WriteLine("Invalid selection. Please select 1, 2, 3 or 4.");
                    break;
            }
        }

        public void ChooseUser()
        {
            UserDAL userDal = new UserDAL();

            Console.Clear();
            Console.WriteLine("TABLE: USERS\n\n");
            Console.WriteLine("What action you want to choose?\n" +
                          "1. View all users\n" +
                          "2. Get user by Id\n" +
                          "3. Get user by name of column\n" +
                          "4. Add user\n" +
                          "5. Edit info about user\n" +
                          "6. Delete user by Id\n" +
                          "7. Delete user by name of column\n" +
                          "8. Back to start menu");
            Console.Write("\nYour selection: ");

            string ch = Console.ReadLine();
            switch (ch)
            {
                case "1":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: tblUser\n\n");

                            //   userDal.PrintListOfUser(userDal.GetAll());
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseUser();
                        }
                    }

                case "2":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: USERS\n\nId: ");

                            int id = Convert.ToInt32(Console.ReadLine());
                            //userDal.PrintUser(userDal.GetById(id));
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseUser();
                        }
                    }

                case "3":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: USERS\n\n");

                            Console.WriteLine("Name of column: ");
                            string fieldName = Console.ReadLine();
                            Console.WriteLine("\nValue: ");
                            string text = Console.ReadLine();
                            //   userDal.PrintListOfUser(userDal.GetByFieldName(fieldName, text));
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseUser();
                        }
                    }

                case "4":
                    {
                        try
                        {


                            Console.Clear();
                            Console.WriteLine("TABLE: USERS\n\n");

                            Console.WriteLine("NAME: ");
                            string name = Console.ReadLine();

                            User user = new User(name);
                            userDal.Insert(user);

                            Console.WriteLine("User succesfully inserted.");
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseUser();
                        }
                    }

                case "5":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: USERS\n\n");

                            Console.WriteLine("Name of column (set): ");
                            string fieldName = Console.ReadLine();

                            Console.WriteLine("Value (set): ");
                            string text = Console.ReadLine();

                            Console.WriteLine("Name of column (condition): ");
                            string fieldCondition = Console.ReadLine();

                            Console.WriteLine("Value (condition): ");
                            string textCondition = Console.ReadLine();

                            userDal.UpdateByFieldName(fieldName, text, fieldCondition, textCondition);

                            Console.WriteLine("User succesfully updated.");
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseUser();
                        }
                    }

                case "6":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: USERS\n\nId: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            userDal.deleteById(id);

                            Console.WriteLine("User succesfully deleted.");
                            Console.ReadKey();
                            break;
                        }

                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseUser();
                        }
                    }

                case "7":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: USERS\n\n ");

                            Console.WriteLine("Name of column (condition): ");
                            string fieldCondition = Console.ReadLine();

                            Console.WriteLine("Value (condition): ");
                            string textCondition = Console.ReadLine();

                            userDal.deleteByFieldName(fieldCondition, textCondition);

                            Console.WriteLine("User succesfully deleted.");
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseUser();
                        }
                    }

                case "8":
                    {
                        Menu menu = new Menu();
                        menu.ChooseTable();
                        break;
                    }

                default:
                    Console.WriteLine("Invalid selection. Please select 1, 2, 3, 4, 5, 6, 7 or 8.");
                    break;
            }
        }

        public void ChooseOrder()
        {
            OrderDAL orderDAL = new OrderDAL();

            Console.Clear();
            Console.WriteLine("TABLE: ORDER\n\n");
            Console.WriteLine("What action you want to choose?\n" +
                          "1. View all Order\n" +
                          "2. Get Order by Id\n" +
                          "3. Get Order by name of column\n" +
                          "4. Add Order\n" +
                          "5. Edit info about Order\n" +
                          "6. Delete Order by Id\n" +
                          "7. Delete Order by name of column\n" +
                          "8. Back to start menu");
            Console.Write("\nYour selection: ");

            string ch = Console.ReadLine();
            switch (ch)
            {
                case "1":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: ORDER\n\n");

                            orderDAL.PrintListOfOrder(orderDAL.GetAll());
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseOrder();
                        }
                    }

                case "2":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: ORDER\n\nId: ");

                            int id = Convert.ToInt32(Console.ReadLine());
                            orderDAL.PrintOrder(orderDAL.GetById(id));
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseOrder();
                        }
                    }

                case "3":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: ORDER\n\n");

                            Console.WriteLine("Name of column: ");
                            string fieldName = Console.ReadLine();
                            Console.WriteLine("\nValue: ");
                            string text = Console.ReadLine();
                            orderDAL.PrintListOfOrder(orderDAL.GetByFieldName(fieldName, text));
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseOrder();
                        }
                    }

                case "4":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: ORDER\n\n");

                            Console.WriteLine("COUNT: ");
                            int count = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("UserID");
                            int user_id = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("ProductID");
                            int product_id = Convert.ToInt32(Console.ReadLine());

                            Order order = new Order(count, user_id, product_id);
                            orderDAL.Insert(order);

                            Console.WriteLine("SaleHistory succesfully inserted.");
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseOrder();
                        }
                    }

                case "5":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: ORDER\n\n");

                            Console.WriteLine("Name of column (set): ");
                            string fieldName = Console.ReadLine();

                            Console.WriteLine("Value (set): ");
                            string text = Console.ReadLine();

                            Console.WriteLine("Name of column (condition): ");
                            string fieldCondition = Console.ReadLine();

                            Console.WriteLine("Value (condition): ");
                            string textCondition = Console.ReadLine();

                            orderDAL.UpdateByFieldName(fieldName, text, fieldCondition, textCondition);

                            Console.WriteLine("SaleHistory succesfully updated.");
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseOrder();
                        }
                    }

                case "6":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: Order\n\nId: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            orderDAL.deleteById(id);

                            Console.WriteLine("Order succesfully deleted.");
                            Console.ReadKey();
                            break;
                        }

                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseSaleHistory();
                        }
                    }

                case "7":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: ORDER\n\n ");

                            Console.WriteLine("Name of column (condition): ");
                            string fieldCondition = Console.ReadLine();

                            Console.WriteLine("Value (condition): ");
                            string textCondition = Console.ReadLine();

                            orderDAL.deleteByFieldName(fieldCondition, textCondition);

                            Console.WriteLine("SaleHistory succesfully deleted.");
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseOrder();
                        }
                    }

                case "8":
                    {
                        Menu menu = new Menu();
                        menu.ChooseTable();
                        break;
                    }

                default:
                    Console.WriteLine("Invalid selection. Please select 1, 2, 3, 4, 5, 6, 7 or 8.");
                    break;
            }
        }

        public void ChooseSaleHistory()
        {
            SaleHistoryDAL saleHistoryDAL = new SaleHistoryDAL();

            Console.Clear();
            Console.WriteLine("TABLE: SALEHISTORY\n\n");
            Console.WriteLine("What action you want to choose?\n" +
                          "1. View all SaleHistories\n" +
                          "2. Get SaleHistories by Id\n" +
                          "3. Get SaleHistories by name of column\n" +
                          "4. Add SaleHistories\n" +
                          "5. Edit info about SaleHistories\n" +
                          "6. Delete SaleHistories by Id\n" +
                          "7. Delete SaleHistories by name of column\n" +
                          "8. Back to start menu");
            Console.Write("\nYour selection: ");

            string ch = Console.ReadLine();
            switch (ch)
            {
                case "1":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: SALEHISTORY\n\n");

                            saleHistoryDAL.PrintListOfSaleHistory(saleHistoryDAL.GetAll());
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseSaleHistory();
                        }
                    }

                case "2":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: SALEHISTORY\n\nId: ");

                            int id = Convert.ToInt32(Console.ReadLine());
                            saleHistoryDAL.PrintSaleHistory(saleHistoryDAL.GetById(id));
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseSaleHistory();
                        }
                    }

                case "3":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: SALEHISTORY\n\n");

                            Console.WriteLine("Name of column: ");
                            string fieldName = Console.ReadLine();
                            Console.WriteLine("\nValue: ");
                            string text = Console.ReadLine();
                            saleHistoryDAL.PrintListOfSaleHistory(saleHistoryDAL.GetByFieldName(fieldName, text));
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseSaleHistory();
                        }
                    }

                case "4":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: SALEHISTORY\n\n");

                            Console.WriteLine("COUNT: ");
                            int count = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("DATEORDERED");
                            string dateTimeOrdered = Console.ReadLine();

                            Console.WriteLine("DATEDELIVERY");
                            string dateTimeDelivery = Console.ReadLine();

                            Console.WriteLine("ID_PRODUCT");
                            int id_product = Convert.ToInt32(Console.ReadLine());

                            SaleHistory saleHistory = new SaleHistory(count, dateTimeOrdered, dateTimeDelivery, id_product);
                            saleHistoryDAL.Insert(saleHistory);

                            Console.WriteLine("SaleHistory succesfully inserted.");
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseSaleHistory();
                        }
                    }

                case "5":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: SALEHISTORY\n\n");

                            Console.WriteLine("Name of column (set): ");
                            string fieldName = Console.ReadLine();

                            Console.WriteLine("Value (set): ");
                            string text = Console.ReadLine();

                            Console.WriteLine("Name of column (condition): ");
                            string fieldCondition = Console.ReadLine();

                            Console.WriteLine("Value (condition): ");
                            string textCondition = Console.ReadLine();

                            saleHistoryDAL.UpdateByFieldName(fieldName, text, fieldCondition, textCondition);

                            Console.WriteLine("SaleHistory succesfully updated.");
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseSaleHistory();
                        }
                    }

                case "6":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: SALEHISTORY\n\nId: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            saleHistoryDAL.deleteById(id);

                            Console.WriteLine("SaleHistroy succesfully deleted.");
                            Console.ReadKey();
                            break;
                        }

                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseSaleHistory();
                        }
                    }

                case "7":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: SALEHISTORY\n\n ");

                            Console.WriteLine("Name of column (condition): ");
                            string fieldCondition = Console.ReadLine();

                            Console.WriteLine("Value (condition): ");
                            string textCondition = Console.ReadLine();

                            saleHistoryDAL.deleteByFieldName(fieldCondition, textCondition);

                            Console.WriteLine("SaleHistory succesfully deleted.");
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseSaleHistory();
                        }
                    }

                case "8":
                    {
                        Menu menu = new Menu();
                        menu.ChooseTable();
                        break;
                    }

                default:
                    Console.WriteLine("Invalid selection. Please select 1, 2, 3, 4, 5, 6, 7 or 8.");
                    break;
            }
        }


        public void ChooseProduct()
        {
            ProductDAL productDAL = new ProductDAL();

            Console.Clear();
            Console.WriteLine("TABLE: PRODUCT\n\n");
            Console.WriteLine("What action you want to choose?\n" +
                          "1. View all SaleHistories\n" +
                          "2. Get Product by Id\n" +
                          "3. Get Product by name of column\n" +
                          "4. Add Product\n" +
                          "5. Edit info about Product\n" +
                          "6. Delete Product by Id\n" +
                          "7. Delete Product by name of column\n" +
                          "8. Back to start menu");
            Console.Write("\nYour selection: ");

            string ch = Console.ReadLine();
            switch (ch)
            {
                case "1":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: PRODUCT\n\n");

                            //   productDAL.PrintListOfProduct(productDAL.GetAll());
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseProduct();
                        }
                    }

                case "2":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: PRODUCT\n\nId: ");

                            int id = Convert.ToInt32(Console.ReadLine());
                            //  productDAL.PrintProduct(productDAL.GetById(id));
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseProduct();
                        }
                    }

                case "3":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: PRODUCT\n\n");

                            Console.WriteLine("Name of column: ");
                            string fieldName = Console.ReadLine();
                            Console.WriteLine("\nValue: ");
                            string text = Console.ReadLine();
                            //    productDAL.PrintListOfProduct(productDAL.GetByFieldName(fieldName, text));
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseProduct();
                        }
                    }

                case "4":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: PRODUCT\n\n");

                            Console.WriteLine("Enter Name: ");
                            string name = Console.ReadLine();

                            Console.WriteLine("Enter Price: ");
                            double price = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Enter Catalog: ");
                            int count = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Description: ");
                            string description = Console.ReadLine();

                            Console.WriteLine("Enter Company: ");
                            string company = Console.ReadLine();

                            Product product = new Product(name, price, count, description, company);
                            productDAL.Insert(product);

                            Console.WriteLine("Product succesfully inserted.");
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseProduct();
                        }
                    }

                case "5":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: PRODUCT\n\n");

                            Console.WriteLine("Name of column (set): ");
                            string fieldName = Console.ReadLine();

                            Console.WriteLine("Value (set): ");
                            string text = Console.ReadLine();

                            Console.WriteLine("Name of column (condition): ");
                            string fieldCondition = Console.ReadLine();

                            Console.WriteLine("Value (condition): ");
                            string textCondition = Console.ReadLine();

                            productDAL.UpdateByFieldName(fieldName, text, fieldCondition, textCondition);

                            Console.WriteLine("Product succesfully updated.");
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseProduct();
                        }
                    }

                case "6":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: PRODUCT\n\nId: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            productDAL.deleteById(id);

                            Console.WriteLine("Product succesfully deleted.");
                            Console.ReadKey();
                            break;
                        }

                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseProduct();
                        }
                    }

                case "7":
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("TABLE: PRODUCT\n\n ");

                            Console.WriteLine("Name of column (condition): ");
                            string fieldCondition = Console.ReadLine();

                            Console.WriteLine("Value (condition): ");
                            string textCondition = Console.ReadLine();

                            productDAL.deleteByFieldName(fieldCondition, textCondition);

                            Console.WriteLine("Product succesfully deleted.");
                            Console.ReadKey();
                            break;
                        }
                        finally
                        {
                            Menu menu = new Menu();
                            menu.ChooseProduct();
                        }
                    }

                case "8":
                    {
                        Menu menu = new Menu();
                        menu.ChooseTable();
                        break;
                    }

                default:
                    Console.WriteLine("Invalid selection. Please select 1, 2, 3, 4, 5, 6, 7 or 8.");
                    break;
            }
        }
    }
}