using CoffeePointOfSale.Configuration;

namespace CoffeePointOfSale.Forms.Base;

public class FormBase : Form
{
    public FormBase()
    {
        //this constructor is ONLY for design time layout. Do NOT put anything else here.
        InitializeComponent();
        ConfigureWindow();
        _appSettings = new AppSettings();
    }

    public FormBase(IAppSettings appSettings) : this()
    {
        _appSettings = appSettings;
        InitializeComponent();
    }

    private IAppSettings _appSettings;

    protected void ConfigureWindow()
    {
        InitializeComponent();
        PerformLayout();
    }

    private void InitializeComponent()
    {
            this.SuspendLayout();
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 674);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBase";
            this.Load += new System.EventHandler(this.OnLoadFormBase);
            this.ResumeLayout(false);

    }

    /// <summary>
    ///     Helper method to set the form title
    /// </summary>
    /// <param name="title"></param>
    protected void SetTitle(string title = "")
    {
        Text = string.IsNullOrWhiteSpace(title)
            ? _appSettings.App.Name
            : $"{title} | {_appSettings.App.Name}";
    }

    private void OnLoadFormBase(object sender, EventArgs e)
    {
        ConfigureWindow(); //sets window to proper size and position - all forms should all this at start of OnLoad
        SetTitle();
    }
}