using System;
using System.Data;
using System.Windows.Forms;

namespace Personal_Expense_Tracker
{
    public partial class Edit_Expense : Form
    {
        private int currentID;
        private Expense currentExpense;


        public Edit_Expense()
        {
            InitializeComponent();
        }


        public Edit_Expense(int id) : this()
        {
            LoadExpense(id);
        }


        public void LoadExpense(int id)
        {
            currentID = id;
            currentExpense = Db.GetById<Expense>(id);

            if (currentExpense == null)
            {
                MessageBox.Show("Record not found.");
                this.Close();
                return;
            }

            txtAmount.Text = currentExpense.Amount.ToString("0.00");
            cbCategory.Text = currentExpense.Category ?? "";
            dtpDate.Value = currentExpense.ExpenseDate == default ? DateTime.Today : currentExpense.ExpenseDate;
            txtDescription.Text = currentExpense.Description ?? "";
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (!decimal.TryParse(txtAmount.Text.Trim(), out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid positive amount.");
                return;
            }

            if (string.IsNullOrWhiteSpace(cbCategory.Text))
            {
                MessageBox.Show("Please select or enter a category.");
                return;
            }


            if (currentExpense == null)
            {
                currentExpense = Db.GetById<Expense>(currentID);
                if (currentExpense == null)
                {
                    MessageBox.Show("Record not found.");
                    this.Close();
                    return;
                }
            }

            currentExpense.Amount = amount;
            currentExpense.Category = cbCategory.Text.Trim();
            currentExpense.ExpenseDate = dtpDate.Value.Date;
            currentExpense.Description = txtDescription.Text.Trim();


            Db.Update(currentExpense);

            MessageBox.Show("Expense updated successfully.");
            this.Close();
        }

        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}