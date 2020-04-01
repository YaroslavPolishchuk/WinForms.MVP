using Category.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Category.DAL
{
    public class CategoryStorage
    {

        public SqlConnection Connection {get;set;}
        public SqlCommand cmd;
        string Ex = null;

        public DataTable GetData()
        {
            string query = "select * from dbo.Category";
            
            DataTable table = new DataTable();
            try
            {
                Connection.Open();
                var dataAdapter = new SqlDataAdapter(query, Connection);
                dataAdapter.Fill(table);
                return table;
            }            
            catch (Exception ex)
            {
                Ex = ex.Message;
            }
            finally
            {
                if (Connection.State == System.Data.ConnectionState.Open)
                    Connection.Close();                
            }
            return null;
        }
        public IEnumerable<_Category> GetCategory()
        {
            List<_Category> Categories = new List<_Category>();
            string query = "select * from dbo.Category";
            cmd = new SqlCommand(query, Connection);
            try
            {
                Connection.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var t = new _Category
                        {
                            CategoryId = reader.GetInt32(0),
                            CategoryName = reader.GetString(1)
                        };
                        Categories.Add(t);
                    }
                }
                return Categories;
            }
            catch (Exception ex)
            {
                Ex = ex.Message;
            }
            finally
            {
                if (Connection.State == System.Data.ConnectionState.Open)
                    Connection.Close();
            }
            return null;
        }
        public _Category Add(_Category c)
        {
            string query = @"insert into dbo.Category(CategoryName) values (@CategoryName)";
            cmd = new SqlCommand(query,Connection);
            SqlTransaction transaction = null;
            try
            {
                Connection.Open();
                transaction = Connection.BeginTransaction();
                cmd.Transaction = transaction;
                cmd.Parameters.AddWithValue("@CategoryName", c.CategoryName);

                cmd.ExecuteNonQuery();
                cmd.CommandText = "select @@identity";
                var id = cmd.ExecuteScalar();
                c.CategoryId = Convert.ToInt32(id);
                transaction.Commit();
                return c;
            }
            catch (Exception exc)
            {
                transaction.Rollback();
                Console.WriteLine(exc.Message);
            }
            finally
            {
                if (Connection.State == System.Data.ConnectionState.Open)
                    Connection.Close();
            }
            return null;


        }
        public void Del(int id)
        {
            cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = @"delete from dbo.Category where CategoryId=@CategoryId";
            SqlTransaction transaction = null;
            try
            {
                Connection.Open();
                transaction = Connection.BeginTransaction();
                cmd.Transaction = transaction;
                cmd.Parameters.AddWithValue("@CategoryId", id);
                cmd.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception exc)
            {
                transaction.Rollback();
                Console.WriteLine(exc.Message);
            }
            finally
            {
                if (Connection.State == System.Data.ConnectionState.Open)
                    Connection.Close();
            }
        }
        public void Update(int id, string s)
        {
            cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = @"update dbo.Category set CategoryName=@CategoryName where CategoryId=@CategoryId";
            SqlTransaction transaction = null;
            try
            {
                Connection.Open();
                transaction = Connection.BeginTransaction();
                cmd.Transaction = transaction;
                cmd.Parameters.AddWithValue("@CategoryId", id);
                cmd.Parameters.AddWithValue("@CategoryName", s);
                cmd.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception exc)
            {
                transaction.Rollback();
                Console.WriteLine(exc.Message);
            }
            finally
            {
                if (Connection.State == System.Data.ConnectionState.Open)
                    Connection.Close();
            }
        }
    }
}
