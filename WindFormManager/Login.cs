using BLogic;
using System;
using System.Windows.Forms;

namespace WindFormManager
{
    public partial class Login : Form
    {

        BL BL;
        public Login()
        {
            InitializeComponent();
            BL = new BL();
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            var Name = textBoxLogin.Text;
            var Password = textBoxPassword.Text;

            if(!string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Password)) 
            {

            }

        }


        private void SignIn_Click(object sender, EventArgs e)
        {
            var login = textBoxLogin.Text;
            var pass = textBoxPassword.Text;
            var user = BL.GetUser(login, pass);
            Hide();
            new Menu(user).Show();

        }

    }
}
