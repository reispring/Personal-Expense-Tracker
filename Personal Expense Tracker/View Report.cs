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

            e.Graphics.DrawString("Expense Report", new Font("Arial", 18, FontStyle.Bold),
                Brushes.Black, new PointF(50, y));

            y += 40;

            foreach (DataGridViewRow row in dgvReport.Rows)
            {
                string line =
                    $"{row.Cells["ExpenseDate"].Value} | " +
                    $"{row.Cells["Category"].Value} | " +
                    $"{row.Cells["Amount"].Value}";

                e.Graphics.DrawString(line, new Font("Arial", 10),
                    Brushes.Black, new PointF(50, y));

                y += 20;
            }
        }
    }
}
