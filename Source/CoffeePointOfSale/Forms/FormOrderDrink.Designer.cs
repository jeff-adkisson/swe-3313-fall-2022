namespace CoffeePointOfSale.Forms
{
    partial class FormOrderDrink
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
            this.orderDrink_Close = new System.Windows.Forms.Button();
            this.addDrink = new System.Windows.Forms.Button();
            this.callPayment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orderDrink_Close
            // 
            this.orderDrink_Close.BackColor = System.Drawing.Color.Firebrick;
            this.orderDrink_Close.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderDrink_Close.ForeColor = System.Drawing.Color.Transparent;
            this.orderDrink_Close.Location = new System.Drawing.Point(769, 12);
            this.orderDrink_Close.Name = "orderDrink_Close";
            this.orderDrink_Close.Size = new System.Drawing.Size(135, 58);
            this.orderDrink_Close.TabIndex = 0;
            this.orderDrink_Close.Text = "Close";
            this.orderDrink_Close.UseVisualStyleBackColor = false;
            this.orderDrink_Close.Click += new System.EventHandler(this.orderDrink_Close_Click);
            // 
            // addDrink
            // 
            this.addDrink.BackColor = System.Drawing.Color.SteelBlue;
            this.addDrink.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addDrink.ForeColor = System.Drawing.Color.Transparent;
            this.addDrink.Location = new System.Drawing.Point(790, 631);
            this.addDrink.Name = "addDrink";
            this.addDrink.Size = new System.Drawing.Size(180, 81);
            this.addDrink.TabIndex = 1;
            this.addDrink.Text = "Add Drink";
            this.addDrink.UseVisualStyleBackColor = false;
            // 
            // callPayment
            // 
            this.callPayment.BackColor = System.Drawing.Color.SteelBlue;
            this.callPayment.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.callPayment.ForeColor = System.Drawing.Color.Transparent;
            this.callPayment.Location = new System.Drawing.Point(1127, 631);
            this.callPayment.Name = "callPayment";
            this.callPayment.Size = new System.Drawing.Size(180, 81);
            this.callPayment.TabIndex = 2;
            this.callPayment.Text = "Payment";
            this.callPayment.UseVisualStyleBackColor = false;
            this.callPayment.Click += new System.EventHandler(this.callPayment_Click);
            // 
            // FormOrderDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.callPayment);
            this.Controls.Add(this.addDrink);
            this.Controls.Add(this.orderDrink_Close);
            this.Name = "FormOrderDrink";
            this.Text = "FormOrderDrink";
            this.Load += new System.EventHandler(this.FormOrderDrink_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button orderDrink_Close;
        private Button addDrink;
        private Button callPayment;
    }
}