using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.FormFactory;
using Microsoft.Extensions.Logging;
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
        List<Button> buttons = new List<Button>();
        public FormCustomerList(IAppSettings appSettings, ICustomerService customerService)
        {
            InitializeComponent();
            _appSettings = appSettings;
            _customerService = customerService;
        }

        private void FormCustomerList_Load(object sender, EventArgs e)
        {
            DemonstrateGettingCustomerList();
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

        private void DemonstrateGettingCustomerList()
        {
            int top = 40;
            int left = 950;
            var customerList = _customerService.Customers.List;
            for (var customerIdx = 0; customerIdx < customerList.Count; customerIdx++)
            {
                var customer = customerList[customerIdx];
                listBox1.Items.Add($"{customerIdx + 1}. {customer}{Environment.NewLine}");
                CreateButton(customer,top,left);
                top += 50;
            }
        }
        private void CreateButton(Customer customer,int top, int left)
        {

            Button button = new Button();
            button.Size = new Size(100, 27);
            button.Name = customer.FirstName;
            button.Text = "Order Drink";
            button.ForeColor = Color.Transparent;
            button.TextAlign = ContentAlignment.MiddleCenter;
            button.BackColor = Color.SteelBlue;
            button.Left = left;
            button.Top = top;
            this.Controls.Add(button);
            button.Click += new EventHandler(orderDrinkClick);
            buttons.Add(button);
            
        }
         private void orderDrinkClick(object sender, EventArgs e)

        {
            Close();
            FormFactory.Get<FormOrderDrink>().Show();
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
