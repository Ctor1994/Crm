﻿using CrmBL.Model;
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
    public partial class CustomerForm : Form
    {
        public Customer Customer { get; set; }

        public CustomerForm()
        {
            InitializeComponent();
        }
        public CustomerForm(Customer customer) : this()
        {
            Customer = customer;
            txbName.Text = customer.Name;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            var c = Customer ?? new Customer();

            c.Name = txbName.Text;
            
            Close();
        }
    }
}
