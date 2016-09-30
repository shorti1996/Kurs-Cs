using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WojciechLiebertLab4
{
    static class Customer
    {

        public static DataTable GetAllCustomer(SqlDataAdapter sqlAdapter, SqlConnection sqlConnection)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Customer", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
    }
}
