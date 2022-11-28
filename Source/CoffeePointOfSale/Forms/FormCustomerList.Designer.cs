namespace CoffeePointOfSale.Forms
{
    partial class FormCustomerList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bMM_CustList = new System.Windows.Forms.Button();
            this.addCust = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bMM_CustList
            // 
            this.bMM_CustList.BackColor = System.Drawing.Color.SteelBlue;
            this.bMM_CustList.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bMM_CustList.ForeColor = System.Drawing.Color.Transparent;
            this.bMM_CustList.Location = new System.Drawing.Point(12, 553);
            this.bMM_CustList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bMM_CustList.Name = "bMM_CustList";
            this.bMM_CustList.Size = new System.Drawing.Size(206, 108);
            this.bMM_CustList.TabIndex = 0;
            this.bMM_CustList.Text = "Main Menu";
            this.bMM_CustList.UseVisualStyleBackColor = false;
            this.bMM_CustList.Click += new System.EventHandler(this.bMM_CustList_Click);
            // 
            // addCust
            // 
            this.addCust.BackColor = System.Drawing.Color.SteelBlue;
            this.addCust.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addCust.ForeColor = System.Drawing.Color.Transparent;
            this.addCust.Location = new System.Drawing.Point(1112, 553);
            this.addCust.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addCust.Name = "addCust";
            this.addCust.Size = new System.Drawing.Size(206, 108);
            this.addCust.TabIndex = 1;
            this.addCust.Text = "Add Customer";
            this.addCust.UseVisualStyleBackColor = false;
            this.addCust.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 45;
            this.listBox1.Location = new System.Drawing.Point(118, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(818, 499);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1064, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // FormCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 674);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addCust);
            this.Controls.Add(this.bMM_CustList);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.Name = "FormCustomerList";
            this.Text = "FormCustomerList";
            this.Load += new System.EventHandler(this.FormCustomerList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bMM_CustList;
        private Button addCust;
        private ListBox listBox1;
        private Label label1;
        //private Button button;
    }
}