using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.FormFactory;

namespace CoffeePointOfSale.Forms
{
    public partial class FormCustomerList : FormNoCloseBase
    {

        private readonly ICustomerService _customerService;
        public FormCustomerList(ICustomerService customerService)
        {
            _customerService = customerService;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Return to Main Menu
        {
            Close(); //closes this form
            FormFactory.Get<FormMain>().Show(); //re-opens the main form
        }

        private void button2_Click(object sender, EventArgs e) //Opens formAddCustomer
        {

        }
    }
}
