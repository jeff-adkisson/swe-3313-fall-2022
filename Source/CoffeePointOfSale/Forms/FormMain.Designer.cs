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
            this.btncustomerlist = new System.Windows.Forms.Button();
            this.btnAnonOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManagement
            // 
            this.btnManagement.Location = new System.Drawing.Point(574, 550);
            this.btnManagement.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.Size = new System.Drawing.Size(200, 37);
            this.btnManagement.TabIndex = 0;
            this.btnManagement.Text = "Management";
            this.btnManagement.UseVisualStyleBackColor = true;
            this.btnManagement.Click += new System.EventHandler(this.OnClickBtnManagement);
            // 
            // btncustomerlist
            // 
            this.btncustomerlist.Location = new System.Drawing.Point(337, 325);
            this.btncustomerlist.Name = "btncustomerlist";
            this.btncustomerlist.Size = new System.Drawing.Size(674, 150);
            this.btncustomerlist.TabIndex = 1;
            this.btncustomerlist.Text = "Customer List";
            this.btncustomerlist.UseVisualStyleBackColor = true;
            // 
            // btnAnonOrder
            // 
            this.btnAnonOrder.Location = new System.Drawing.Point(337, 125);
            this.btnAnonOrder.Name = "btnAnonOrder";
            this.btnAnonOrder.Size = new System.Drawing.Size(674, 150);
            this.btnAnonOrder.TabIndex = 2;
            this.btnAnonOrder.Text = "Create Order";
            this.btnAnonOrder.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 665);
            this.Controls.Add(this.btnAnonOrder);
            this.Controls.Add(this.btncustomerlist);
            this.Controls.Add(this.btnManagement);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormMainClosed);
            this.ResumeLayout(false);

    }

    #endregion

    private Button btnManagement;
    private Button btncustomerlist;
    private Button btnAnonOrder;
}