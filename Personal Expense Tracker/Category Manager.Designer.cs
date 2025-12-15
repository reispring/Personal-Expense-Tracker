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
            lblCategory.Location = new Point(67, 60);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(116, 20);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Category Name:";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(206, 53);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(125, 27);
            txtCategoryName.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(67, 116);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(237, 116);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // listCategories
            // 
            listCategories.FormattingEnabled = true;
            listCategories.Location = new Point(67, 181);
            listCategories.Name = "listCategories";
            listCategories.Size = new Size(265, 104);
            listCategories.TabIndex = 4;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(157, 312);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Category_Manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 404);
            Controls.Add(btnClose);
            Controls.Add(listCategories);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtCategoryName);
            Controls.Add(lblCategory);
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