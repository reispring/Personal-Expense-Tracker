using System;
using System.Linq;
using System.Data;
using System.Windows.Forms;

namespace Personal_Expense_Tracker
{
    public partial class Main_Dashboard : Form
    {
        public Main_Dashboard()
        {
            InitializeComponent();

        }
        private void Main_Dashboard_Load(object sender, EventArgs e)
        {
            LoadExpenses();
        }


        private void LoadExpenses()
        {
            var list = Db.GetAll<Expense>()
                         .OrderByDescending(x => x.ExpenseDate)
                         .ToList();

            dgvExpenses.DataSource = list;

            lblTotal.Text = "Total: ₱" + list.Sum(x => x.Amount).ToString("N2");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddExpense f = new AddExpense();
            f.ShowDialog();
            LoadExpenses();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a record.");
                return;
            }

            int id = Convert.ToInt32(dgvExpenses.SelectedRows[0].Cells["ExpenseID"].Value);

            Edit_Expense f = new Edit_Expense(id);
            f.ShowDialog();
            LoadExpenses();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a record to delete.");
                return;
            }

            int id = Convert.ToInt32(dgvExpenses.SelectedRows[0].Cells["ExpenseID"].Value);

            var expense = Db.GetById<Expense>(id);

            if (expense == null) return;

            if (MessageBox.Show("Delete this expense?", "Confirm", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                Db.Delete(expense);
                LoadExpenses();
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadExpenses();
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

        }
    }
}
