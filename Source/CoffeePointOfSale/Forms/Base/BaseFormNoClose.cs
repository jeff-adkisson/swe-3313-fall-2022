using CoffeePointOfSale.Configuration;

namespace CoffeePointOfSale.Forms.Base;

public class FormNoCloseBase : FormBase
{
    //https://stackoverflow.com/a/7301828
    private const int CP_NOCLOSE_BUTTON = 0x200;

    public FormNoCloseBase()
    {
        //this constructor is ONLY for design time layout. Do NOT put anything else here.
        InitializeComponent();
    }

    public FormNoCloseBase(IAppSettings appSettings) : base(appSettings)
    {
        InitializeComponent();
        ControlBox = false; //hide min max close X
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
        SuspendLayout();
        // 
        // FormNoCloseBase
        // 

        ClientSize = new Size(1348, 721);
        StartPosition = FormStartPosition.CenterScreen;
        Name = "FormNoCloseBase";
        ResumeLayout(false);
    }
}