using SQLite;
using System;
using System.Collections.Generic;
using System.IO;

namespace Personal_Expense_Tracker
{
    public static class Db
    {
        private static SQLiteConnection conn;


        public static void Init()
        {
            if (conn != null) return;   

            string dbPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "PersonalExpenseTracker.db"
            );

            conn = new SQLiteConnection(dbPath);

            // Create tables if they don't exist
            conn.CreateTable<Expense>();
            conn.CreateTable<Category>();
        }


        private static void EnsureInit()
        {
            if (conn == null)
                throw new Exception("Database not initialized. Call Db.Init() in Program.cs.");
        }


        public static int Insert(object item)
        {
            EnsureInit();
            return conn.Insert(item);
        }


        public static int Update(object item)
        {
            EnsureInit();
            return conn.Update(item);
        }


        public static int Delete(object item)
        {
            EnsureInit();
            return conn.Delete(item);
        }


        public static List<T> GetAll<T>() where T : new()
        {
            EnsureInit();
            return conn.Table<T>().ToList();
        }


        public static T GetById<T>(int id) where T : new()
        {
            EnsureInit();
            return conn.Find<T>(id);
        }
    }

 
    public class Expense
    {
        [PrimaryKey, AutoIncrement]
        public int ExpenseID { get; set; }

        public DateTime ExpenseDate { get; set; }
        public string Category { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
    }

    public class Category
    {
        [PrimaryKey, AutoIncrement]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}