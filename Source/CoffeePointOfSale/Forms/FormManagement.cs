using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Services.Customer;

namespace CoffeePointOfSale.Forms;

public partial class FormManagement : FormNoCloseBase
{
    private readonly ICustomerService _customerService;

    public FormManagement(IAppSettings appSettings, ICustomerService customerService) : base(appSettings)
    {
        _customerService = customerService;
        InitializeComponent();
        ConfigureWindow();
    }

    private void OnClickBtnClose(object sender, EventArgs e)
    {
        Close(); //closes this form
        Program.MainForm.Show(); //re-opens the main form
    }

    private void OnLoad(object sender, EventArgs e)
    {
        SetTitle("Management");
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