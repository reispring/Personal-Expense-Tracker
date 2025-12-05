using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Expense_Tracker
{
    public partial class AddExpense : Form
    {
        public AddExpense()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Please enter amount.");
                return;
            }
            if (!decimal.TryParse(txtAmount.Text.Trim(), out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Amount must be a positive number.");
                return;
            }
            if (string.IsNullOrWhiteSpace(cbCategory.Text))
            {
                MessageBox.Show("Please select or enter a category.");
                return;
            }


            Expense exp = new Expense()
            {
                ExpenseDate = dtpDate.Value.Date,
                Category = cbCategory.Text.Trim(),
                Amount = amount,
                Description = txtDescription.Text.Trim()
            };


            Db.Insert(exp);

            MessageBox.Show("Expense added successfully!");


            this.Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}