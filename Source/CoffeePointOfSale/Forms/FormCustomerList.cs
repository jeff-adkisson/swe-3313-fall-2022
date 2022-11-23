using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.FormFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeePointOfSale.Forms
{
    public partial class FormCustomerList : Base.FormNoCloseBase
    {
        private IAppSettings? _appSettings;
        private readonly ICustomerService _customerService;

        public FormCustomerList(IAppSettings appSettings, ICustomerService customerService)
        {
            InitializeComponent();
            _appSettings = appSettings;
            _customerService = customerService;
        }

        private void FormCustomerList_Load(object sender, EventArgs e)
        {

        }

        private void bMM_CustList_Click(object sender, EventArgs e)
        {
            Close();
            FormFactory.Get<FormMain>().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            FormFactory.Get<FormAddCustomer>().Show();
        }
    }
}
