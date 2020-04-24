using BLogic;
using System.Windows.Forms;

namespace WindFormManager
{
    public partial class Order : Form
    {
        private Entity.Concrete.User user;
        private BL BL;
        public Order()
        {
            InitializeComponent();
        }

        public Order(Entity.Concrete.User user):this()
        {
            this.user = user;
            BL = new BL();
            comboBox1.DataSource = BL.GetProducts();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var Order = new Entity.Concrete.Order()
            {
                Count = int.Parse(textBoxCount.Text),
                Id_User = user.Id,
                Id_Product = (comboBox1.SelectedItem as Entity.Concrete.Product).Id,
                
            };

            BL.AddOrder(Order);

            MessageBox.Show("Order maked");
            Close();
            new Menu(user).Show();
        }
    }
}
