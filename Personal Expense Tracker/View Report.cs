using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Expense_Tracker
{
    public partial class View_Report : Form
    {
        public View_Report()
        {
            InitializeComponent();
        }

        private void View_Report_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            var data = Db.GetAll<Expense>()
                         .OrderByDescending(x => x.ExpenseDate)
                         .ToList();

            dgvReport.DataSource = data;
        }


        private void btnGenerate_Click(object sender, EventArgs e)
        {
            DateTime from = dtpFrom.Value.Date;
            DateTime to = dtpTo.Value.Date;

            var data = Db.GetAll<Expense>()
                         .Where(x => x.ExpenseDate >= from && x.ExpenseDate <= to)
                         .OrderBy(x => x.ExpenseDate)
                         .ToList();

            dgvReport.DataSource = data;
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument p = new PrintDocument();
            p.PrintPage += PrintPage;
            PrintPreviewDialog pp = new PrintPreviewDialog();
            pp.Document = p;
            pp.ShowDialog();
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            int y = 50;
            int left = 50;

            Font headerFont = new Font("Arial", 16, FontStyle.Bold);
            Font rowFont = new Font("Arial", 10);

            
            e.Graphics.DrawString("Expense Report", headerFont, Brushes.Black, left, y);
            y += 40;

           
            e.Graphics.DrawString("Date", rowFont, Brushes.Black, left, y);
            e.Graphics.DrawString("Category", rowFont, Brushes.Black, left + 120, y);
            e.Graphics.DrawString("Amount", rowFont, Brushes.Black, left + 300, y);
            y += 25;

            e.Graphics.DrawLine(Pens.Black, left, y, left + 400, y);
            y += 10;

            
            foreach (DataGridViewRow row in dgvReport.Rows)
            {
                
                if (row.IsNewRow) continue;

                string date = row.Cells["ExpenseDate"].Value?.ToString() ?? "";
                string category = row.Cells["Category"].Value?.ToString() ?? "";
                string amount = row.Cells["Amount"].Value?.ToString() ?? "";

                e.Graphics.DrawString(date, rowFont, Brushes.Black, left, y);
                e.Graphics.DrawString(category, rowFont, Brushes.Black, left + 120, y);
                e.Graphics.DrawString(amount, rowFont, Brushes.Black, left + 300, y);

                y += 20;

                
                if (y > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            e.HasMorePages = false;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime from = dtpFrom.Value.Date;
            DateTime to = dtpTo.Value.Date;

            var data = Db.GetAll<Expense>()
                         .Where(x => x.ExpenseDate >= from && x.ExpenseDate <= to)
                         .OrderBy(x => x.ExpenseDate)
                         .ToList();

            dgvReport.DataSource = data;
        }

    }
}
