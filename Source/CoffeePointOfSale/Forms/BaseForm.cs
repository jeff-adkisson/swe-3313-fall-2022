using CoffeePointOfSale.Configuration;

namespace CoffeePointOfSale.Forms;

public class FormBase : Form
{
    public FormBase()
    {
        //this constructor is ONLY for design time layout. Do NOT put anything else here.
    }

    public FormBase(IAppSettings appSettings) : this()
    {
        AppSettings = appSettings;
        InitializeComponent();
    }

    protected IAppSettings AppSettings { get; init; } = new AppSettings();

    private void InitializeComponent()
    {
        this.SuspendLayout();
        // 
        // FormBase
        // 
        this.ClientSize = new System.Drawing.Size(282, 253);
        this.Name = "FormBase";
        this.ResumeLayout(false);
    }

    /// <summary>
    /// Helper method to set the form title
    /// </summary>
    /// <param name="title"></param>
    protected void SetTitle(string title = "")
    {
        Text = string.IsNullOrWhiteSpace(title)
            ? AppSettings.App.Name
            : $"{title} | {AppSettings.App.Name}";
    }
}