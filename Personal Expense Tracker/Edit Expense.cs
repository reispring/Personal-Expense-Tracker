using System;
using System.Data;
using System.Windows.Forms;

namespace Personal_Expense_Tracker
{
    public partial class Edit_Expense : Form
    {
        public Edit_Expense()
        {
            InitializeComponent();
        }

        private int currentID = 0;

        public void LoadExpense(int id)
        {
            currentID = id;

            DataTable dt = Db.GetTable("SELECT * FROM Expenses WHERE ExpenseID = " + id);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Record not found.");
                this.Close();
                return;
            }

            DataRow row = dt.Rows[0];

            txtAmount.Text = row["Amount"].ToString();
            cbCategory.Text = row["Category"].ToString();
            dtpDate.Value = Convert.ToDateTime(row["ExpenseDate"]);
            txtDescription.Text = row["Description"].ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid positive amount.");
                return;
            }

            if (string.IsNullOrWhiteSpace(cbCategory.Text))
            {
                MessageBox.Show("Please select a category.");
                return;
            }

            string desc = txtDescription.Text.Replace("'", "''");

            string query =
                "UPDATE Expenses SET " +
                "Amount = " + amount + ", " +
                "Category = '" + cbCategory.Text + "', " +
                "ExpenseDate = '" + dtpDate.Value.ToString("yyyy-MM-dd") + "', " +
                "Description = '" + desc + "' " +
                "WHERE ExpenseID = " + currentID;

            Db.Execute(query);

            MessageBox.Show("Expense updated successfully!");
            this.Close(); 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}