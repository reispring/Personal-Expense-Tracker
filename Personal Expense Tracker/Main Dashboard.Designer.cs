namespace Personal_Expense_Tracker
{
    partial class Main_Dashboard
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
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            dgvExpenses = new DataGridView();
            lblTitle = new Label();
            btnPrintReport = new Button();
            btnAbout = new Button();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(59, 56);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(66, 22);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(130, 56);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(66, 22);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(200, 56);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(66, 22);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(271, 56);
            btnRefresh.Margin = new Padding(3, 2, 3, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(66, 22);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // dgvExpenses
            // 
            dgvExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpenses.Location = new Point(46, 94);
            dgvExpenses.Margin = new Padding(3, 2, 3, 2);
            dgvExpenses.Name = "dgvExpenses";
            dgvExpenses.RowHeadersWidth = 51;
            dgvExpenses.Size = new Size(484, 141);
            dgvExpenses.TabIndex = 6;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(189, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(208, 19);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "PERSONAL EXPENSE TRACKER";
            // 
            // btnPrintReport
            // 
            btnPrintReport.Location = new Point(342, 56);
            btnPrintReport.Margin = new Padding(3, 2, 3, 2);
            btnPrintReport.Name = "btnPrintReport";
            btnPrintReport.Size = new Size(98, 22);
            btnPrintReport.TabIndex = 8;
            btnPrintReport.Text = "Print Report";
            btnPrintReport.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            btnAbout.Location = new Point(445, 56);
            btnAbout.Margin = new Padding(3, 2, 3, 2);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(72, 22);
            btnAbout.TabIndex = 9;
            btnAbout.Text = "About";
            btnAbout.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(18, 296);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(66, 15);
            lblTotal.TabIndex = 10;
            lblTotal.Text = "Total: ₱0.00";
            // 
            // Main_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 338);
            Controls.Add(lblTotal);
            Controls.Add(btnAbout);
            Controls.Add(btnPrintReport);
            Controls.Add(lblTitle);
            Controls.Add(dgvExpenses);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Main_Dashboard";
            Text = "Main Dashboard";
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button button2;
        private Button btnRefresh;
        private DataGridView dgvExpenses;
        private Label lblTitle;
        private Button btnPrintReport;
        private Button btnAbout;
        private Label lblTotal;
    }
}
