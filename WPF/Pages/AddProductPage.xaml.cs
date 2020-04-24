using BLogic;
using Entity.Concrete;
using System.Windows;
using System.Windows.Controls;

namespace WPF
{
    /// <summary>
    /// Interaction logic for AddProductPage.xaml
    /// </summary>
    public partial class AddProductPage : Page
    {
        BL BL;
        public AddProductPage()
        {
            InitializeComponent();
            BL = new BL();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            var product = new Product()
            {
                Company = Company.Text,
                Count = 0,
                Description = Description.Text,
                Name = nameBox.Text,
                Price = int.Parse(price.Text),
            };
            BL.AddProduct(product);
            MessageBox.Show("Product added!"); 
            NavigationService.GoBack();

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
