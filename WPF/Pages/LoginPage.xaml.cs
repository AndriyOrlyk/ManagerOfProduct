using System.Windows.Controls;

namespace WPF
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        private LoginPageViewModel viewModel;
        public LoginPage()
        {
            InitializeComponent();
            viewModel = new LoginPageViewModel();
            DataContext = viewModel;
        }

        private void Login_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuPage(viewModel.GetUser(loginBox.Text, passBox.Password)));
        }
    }
}
