namespace Personal_Expense_Tracker
{
    partial class Category_Manager
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
            lblCategory = new Label();
            txtCategoryName = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            listCategories = new ListBox();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(59, 45);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(93, 15);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Category Name:";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(180, 40);
            txtCategoryName.Margin = new Padding(3, 2, 3, 2);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(110, 23);
            txtCategoryName.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(59, 87);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 22);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(207, 87);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // listCategories
            // 
            listCategories.FormattingEnabled = true;
            listCategories.ItemHeight = 15;
            listCategories.Location = new Point(59, 136);
            listCategories.Margin = new Padding(3, 2, 3, 2);
            listCategories.Name = "listCategories";
            listCategories.Size = new Size(232, 79);
            listCategories.TabIndex = 4;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(137, 234);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(82, 22);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // Category_Manager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 303);
            Controls.Add(btnClose);
            Controls.Add(listCategories);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtCategoryName);
            Controls.Add(lblCategory);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Category_Manager";
            Text = "Category_Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategory;
        private TextBox txtCategoryName;
        private Button btnAdd;
        private Button btnDelete;
        private ListBox listCategories;
        private Button btnClose;
    }
}