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

            var categories = Db.GetAll<Category>()
                               .OrderBy(c => c.CategoryName)
                               .ToList();

            foreach (var c in categories)
            {
                listCategories.Items.Add($"{c.CategoryID} - {c.CategoryName}");
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                MessageBox.Show("Please enter a category name.");
                return;
            }

            Category cat = new Category()
            {
                CategoryName = txtCategoryName.Text.Trim()
            };

            Db.Insert(cat);

            MessageBox.Show("Category added!");
            txtCategoryName.Clear();
            LoadCategories();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listCategories.SelectedItem == null)
            {
                MessageBox.Show("Select a category to delete.");
                return;
            }

            string selected = listCategories.SelectedItem.ToString();
            int id = Convert.ToInt32(selected.Split('-')[0].Trim());

            var target = Db.GetById<Category>(id);

            if (target == null)
            {
                MessageBox.Show("Category not found.");
                return;
            }

            if (MessageBox.Show("Delete this category?", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Db.Delete(target);
                LoadCategories();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}