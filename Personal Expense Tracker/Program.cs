using System;
using System.Windows.Forms;

namespace Personal_Expense_Tracker
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
  
            Db.Init();

            ApplicationConfiguration.Initialize();
            Application.Run(new Main_Dashboard());
        }
    }
}