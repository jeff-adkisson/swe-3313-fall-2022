using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.FormFactory;

namespace CoffeePointOfSale.Forms;

public partial class FormMain : FormBase
{
    public FormMain(IAppSettings appSettings) : base(appSettings)
    {
        InitializeComponent();
        ConfigureWindow();
    }

    private void OnClickBtnManagement(object sender, EventArgs e)
    {
        this.Hide();
        FormFactory.Get(typeof(FormManagement)).ShowDialog();
    }

    private void OnLoad(object sender, EventArgs e)
    {
        SetTitle();
    }
}