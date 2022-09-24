using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.FormFactory;

namespace CoffeePointOfSale.Forms;

public partial class FormManagement : FormNoCloseBase
{
    private readonly ICustomerService _customerService;

    public FormManagement(IAppSettings appSettings, ICustomerService customerService) : base(appSettings)
    {
        _customerService = customerService;
        InitializeComponent();
    }

    private void OnClickBtnClose(object sender, EventArgs e)
    {
        Close(); //closes this form
        FormFactory.Get<FormMain>().Show(); //re-opens the main form
    }

    protected override void OnLoad(object sender, EventArgs e)
    {
        base.OnLoad(sender, e); //if we override OnLoad, we still need to call the base OnLoad method to setup the form in a standard fashion
        DemonstrateGettingCustomerList();
    }

    /// <summary>
    /// Remove this from your project... here to show you how to get the customer list
    /// </summary>
    private void DemonstrateGettingCustomerList()
    {
        var customerList = _customerService.Customers.List;
        for (var customerIdx = 0; customerIdx < customerList.Count; customerIdx++)
        {
            var customer = customerList[customerIdx];
            txtDeleteThis.AppendText($"{customerIdx + 1}. {customer}{Environment.NewLine}");
        }
    }
}