using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace UAS_03082180053_03082190021
{
  
    static class db
    {
        public static OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\LENOVO LEGION\\source\\repos\\UAS_03082180053_03082190021\\03082180053_UAS_03082190021.accdb");

        public static void executeNonQuery(String sql)
        {
            try
            {
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandText = sql;
                con.Open();
                cmd.Connection = con;
                cmd.ExecuteScalar();                
                con.Close();                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Somehing went wrong");
                con.Close();                
            }
        }
        
        public static int executeNonQuery(String sql,String successMessage)
        {
            try
            {
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandText = sql;
                con.Open();
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Select @@Identity";
                int modified = (int)cmd.ExecuteScalar();               
                con.Close();
                MessageBox.Show(successMessage, "Done");
                return modified;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Somehing went wrong");
                con.Close();
                return -1;
            }                        
        }
        public static List<List<String>> executeQuery(String sql)
        {
            List<List<String>> data = new List<List<String>>();
            try
            {
                OleDbCommand cmd = new OleDbCommand(sql, con);
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    List<String> row = new List<String>();
                    int rowCount = reader.FieldCount;
                    for (int i = 0; i < rowCount; i++)
                    {                        
                        row.Add(reader.GetValue(i).ToString());
                    }
                    
                    data.Add(row);
                }
                con.Close();                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Somehing went wrong");
                con.Close();
            }
            return data;
        }
        public static object executeScalar(String sql)
        {
            try
            {
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandText = sql;
                con.Open();
                object data = cmd.ExecuteScalar();
                con.Close();
                return data;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Somehing went wrong");
                return -1;
            }
        }
    }
}
