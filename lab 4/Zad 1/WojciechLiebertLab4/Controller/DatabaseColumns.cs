using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WojciechLiebertLab4
{
    static class DatabaseColumns
    {
        public static List<String> GetAllTableNames(SqlDataAdapter sqlAdapter, SqlConnection sqlConnection)
        {
            List<String> items = new List<String>();
            SqlCommand sqlCommand = new SqlCommand("exec sp_columns [Owner]", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlReader = sqlCommand.ExecuteReader();
            //read one item to items (List) per cycle
            while (sqlReader.Read())
            {
                items.Add(sqlReader[0].ToString());
                Debug.WriteLine(sqlReader[0].ToString());
            }
            sqlReader.Close();
            return items;
        }
    }
}
