using System.Data;
using System.Data.SqlClient;

namespace Personal_Expense_Tracker
{
    public static class Db
    {
        private static readonly SqlConnection conn =
            new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ExpenseDB;Integrated Security=True");

        public static DataTable GetTable(string query)
        {
            DataTable dt = new DataTable();

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                dt.Load(cmd.ExecuteReader());
                conn.Close();
            }

            return dt;
        }

        public static void Execute(string query)
        {
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
