using System;
using System.Windows.Forms;
namespace WindFormManager
{
    public partial class Menu : Form
    {
        Entity.Concrete.User User { get; set; }

        public Menu()
        {
            InitializeComponent();
        }

        public Menu(Entity.Concrete.User user) : this()
        {
            User = user;
        }

        private void buttonName_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.ShowDialog();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.ShowDialog();
        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product(User);
            product.Show();
            Close();
        }

        private void buttonSaleHistory_Click(object sender, EventArgs e)
        {
            SaleHistory saleHistory = new SaleHistory();
            saleHistory.ShowDialog();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Close();

            new Login().Show();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            new Order(User).Show();
        }
    }
}
