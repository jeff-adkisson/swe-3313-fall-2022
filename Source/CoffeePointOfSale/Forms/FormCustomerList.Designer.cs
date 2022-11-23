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
            this.SuspendLayout();
            // 
            // bMM_CustList
            // 
            this.bMM_CustList.BackColor = System.Drawing.Color.SteelBlue;
            this.bMM_CustList.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bMM_CustList.ForeColor = System.Drawing.Color.Transparent;
            this.bMM_CustList.Location = new System.Drawing.Point(12, 628);
            this.bMM_CustList.Name = "bMM_CustList";
            this.bMM_CustList.Size = new System.Drawing.Size(180, 81);
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
            this.addCust.Location = new System.Drawing.Point(1156, 628);
            this.addCust.Name = "addCust";
            this.addCust.Size = new System.Drawing.Size(180, 81);
            this.addCust.TabIndex = 1;
            this.addCust.Text = "Add Customer";
            this.addCust.UseVisualStyleBackColor = false;
            this.addCust.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.addCust);
            this.Controls.Add(this.bMM_CustList);
            this.Name = "FormCustomerList";
            this.Text = "FormCustomerList";
            this.Load += new System.EventHandler(this.FormCustomerList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button bMM_CustList;
        private Button addCust;
    }
}