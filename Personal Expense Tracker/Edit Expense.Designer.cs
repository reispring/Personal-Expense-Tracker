namespace Personal_Expense_Tracker
{
    partial class Edit_Expense
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
            lblHeader = new Label();
            btnCancel = new Button();
            btnUpdate = new Button();
            txtDescription = new TextBox();
            lblDescription = new Label();
            dtpDate = new DateTimePicker();
            lblDate = new Label();
            cbCategory = new ComboBox();
            lblCategory = new Label();
            txtAmount = new TextBox();
            lblAmount = new Label();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(259, 21);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(123, 23);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "EDIT EXPENSE";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(359, 328);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(203, 328);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(203, 253);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(250, 34);
            txtDescription.TabIndex = 18;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(104, 260);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(88, 20);
            lblDescription.TabIndex = 17;
            lblDescription.Text = "Description:";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(203, 202);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(250, 27);
            dtpDate.TabIndex = 16;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(104, 209);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(44, 20);
            lblDate.TabIndex = 15;
            lblDate.Text = "Date:";
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(203, 149);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(250, 28);
            cbCategory.TabIndex = 14;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(104, 157);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(72, 20);
            lblCategory.TabIndex = 13;
            lblCategory.Text = "Category:";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(203, 102);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(250, 27);
            txtAmount.TabIndex = 12;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(104, 109);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(65, 20);
            lblAmount.TabIndex = 11;
            lblAmount.Text = "Amount:";
            // 
            // Edit_Expense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 415);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(dtpDate);
            Controls.Add(lblDate);
            Controls.Add(cbCategory);
            Controls.Add(lblCategory);
            Controls.Add(txtAmount);
            Controls.Add(lblAmount);
            Controls.Add(lblHeader);
            Name = "Edit_Expense";
            Text = "Edit_Expense";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Button btnCancel;
        private Button btnUpdate;
        private TextBox txtDescription;
        private Label lblDescription;
        private DateTimePicker dtpDate;
        private Label lblDate;
        private ComboBox cbCategory;
        private Label lblCategory;
        private TextBox txtAmount;
        private Label lblAmount;
    }
}