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
            this.CreateOrder = new System.Windows.Forms.Button();
            this.CustomerList = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.btncustomerlist = new System.Windows.Forms.Button();
            this.btnAnonOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManagement
            // 
            this.btnManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(95)))), ((int)(((byte)(98)))));
            this.btnManagement.Location = new System.Drawing.Point(437, 361);
            this.btnManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.Size = new System.Drawing.Size(290, 53);
            this.btnManagement.TabIndex = 0;
            this.btnManagement.Text = "Management";
            this.btnManagement.UseVisualStyleBackColor = false;
            this.btnManagement.Click += new System.EventHandler(this.OnClickBtnManagement);
            // 
            // CreateOrder
            // 
            this.CreateOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.CreateOrder.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateOrder.Location = new System.Drawing.Point(388, 98);
            this.CreateOrder.Name = "CreateOrder";
            this.CreateOrder.Size = new System.Drawing.Size(373, 96);
            this.CreateOrder.TabIndex = 1;
            this.CreateOrder.Text = "Create Order";
            this.CreateOrder.UseVisualStyleBackColor = false;
            this.CreateOrder.Click += new System.EventHandler(this.CreateOrder_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-24, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1371, 71);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(528, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Menu";
            // btncustomerlist
            // 
            this.btncustomerlist.Location = new System.Drawing.Point(337, 325);
            this.btncustomerlist.Name = "btncustomerlist";
            this.btncustomerlist.Size = new System.Drawing.Size(674, 150);
            this.btncustomerlist.TabIndex = 1;
            this.btncustomerlist.Text = "Customer List";
            this.btncustomerlist.UseVisualStyleBackColor = true;
            this.btncustomerlist.Click += new System.EventHandler(this.btncustomerlist_Click);
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(151)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(1194, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CustomerList);
            this.Controls.Add(this.CreateOrder);
            this.Controls.Add(this.btnManagement);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Controls.Add(this.btncustomerlist);
            this.Name = "FormMain";
            this.Text = "Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormMainClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private Button btnManagement;
    private Button CreateOrder;
    private Panel panel1;
    private Label label1;
    private Button btncustomerlist;
}