using SQLite;
using System;
using System.IO;
using System.Collections.Generic;
using System.Data;

namespace Personal_Expense_Tracker
{
    public static class Db
    {
        private static SQLiteConnection conn;


        public static void Init()
        {
            string dbPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "expenses.db"
            );

            conn = new SQLiteConnection(dbPath);

            conn.CreateTable<Expense>();
            conn.CreateTable<Category>();
        }

        public static int Insert(object item)
        {
            return conn.Insert(item);
        }

        public static int Update(object item)
        {
            return conn.Update(item);
        }

        public static int Delete(object item)
        {
            return conn.Delete(item);
        }


        public static List<T> GetAll<T>() where T : new()
        {
            return conn.Table<T>().ToList();
        }

        public static T GetById<T>(int id) where T : new()
        {
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