using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cabanero_Week05_Work04
{
    public partial class List : Form
    {
        public static readonly System.Collections.Generic.List<ProductRecord> Products =
            new System.Collections.Generic.List<ProductRecord>();
        public List()
        {
            InitializeComponent();
        }

        private void List_Load(object sender, EventArgs e)
        {
            DisplayProductInformation();
        }
        private void DisplayProductInformation()
        {
            if (Products.Count == 0)
            {
                lblBarcode.Text = "No product added";
                lblName.Text = "No product added";
                lblDesciption.Text = "No product added";
                lblCategory.Text = "No product added";
                lblOrigin.Text = "No product added";
                lblStatus.Text = "No product added";
                lblCost.Text = "No product added";
                lblPrice.Text = "No product added";
                lblMarkup.Text = "No product added";

                return;
            }

            ProductRecord product = Products[Products.Count - 1];

            lblBarcode.Text = product.Barcode;
            lblName.Text = product.Name;
            lblDesciption.Text = product.Description;
            lblCategory.Text = product.Category;
            lblOrigin.Text = product.Origin;
            lblStatus.Text = product.IsActive ? "Active" : "Inactive";
            lblCost.Text = product.Cost.ToString("0.00");
            lblPrice.Text = product.Price.ToString("0.00");
            lblMarkup.Text = product.Markup.ToString("0.00") + "%";

            Text = "Product Information";
            lblpinfo.Text = "Product Information";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            
            var productForm = new ProductForm();
            productForm.Show();
            this.Hide();
            
        }
    }
    public class ProductRecord
    {
        public string Barcode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Origin { get; set; }
        public bool IsActive { get; set; }
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
        public decimal Markup { get; set; }
    }
}
