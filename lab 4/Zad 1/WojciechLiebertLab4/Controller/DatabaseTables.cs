using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WojciechLiebertLab4
{
    static class DatabaseTables
    {
        public static List<String> GetAllTableNames(SqlDataAdapter sqlAdapter, SqlConnection sqlConnection) {
            List<String> items = new List<String>();
            SqlCommand sqlCommand = new SqlCommand("select table_name from Zad1.INFORMATION_SCHEMA.TABLES where TABLE_TYPE = 'BASE TABLE' and table_name not like 'sysdiagrams'", sqlConnection);
            sqlConnection.Open();
            //read one item per cycle
            SqlDataReader sqlReader = sqlCommand.ExecuteReader();
            while (sqlReader.Read())
            {
                items.Add(sqlReader[0].ToString());
            }
            sqlReader.Close();
            return items;
        }
    }
}
