using CrmBL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmUI
{
    public partial class ProductForm : Form
    {
        public Product Product { get; set; }
        public ProductForm()
        {
            InitializeComponent();
        }
        public ProductForm(Product product) : this()
        {
            Product = product;
            txbName.Text = Product.Name;
            numericUpDown1.Value = Product.Price;
            numericUpDown2.Value = Product.Count;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var p = Product ?? new Product();

            p.Name = txbName.Text;

            p.Price = numericUpDown1.Value;

            p.Count = Convert.ToInt32(numericUpDown2.Value);

            Close();
        }
    }
}
