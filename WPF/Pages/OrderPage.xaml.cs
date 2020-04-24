using BLogic;
using Entity.Concrete;
using System.Windows;
using System.Windows.Controls;

namespace WPF
{
    /// <summary>
    /// Interaction logic for OrderPage.xaml
    /// </summary>
    public partial class OrderPage : Page
    {
        private OrderPageViewModel viewModel;
        private BL BL;
        public OrderPage()
        {
            InitializeComponent();
        }

        public OrderPage(User user) : this()
        {
            viewModel = new OrderPageViewModel();
            viewModel.User = user;
            DataContext = viewModel;
            BL = new BL();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var Order = new Order()
            {
                Count = int.Parse(countBox.Text),
                Id_User = viewModel.User.Id,
                Id_Product = (product.SelectedItem as Product).Id
            };

            BL.AddOrder(Order);

            MessageBox.Show("Order maked!");
            countBox.Text = "";
            product.SelectedItem = null;

        }

        private void BackBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuPage(viewModel.User));
        }
    }
}
