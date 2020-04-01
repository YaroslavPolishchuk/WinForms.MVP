using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using Category.DAL;
using Category.DAL.Models;

namespace TestCategoryDAL
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Shop"].ConnectionString;
            CategoryStorage cs = new CategoryStorage();
            cs.Connection = new System.Data.SqlClient.SqlConnection(connectionString);
            //var collection = cs.GetCategory();
            //var colllection_ = collection;

            //foreach (var item in collection)
            //{
            //    Console.WriteLine(item.CategoryName);
            //}
            cs.Add(new _Category { CategoryName = "Test1" });
            cs.Add(new _Category { CategoryName = "Test2" });
            cs.Add(new _Category { CategoryName = "Test3" });
            cs.Add(new _Category { CategoryName = "Test4" });
            //cs.Del(5);
            //cs.Del(8);

        }
    }
}
