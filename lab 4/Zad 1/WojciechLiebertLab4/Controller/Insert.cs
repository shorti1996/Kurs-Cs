using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms; //for MessageBox

namespace WojciechLiebertLab4
{
    static class Insert
    {
        public static void InsertData(SqlDataAdapter sqlAdapter, SqlConnection sqlConnection, string query, string insert)
        {
            String insertCommand = "INSERT INTO " + query + " VALUES (" + insert + ")";
            Debug.WriteLine(insertCommand);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(insertCommand, sqlConnection);
        }
        
    }
}

        