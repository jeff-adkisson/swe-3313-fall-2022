namespace CoffeePointOfSale.Forms
{
    partial class FormManagement
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
            this.btnClose = new System.Windows.Forms.Button();
            this.txtDeleteThis = new System.Windows.Forms.TextBox();
            this.lblRemoveThis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(234, 43);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 37);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.OnClickBtnClose);
            // 
            // txtDeleteThis
            // 
            this.txtDeleteThis.AcceptsReturn = true;
            this.txtDeleteThis.Location = new System.Drawing.Point(234, 137);
            this.txtDeleteThis.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDeleteThis.Multiline = true;
            this.txtDeleteThis.Name = "txtDeleteThis";
            this.txtDeleteThis.Size = new System.Drawing.Size(687, 124);
            this.txtDeleteThis.TabIndex = 1;
            // 
            // lblRemoveThis
            // 
            this.lblRemoveThis.AutoSize = true;
            this.lblRemoveThis.Location = new System.Drawing.Point(234, 108);
            this.lblRemoveThis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemoveThis.Name = "lblRemoveThis";
            this.lblRemoveThis.Size = new System.Drawing.Size(212, 25);
            this.lblRemoveThis.TabIndex = 2;
            this.lblRemoveThis.Text = "Demo - Remove This Box";
            // 
            // FormManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 665);
            this.Controls.Add(this.lblRemoveThis);
            this.Controls.Add(this.txtDeleteThis);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormManagement";
            this.Text = "FormManagement";
            this.Load += new System.EventHandler(this.OnLoadFormManagement);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnClose;
        private TextBox txtDeleteThis;
        private Label lblRemoveThis;
    }
}