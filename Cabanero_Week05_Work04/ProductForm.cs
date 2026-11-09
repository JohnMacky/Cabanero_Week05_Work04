using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cabanero_Week05_Work04
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();

            btnsave.Click += btnsave_Click;
            btnclear.Click += btnclear_Click;
            btncancel.Click += btncancel_Click;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            decimal cost;
            decimal price;
            decimal markup;

            if (string.IsNullOrWhiteSpace(txtboxbarcode.Text) ||
                string.IsNullOrWhiteSpace(txtboxname.Text))
            {
                MessageBox.Show(
                    "Barcode and name are required.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!decimal.TryParse(txtboxcost.Text, out cost) ||
                !decimal.TryParse(txtboxprice.Text, out price) ||
                !decimal.TryParse(txtboxmarkup.Text, out markup))
            {
                MessageBox.Show(
                    "Cost, price, and markup must be valid numbers.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string origin = rbtnlocal.Checked ? "Local" :
                            rbtnabroad.Checked ? "Abroad" : "Not specified";

            ProductRecord product = new ProductRecord
            {
                Barcode = txtboxbarcode.Text.Trim(),
                Name = txtboxname.Text.Trim(),
                Description = txtboxdescription.Text.Trim(),
                Category = cboxcategory.Text.Trim(),
                Origin = origin,
                IsActive = cboxactive.Checked,
                Cost = cost,
                Price = price,
                Markup = markup
            };

            List.Products.Add(product);

            MessageBox.Show(
                "Product added successfully.",
                "Saved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            using (List productList = new List())
            {
                productList.ShowDialog();
                this.Hide();
            }

            ClearFields();
        }
        private void ClearFields()
        {
            txtboxbarcode.Clear();
            txtboxname.Clear();
            txtboxdescription.Clear();
            cboxcategory.SelectedIndex = -1;
            txtboxcost.Clear();
            txtboxprice.Clear();
            txtboxmarkup.Clear();
            cboxactive.Checked = false;
            rbtnlocal.Checked = false;
            rbtnabroad.Checked = false;
        }
    }
    
}
