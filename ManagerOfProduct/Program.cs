using DAL;
using ManagerOfProduct1;


namespace ManagerOfProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionManager conn = new ConnectionManager();
            Menu menu = new Menu();
            menu.ChooseTable();
        }
    }
}
