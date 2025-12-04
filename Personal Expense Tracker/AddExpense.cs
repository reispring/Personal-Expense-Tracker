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
            if (txtAmount.Text == "" || cbCategory.Text == "")
            {
                MessageBox.Show("Amount and Category are required.");
                return;
            }

            string q = $@"
                INSERT INTO Expenses (Amount, Category, ExpenseDate, Description)
                VALUES ({txtAmount.Text}, '{cbCategory.Text}', 
                '{dtpDate.Value:yyyy-MM-dd}', '{txtDescription.Text}')
            ";

            Db.Execute(q);

            MessageBox.Show("Expense Saved.");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}