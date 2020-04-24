using Entity.Concrete;
using System.Windows.Controls;

namespace WPF
{
    /// <summary>
    /// Interaction logic for MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        private MenuPageViewModel viewModel;
        public MenuPage()
        {
            InitializeComponent();
        }

        public MenuPage(User user) : this()
        {
            viewModel = new MenuPageViewModel();
            viewModel.User = user;
            DataContext = viewModel;
        }

        private void LogOutBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new LoginPage());
        }

        private void Products_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProductsPage());
        }

        private void Order_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new OrderPage(viewModel.User));
        }

        private void AddProduct_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddProductPage());
        }
    }
}
