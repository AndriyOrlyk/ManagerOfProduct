
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Concrete;
using Entity.Concrete;

namespace WindFormManager
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            User user = new User();
            UserDAL userDAL = new UserDAL();
            var listOfUsers = userDAL.GetAll();
            textBoxName.Text = listOfUsers.First().Name;
        }

        private void User_Load(object sender, EventArgs e)
        {

        }
    }
}
