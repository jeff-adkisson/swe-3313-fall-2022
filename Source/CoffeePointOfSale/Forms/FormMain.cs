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
        FormFactory.Get<FormManagement>().Show();
    }

    private void OnFormMainClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }

    private void btnAnonOrder(object sender, EventArgs e)
    {
        Hide();
        //FormFactory.Get<FormPayment>().Show();
    }

    private void btncustomerlist_Click(object sender, EventArgs e)
    {
        Hide();
        FormFactory.Get<FormCustomerList>().Show();
    }
}