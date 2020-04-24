using BLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindFormManager
{
    public partial class Product : Form
    {
        private Entity.Concrete.User User { get; set; }
        private BL BL;
        private List<Entity.Concrete.Product> Products;
        public Product()
        {
            InitializeComponent();
        }

        public Product(Entity.Concrete.User user) : this()
        {
            User = user;
            BL = new BL();
            dataGridView1.AutoGenerateColumns = false;
            Products = BL.GetProducts();
            dataGridView1.DataSource = Products;


        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Menu(User).Show();
            Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                dataGridView1.DataSource = Products;
            }
            else
            {
                dataGridView1.DataSource = Products.Where((p) => p.Name.Contains(textBox1.Text)).ToList();

            }
        }
    }
}
