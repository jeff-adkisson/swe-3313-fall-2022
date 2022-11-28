namespace CoffeePointOfSale.Forms;

sealed partial class FormMain
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.btnManagement = new System.Windows.Forms.Button();
            this.bCustList = new System.Windows.Forms.Button();
            this.bOrderDrink = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManagement
            // 
            this.btnManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnManagement.BackColor = System.Drawing.Color.SteelBlue;
            this.btnManagement.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnManagement.ForeColor = System.Drawing.Color.Transparent;
            this.btnManagement.Location = new System.Drawing.Point(473, 451);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.Size = new System.Drawing.Size(423, 211);
            this.btnManagement.TabIndex = 0;
            this.btnManagement.Text = "Management";
            this.btnManagement.UseVisualStyleBackColor = false;
            this.btnManagement.Click += new System.EventHandler(this.OnClickBtnManagement);
            // 
            // bCustList
            // 
            this.bCustList.BackColor = System.Drawing.Color.SteelBlue;
            this.bCustList.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bCustList.ForeColor = System.Drawing.Color.Transparent;
            this.bCustList.Location = new System.Drawing.Point(473, 232);
            this.bCustList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bCustList.Name = "bCustList";
            this.bCustList.Size = new System.Drawing.Size(423, 211);
            this.bCustList.TabIndex = 1;
            this.bCustList.Text = "Customer List";
            this.bCustList.UseVisualStyleBackColor = false;
            this.bCustList.Click += new System.EventHandler(this.bCustList_Click);
            // 
            // bOrderDrink
            // 
            this.bOrderDrink.BackColor = System.Drawing.Color.SteelBlue;
            this.bOrderDrink.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bOrderDrink.ForeColor = System.Drawing.Color.Transparent;
            this.bOrderDrink.Location = new System.Drawing.Point(473, 13);
            this.bOrderDrink.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bOrderDrink.Name = "bOrderDrink";
            this.bOrderDrink.Size = new System.Drawing.Size(423, 211);
            this.bOrderDrink.TabIndex = 2;
            this.bOrderDrink.Text = "Order Drink";
            this.bOrderDrink.UseVisualStyleBackColor = false;
            this.bOrderDrink.Click += new System.EventHandler(this.bOrderDrink_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 674);
            this.Controls.Add(this.bOrderDrink);
            this.Controls.Add(this.bCustList);
            this.Controls.Add(this.btnManagement);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormMainClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

    }

    #endregion

    private Button btnManagement;
    private Button bCustList;
    public Button bOrderDrink;
}