using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WojciechLiebertLab5.Model;


namespace WojciechLiebertLab5
{
    public partial class FormMain : Form
    {
        Model.DataClasses1DataContext dataContext = new DataClasses1DataContext();
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            IQueryable<Product> query = Model.Product.GetAllProducts(dataContext);
            dataGridViewDisplay.DataSource = null;
            dataGridViewDisplay.DataSource = query;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewDisplay.DataSource = null;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductName = textBoxProductName.Text;
            product.UnitPrice = Decimal.Parse(textBoxPricePerUnit.Text);
            dataContext.Products.InsertOnSubmit(product);
            dataContext.SubmitChanges();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Product newProduct = (from product in dataContext.Products where product.ProductName == textBoxProductName.Text select product).FirstOrDefault();
                dataContext.Products.DeleteOnSubmit(newProduct);
                dataContext.SubmitChanges();
                buttonDisplay.PerformClick();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Product newProduct = (from product in dataContext.Products where product.ProductName == textBoxProductName.Text select product).FirstOrDefault();
                newProduct.UnitPrice = Decimal.Parse(textBoxPricePerUnit.Text);
                newProduct.ProductName = textBoxProductName.Text;
                dataContext.SubmitChanges();
                buttonDisplay.PerformClick();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
