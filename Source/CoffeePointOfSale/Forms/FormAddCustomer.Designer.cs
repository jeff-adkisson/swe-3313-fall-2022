namespace CoffeePointOfSale.Forms
{
    partial class FormAddCustomer
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
            this.firstLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addNew = new System.Windows.Forms.Button();
            this.addCust_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstLabel
            // 
            this.firstLabel.AutoSize = true;
            this.firstLabel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstLabel.Location = new System.Drawing.Point(274, 109);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(234, 54);
            this.firstLabel.TabIndex = 1;
            this.firstLabel.Text = "First Name: ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(641, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(408, 43);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "\r\n\r\n";
            this.textBox1.TextChanged += new System.EventHandler(this.FirstName);
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastName.Location = new System.Drawing.Point(641, 248);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(408, 43);
            this.lastName.TabIndex = 3;
            this.lastName.TextChanged += new System.EventHandler(this.lastName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(274, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 54);
            this.label1.TabIndex = 4;
            this.label1.Text = "Last Name:";
            // 
            // phoneNumber
            // 
            this.phoneNumber.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneNumber.Location = new System.Drawing.Point(641, 414);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(408, 43);
            this.phoneNumber.TabIndex = 5;
            this.phoneNumber.TextChanged += new System.EventHandler(this.phoneNumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(207, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 54);
            this.label2.TabIndex = 6;
            this.label2.Text = "Phone Number:";
            // 
            // addNew
            // 
            this.addNew.BackColor = System.Drawing.Color.SteelBlue;
            this.addNew.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addNew.ForeColor = System.Drawing.Color.Transparent;
            this.addNew.Location = new System.Drawing.Point(573, 540);
            this.addNew.Name = "addNew";
            this.addNew.Size = new System.Drawing.Size(173, 78);
            this.addNew.TabIndex = 7;
            this.addNew.Text = "Add New";
            this.addNew.UseVisualStyleBackColor = false;
            this.addNew.Click += new System.EventHandler(this.addNew_Click);
            // 
            // addCust_Cancel
            // 
            this.addCust_Cancel.BackColor = System.Drawing.Color.Brown;
            this.addCust_Cancel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addCust_Cancel.ForeColor = System.Drawing.Color.Transparent;
            this.addCust_Cancel.Location = new System.Drawing.Point(1136, 649);
            this.addCust_Cancel.Name = "addCust_Cancel";
            this.addCust_Cancel.Size = new System.Drawing.Size(125, 60);
            this.addCust_Cancel.TabIndex = 8;
            this.addCust_Cancel.Text = "Cancel";
            this.addCust_Cancel.UseVisualStyleBackColor = false;
            this.addCust_Cancel.Click += new System.EventHandler(this.addCust_Cancel_Click);
            // 
            // FormAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.addCust_Cancel);
            this.Controls.Add(this.addNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.firstLabel);
            this.Name = "FormAddCustomer";
            this.Text = "FormAddCustomer";
            this.Load += new System.EventHandler(this.FormAddCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label firstLabel;
        private TextBox textBox1;
        private TextBox lastName;
        private Label label1;
        private TextBox phoneNumber;
        private Label label2;
        private Button addNew;
        private Button addCust_Cancel;
    }
}