namespace CoffeePointOfSale.Forms
{
    partial class FormPayment
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
            this.payCard = new System.Windows.Forms.Button();
            this.payPoints = new System.Windows.Forms.Button();
            this.Cancel_Payment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // payCard
            // 
            this.payCard.BackColor = System.Drawing.Color.SteelBlue;
            this.payCard.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.payCard.ForeColor = System.Drawing.Color.Transparent;
            this.payCard.Location = new System.Drawing.Point(142, 292);
            this.payCard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.payCard.Name = "payCard";
            this.payCard.Size = new System.Drawing.Size(239, 120);
            this.payCard.TabIndex = 0;
            this.payCard.Text = "Pay With Card";
            this.payCard.UseVisualStyleBackColor = false;
            // 
            // payPoints
            // 
            this.payPoints.BackColor = System.Drawing.Color.SteelBlue;
            this.payPoints.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.payPoints.ForeColor = System.Drawing.Color.Transparent;
            this.payPoints.Location = new System.Drawing.Point(950, 292);
            this.payPoints.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.payPoints.Name = "payPoints";
            this.payPoints.Size = new System.Drawing.Size(239, 120);
            this.payPoints.TabIndex = 1;
            this.payPoints.Text = "Pay With Points";
            this.payPoints.UseVisualStyleBackColor = false;
            // 
            // Cancel_Payment
            // 
            this.Cancel_Payment.BackColor = System.Drawing.Color.Brown;
            this.Cancel_Payment.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cancel_Payment.ForeColor = System.Drawing.Color.Transparent;
            this.Cancel_Payment.Location = new System.Drawing.Point(55, 576);
            this.Cancel_Payment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel_Payment.Name = "Cancel_Payment";
            this.Cancel_Payment.Size = new System.Drawing.Size(187, 85);
            this.Cancel_Payment.TabIndex = 2;
            this.Cancel_Payment.Text = "Cancel";
            this.Cancel_Payment.UseVisualStyleBackColor = false;
            this.Cancel_Payment.Click += new System.EventHandler(this.Cancel_Payment_Click);
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 674);
            this.Controls.Add(this.Cancel_Payment);
            this.Controls.Add(this.payPoints);
            this.Controls.Add(this.payCard);
            this.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.Name = "FormPayment";
            this.Text = "FormPayment";
            this.Load += new System.EventHandler(this.FormPayment_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button payCard;
        private Button payPoints;
        private Button Cancel_Payment;
    }
}