using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Personal_Expense_Tracker
{
    public partial class Main_Dashboard : Form
    {
        public Main_Dashboard()
        {
            InitializeComponent();

        }
        
        private void MainDashboard_Load(object sender, EventArgs e)
        {
            LoadExpenses();
        }

        private void LoadExpenses()
        {
            DataTable dt = Db.GetTable("SELECT * FROM Expenses ORDER BY ExpenseDate DESC");
            dgvExpenses.AutoGenerateColumns = true;
            dgvExpenses.DataSource = dt;


            if (dgvExpenses.Columns.Contains("ExpenseID"))
                dgvExpenses.Columns["ExpenseID"].Visible = false;

            dgvExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            AddExpense f = new AddExpense();
            f.ShowDialog();
            LoadExpenses(); // refresh
        }


        private void btnEditExpense_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an expense to edit.");
                return;
            }

            int id = Convert.ToInt32(dgvExpenses.SelectedRows[0].Cells["ExpenseID"].Value);

            Edit_Expense f = new Edit_Expense();
            f.LoadExpense(id);
            f.ShowDialog();

            LoadExpenses(); 
        }


        private void btnDeleteExpense_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an expense to delete.");
                return;
            }

            int id = Convert.ToInt32(dgvExpenses.SelectedRows[0].Cells["ExpenseID"].Value);

            DialogResult dr = MessageBox.Show("Delete this expense?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                Db.Execute("DELETE FROM Expenses WHERE ExpenseID=" + id);
                LoadExpenses();
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadExpenses();
        }
    }
}
