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
            btnAdd.Location = new Point(67, 74);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(148, 74);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 29);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(229, 74);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(310, 74);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 29);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // dgvExpenses
            // 
            dgvExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpenses.Location = new Point(52, 126);
            dgvExpenses.Name = "dgvExpenses";
            dgvExpenses.RowHeadersWidth = 51;
            dgvExpenses.Size = new Size(553, 188);
            dgvExpenses.TabIndex = 6;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(216, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(253, 23);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "PERSONAL EXPENSE TRACKER";
            // 
            // btnPrintReport
            // 
            btnPrintReport.Location = new Point(391, 74);
            btnPrintReport.Name = "btnPrintReport";
            btnPrintReport.Size = new Size(112, 29);
            btnPrintReport.TabIndex = 8;
            btnPrintReport.Text = "Print Report";
            btnPrintReport.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            btnAbout.Location = new Point(509, 74);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(82, 29);
            btnAbout.TabIndex = 9;
            btnAbout.Text = "About";
            btnAbout.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(21, 394);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(85, 20);
            lblTotal.TabIndex = 10;
            lblTotal.Text = "Total: ₱0.00";
            // 
            // Main_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 450);
            Controls.Add(lblTotal);
            Controls.Add(btnAbout);
            Controls.Add(btnPrintReport);
            Controls.Add(lblTitle);
            Controls.Add(dgvExpenses);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Name = "Main_Dashboard";
            Text = "Form1";
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
