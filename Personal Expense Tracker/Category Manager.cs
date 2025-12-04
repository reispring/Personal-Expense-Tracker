using System;
using System.Data;
using System.Windows.Forms;

namespace Personal_Expense_Tracker
{
    public partial class Category_Manager : Form
    {
        public Category_Manager()
        {
            InitializeComponent();
        }
        private void Category_Manager_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            listCategories.Items.Clear();

            DataTable dt = Db.GetTable("SELECT * FROM Categories ORDER BY CategoryName ASC");

            foreach (DataRow row in dt.Rows)
            {
                // Example: "3 - Groceries"
                listCategories.Items.Add(row["CategoryID"] + " - " + row["CategoryName"]);
            }
        }

        // ------------------------------------------------------------
        // ADD CATEGORY
        // ------------------------------------------------------------
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text == "")
            {
                MessageBox.Show("Please enter a category name.");
                return;
            }

            string name = txtCategoryName.Text;

            Db.Execute($"INSERT INTO Categories (CategoryName) VALUES ('{name}')");

            MessageBox.Show("Category added!");
            txtCategoryName.Clear();
            LoadCategories();
        }

        // ------------------------------------------------------------
        // DELETE CATEGORY
        // ------------------------------------------------------------
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listCategories.SelectedItem == null)
            {
                MessageBox.Show("Select a category to delete.");
                return;
            }

            // Selected item sample: "3 - Groceries"
            string selected = listCategories.SelectedItem.ToString();
            int id = Convert.ToInt32(selected.Split('-')[0].Trim());

            if (MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                Db.Execute($"DELETE FROM Categories WHERE CategoryID={id}");

                MessageBox.Show("Category deleted!");
                LoadCategories();
            }
        }

        // ------------------------------------------------------------
        // CLOSE
        // ------------------------------------------------------------
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}