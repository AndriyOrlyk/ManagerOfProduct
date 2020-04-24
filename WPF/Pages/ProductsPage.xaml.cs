using Entity.Concrete;
using System.Windows;
using System.Windows.Controls;

namespace WPF
{
    /// <summary>
    /// Interaction logic for ProductsPage.xaml
    /// </summary>
    public partial class ProductsPage : Page
    {
        private ProductsPageViewModel viewModel;
        public ProductsPage()
        {
            InitializeComponent();
            viewModel = new ProductsPageViewModel();
            DataContext = viewModel;
        }



        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            grid.Items.Filter += (p) => ((Product)p).Name.Contains(Search.Text);
        }
    }
}
