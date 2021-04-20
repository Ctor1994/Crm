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
    public partial class SallerForm : Form
    {
        public Seller Seller { get; set; }

        public SallerForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Seller = new Seller()
            {
                Name = txbName.Text
            };
            Close();
        }
    }
}
