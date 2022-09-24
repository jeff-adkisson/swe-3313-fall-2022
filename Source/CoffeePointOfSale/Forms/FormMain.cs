using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.FormFactory;

namespace CoffeePointOfSale.Forms;

public partial class FormMain : FormBase
{
    public FormMain(IAppSettings appSettings) : base(appSettings)
    {
        InitializeComponent();
    }

    private void OnClickBtnManagement(object sender, EventArgs e)
    {
        Hide();
        FormFactory.Get<FormManagement>().ShowDialog();
    }

    private void OnLoad(object sender, EventArgs e)
    {
        ConfigureWindow(); //sets window to proper size and position - all forms should all this at start of OnLoad
        SetTitle();
    }
}