using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Latihan1_DL
{
    public class DBHelper
    {
        private const string connectionString = "server=localhost;port=3307;database=mandhegparkingsystem;uid=root;password=;";

        // Function Insert
        public static int Insert(string tableName, Dictionary<string, object> data)
        {
            int rowAffected = 0;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    StringBuilder sbColumn = new StringBuilder();
                    StringBuilder sbValues = new StringBuilder();

                    foreach (KeyValuePair<string, object> pair in data)
                    {
                        sbColumn.AppendFormat("{0}, ", pair.Key);
                        sbValues.AppendFormat("@{0}, ", pair.Key);
                    }

                    sbColumn.Remove(sbColumn.Length - 2, 2);
                    sbValues.Remove(sbValues.Length - 2, 2);

                    string query = string.Format("INSERT INTO {0} ({1}) VALUES ({2})", tableName, sbColumn, sbValues);

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        foreach (KeyValuePair<string, object> pair in data)
                        {
                            cmd.Parameters.AddWithValue("@" + pair.Key, pair.Value);
                        }
                        rowAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Pesan Error : \n" + ex.Message);
            }
            return rowAffected;
        }
        // Function Update
        public static int Update(string tableName, Dictionary<string, object> data, string condition)
        {
            int rowAffected = 0;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    StringBuilder sbValues = new StringBuilder();

                    foreach (KeyValuePair<string, object> pair in data)
                    {
                        sbValues.AppendFormat("{0}=@{0}, ", pair.Key);
                    }

                    sbValues.Remove(sbValues.Length - 2, 2);

                    string query = string.Format("UPDATE {0} SET {1} WHERE {2}", tableName, sbValues, condition);

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        foreach (KeyValuePair<string, object> pair in data)
                        {
                            cmd.Parameters.AddWithValue("@" + pair.Key, pair.Value);
                        }
                        rowAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Pesan Error : \n" + ex.Message);
            }
            return rowAffected;
        }

        // Function Delete
        public static int Delete(string tableName, string condition)
        {
            int rowAffected = 0;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = string.Format("DELETE FROM {0} WHERE {1}", tableName, condition);

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        rowAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Pesan Error : \n" + ex.Message);
            }
            return rowAffected;
        }

        // Function Get Data
        public static DataTable GetData(string tableName, string condition = null)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = string.Format("SELECT * FROM {0}", tableName);

                    if (!string.IsNullOrEmpty(condition))
                        query += string.Format("WHERE {0}", condition);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Pesan Error : \n" + ex.Message);
            }
            return dt;
        }

        // Function Login App

        public static DataTable Login(string tableName, string username, string password)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = string.Format("SELECT * FROM {0} WHERE email=@username AND password = @password ", tableName);

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Pesan Error : \n" + ex.Message);
            }
            return dt;
        }
    }
}
