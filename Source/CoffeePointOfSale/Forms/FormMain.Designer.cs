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
            this.components = new System.ComponentModel.Container();
            this.btnManagement = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnManagement
            // 
            this.btnManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(105)))), ((int)(((byte)(120)))));
            this.btnManagement.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnManagement.ForeColor = System.Drawing.Color.White;
            this.btnManagement.Location = new System.Drawing.Point(465, 229);
            this.btnManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.Size = new System.Drawing.Size(419, 108);
            this.btnManagement.TabIndex = 0;
            this.btnManagement.Text = "Order Drink";
            this.btnManagement.UseVisualStyleBackColor = false;
            this.btnManagement.Click += new System.EventHandler(this.OnClickBtnManagement);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 80.24999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(380, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(598, 129);
            this.label1.TabIndex = 1;
            this.label1.Text = "Main Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(105)))), ((int)(((byte)(120)))));
            this.button1.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(465, 371);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(419, 108);
            this.button1.TabIndex = 2;
            this.button1.Text = "Customer List";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(105)))), ((int)(((byte)(120)))));
            this.button2.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(465, 509);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(419, 108);
            this.button2.TabIndex = 3;
            this.button2.Text = "Management Tools";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(444, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 464);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(89, 284);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 235);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(1009, 284);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 235);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 682);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnManagement);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormMainClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Button btnManagement;
    private Label label1;
    private Button button1;
    private Button button2;
    private Panel panel1;
    private Panel panel3;
    private ImageList imageList1;
    private Panel panel2;
}