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
    static class AllData
    {
        public static DataTable GetAllData(String dataBase, SqlDataAdapter sqlAdapter, SqlConnection sqlConnection)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from " + dataBase, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public static DataTable GetAllData(String dataBase, String column, String operation, String filter, SqlDataAdapter sqlAdapter, SqlConnection sqlConnection)
        {
            DataTable dataTable = new DataTable();
            String query;
            //different query if digit expected
            if (operation.Equals("<") || operation.Equals("<=") || operation.Equals(">") || operation.Equals(">=") || operation.Equals("="))
                query = @"select * from " + dataBase + " where " + column + " " + operation + " " + filter;
            else
                query = @"select * from " + dataBase + " where " + column + " " + operation + " '%" + filter + "%'";
            //for debuging reasons
            Debug.WriteLine(query);
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
            };
            return dataTable;
        }
    }
}
