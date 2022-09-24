using CoffeePointOfSale.Configuration;

namespace CoffeePointOfSale.Forms;

public class FormNoCloseBase : FormBase
{
    public FormNoCloseBase()
    {
        //this constructor is ONLY for design time layout. Do NOT put anything else here.
    }

    public FormNoCloseBase(IAppSettings appSettings) : base(appSettings)
    {
        InitializeComponent();
        ControlBox = false; //hide min max close X
    }

    //https://stackoverflow.com/a/7301828
    private const int CP_NOCLOSE_BUTTON = 0x200;
    protected override CreateParams CreateParams
    {
        get
        {
            var controlParams = base.CreateParams;
            controlParams.ClassStyle |= CP_NOCLOSE_BUTTON ;
            return controlParams;
        }
    }

    private void InitializeComponent()
    {
            this.SuspendLayout();
            // 
            // FormNoCloseBase
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "FormNoCloseBase";
            this.ResumeLayout(false);

    }
}