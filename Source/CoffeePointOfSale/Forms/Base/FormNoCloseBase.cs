using CoffeePointOfSale.Configuration;

namespace CoffeePointOfSale.Forms.Base;

public class FormNoCloseBase : FormBase
{
    //https://stackoverflow.com/a/7301828
    private const int CP_NOCLOSE_BUTTON = 0x200;

    public FormNoCloseBase()
    {
        //this constructor is ONLY for design time layout. Do NOT put anything else here.
        HideControlBox();
    }

    public FormNoCloseBase(IAppSettings appSettings) : base(appSettings)
    {
        HideControlBox();
    }

    private void HideControlBox()
    {
        this.ControlBox = false;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
    }

    protected override CreateParams CreateParams
    {
        get
        {
            var controlParams = base.CreateParams;
            controlParams.ClassStyle |= CP_NOCLOSE_BUTTON;
            return controlParams;
        }
    }

    private void InitializeComponent()
    {
            this.SuspendLayout();
            // 
            // FormNoCloseBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.ControlBox = false;
            this.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNoCloseBase";
            this.Text = "App AnonymousCustomerId Not Set";
            this.Load += new System.EventHandler(this.FormNoCloseBase_Load);
            this.ResumeLayout(false);

    }

    private void FormNoCloseBase_Load(object sender, EventArgs e)
    {

    }
}