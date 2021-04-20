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

        private void btnOk_Click(object sender, EventArgs e)
        {
            Product = new Product()
            {
                Name = txbName.Text,
                Price = numericUpDown1.Value,
                Count = Convert.ToInt32(numericUpDown2.Value)
            };
            Close();
        }
    }
}
