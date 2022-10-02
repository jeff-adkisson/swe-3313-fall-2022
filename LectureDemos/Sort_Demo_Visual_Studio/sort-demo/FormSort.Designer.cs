namespace WinFormsApp1
{
    partial class SortForm
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
            this.btnPickFile = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.txtUnsorted = new System.Windows.Forms.TextBox();
            this.txtSorted = new System.Windows.Forms.TextBox();
            this.btnSortAsc = new System.Windows.Forms.Button();
            this.lUnsorted = new System.Windows.Forms.Label();
            this.lSorted = new System.Windows.Forms.Label();
            this.btnSortDesc = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtWriteFilePath = new System.Windows.Forms.TextBox();
            this.btnWriteFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPickFile
            // 
            this.btnPickFile.Location = new System.Drawing.Point(498, 28);
            this.btnPickFile.Name = "btnPickFile";
            this.btnPickFile.Size = new System.Drawing.Size(94, 29);
            this.btnPickFile.TabIndex = 0;
            this.btnPickFile.Text = "Pick FIle";
            this.btnPickFile.UseVisualStyleBackColor = true;
            this.btnPickFile.Click += new System.EventHandler(this.btnPickFile_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(25, 28);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(460, 27);
            this.txtFilePath.TabIndex = 1;
            // 
            // txtUnsorted
            // 
            this.txtUnsorted.Location = new System.Drawing.Point(25, 95);
            this.txtUnsorted.Multiline = true;
            this.txtUnsorted.Name = "txtUnsorted";
            this.txtUnsorted.ReadOnly = true;
            this.txtUnsorted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUnsorted.Size = new System.Drawing.Size(270, 323);
            this.txtUnsorted.TabIndex = 2;
            // 
            // txtSorted
            // 
            this.txtSorted.Location = new System.Drawing.Point(322, 95);
            this.txtSorted.Multiline = true;
            this.txtSorted.Name = "txtSorted";
            this.txtSorted.ReadOnly = true;
            this.txtSorted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSorted.Size = new System.Drawing.Size(270, 323);
            this.txtSorted.TabIndex = 3;
            // 
            // btnSortAsc
            // 
            this.btnSortAsc.Enabled = false;
            this.btnSortAsc.Location = new System.Drawing.Point(25, 439);
            this.btnSortAsc.Name = "btnSortAsc";
            this.btnSortAsc.Size = new System.Drawing.Size(151, 29);
            this.btnSortAsc.TabIndex = 4;
            this.btnSortAsc.Text = "Sort Ascending";
            this.btnSortAsc.UseVisualStyleBackColor = true;
            this.btnSortAsc.Click += new System.EventHandler(this.btnSortAsc_Click);
            // 
            // lUnsorted
            // 
            this.lUnsorted.AutoSize = true;
            this.lUnsorted.Location = new System.Drawing.Point(25, 71);
            this.lUnsorted.Name = "lUnsorted";
            this.lUnsorted.Size = new System.Drawing.Size(82, 20);
            this.lUnsorted.TabIndex = 5;
            this.lUnsorted.Text = "Not Sorted";
            // 
            // lSorted
            // 
            this.lSorted.AutoSize = true;
            this.lSorted.Location = new System.Drawing.Point(322, 71);
            this.lSorted.Name = "lSorted";
            this.lSorted.Size = new System.Drawing.Size(53, 20);
            this.lSorted.TabIndex = 6;
            this.lSorted.Text = "Sorted";
            // 
            // btnSortDesc
            // 
            this.btnSortDesc.Enabled = false;
            this.btnSortDesc.Location = new System.Drawing.Point(182, 439);
            this.btnSortDesc.Name = "btnSortDesc";
            this.btnSortDesc.Size = new System.Drawing.Size(151, 29);
            this.btnSortDesc.TabIndex = 7;
            this.btnSortDesc.Text = "Sort Descending";
            this.btnSortDesc.UseVisualStyleBackColor = true;
            this.btnSortDesc.Click += new System.EventHandler(this.btnSortDesc_Click);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(441, 439);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(151, 29);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtWriteFilePath
            // 
            this.txtWriteFilePath.Location = new System.Drawing.Point(25, 499);
            this.txtWriteFilePath.Name = "txtWriteFilePath";
            this.txtWriteFilePath.ReadOnly = true;
            this.txtWriteFilePath.Size = new System.Drawing.Size(460, 27);
            this.txtWriteFilePath.TabIndex = 9;
            // 
            // btnWriteFile
            // 
            this.btnWriteFile.Enabled = false;
            this.btnWriteFile.Location = new System.Drawing.Point(498, 499);
            this.btnWriteFile.Name = "btnWriteFile";
            this.btnWriteFile.Size = new System.Drawing.Size(94, 29);
            this.btnWriteFile.TabIndex = 10;
            this.btnWriteFile.Text = "Write File";
            this.btnWriteFile.UseVisualStyleBackColor = true;
            this.btnWriteFile.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // SortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 553);
            this.Controls.Add(this.btnWriteFile);
            this.Controls.Add(this.txtWriteFilePath);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSortDesc);
            this.Controls.Add(this.lSorted);
            this.Controls.Add(this.lUnsorted);
            this.Controls.Add(this.btnSortAsc);
            this.Controls.Add(this.txtSorted);
            this.Controls.Add(this.txtUnsorted);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnPickFile);
            this.Name = "SortForm";
            this.Text = "Sort Number List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPickFile;
        private TextBox txtFilePath;
        private TextBox txtUnsorted;
        private TextBox txtSorted;
        private Button btnSortAsc;
        private Label lUnsorted;
        private Label lSorted;
        private Button btnSortDesc;
        private Button btnReset;
        private TextBox txtWriteFilePath;
        private Button btnWriteFile;
    }
}