namespace Personal_Expense_Tracker
{
    partial class View_Report
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
            lblFrom = new Label();
            dtpFrom = new DateTimePicker();
            lblTo = new Label();
            dtpTo = new DateTimePicker();
            btnFilter = new Button();
            btnPrint = new Button();
            dgvReport = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(316, 18);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(150, 23);
            lblHeader.TabIndex = 1;
            lblHeader.Text = "EXPENSE REPORT";
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(23, 78);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(46, 20);
            lblFrom.TabIndex = 2;
            lblFrom.Text = "From:";
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(75, 71);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(242, 27);
            dtpFrom.TabIndex = 3;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(334, 78);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(28, 20);
            lblTo.TabIndex = 4;
            lblTo.Text = "To:";
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(368, 73);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(242, 27);
            dtpTo.TabIndex = 5;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(629, 71);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(94, 29);
            btnFilter.TabIndex = 6;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(334, 343);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(94, 29);
            btnPrint.TabIndex = 7;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // dgvReport
            // 
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(23, 128);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 51;
            dgvReport.Size = new Size(700, 188);
            dgvReport.TabIndex = 8;
            // 
            // View_Report
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 450);
            Controls.Add(dgvReport);
            Controls.Add(btnPrint);
            Controls.Add(btnFilter);
            Controls.Add(dtpTo);
            Controls.Add(lblTo);
            Controls.Add(dtpFrom);
            Controls.Add(lblFrom);
            Controls.Add(lblHeader);
            Name = "View_Report";
            Text = "View_Report";
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Label lblFrom;
        private DateTimePicker dtpFrom;
        private Label lblTo;
        private DateTimePicker dtpTo;
        private Button btnFilter;
        private Button btnPrint;
        private DataGridView dgvReport;
    }
}