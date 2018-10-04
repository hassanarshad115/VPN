using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PureVPN.Models
{
    public class UDatabase
    {
        private SqlConnection connection;

        public UDatabase()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["VPN"].ConnectionString);
        }

        public DataTable Query(string query)
        {
            DataTable dataTable = new DataTable();

            using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection))
            {
                connection.Open();
                
                sqlDataAdapter.Fill(dataTable);
            }

            return dataTable;
        }

        public DataTable StoredProcedure(string storedProcedureName, List<SqlParameter> inputParameters)
        {
            DataTable dataTable = new DataTable();

            using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                foreach (SqlParameter parameter in inputParameters)
                {
                    command.Parameters.Add(parameter);
                }
                
                command.ExecuteNonQuery();

                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
                {   
                    sqlDataAdapter.SelectCommand = command;
                    sqlDataAdapter.Fill(dataTable);
                }
            }

            return dataTable;
        }
    }
}
