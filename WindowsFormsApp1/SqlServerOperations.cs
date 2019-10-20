using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public class SqlServerOperations
    {
        public List<string> DatabaseNames()
        {
            var connectionString = "Data Source=KARENS-PC;Initial Catalog=master;Integrated Security=True";
            var nameList = new List<string>();
            
            using (var cn = new SqlConnection {ConnectionString = connectionString})
            {
                var builder = new SqlConnectionStringBuilder
                {
                    ConnectionString = cn.ConnectionString
                };

                using (var cmd = new SqlCommand {Connection = cn})
                {
                    var selectStatement = 
                        "SELECT [name]  " + 
                        "FROM master.sys.databases " + 
                        "WHERE state <> 6 AND database_id > 4 AND HAS_DBACCESS([name]) = 1 " + 
                        "ORDER BY name";

                    cmd.CommandText = selectStatement;

                    cn.Open();

                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        nameList.Add(reader.GetString(0));
                    }

                }
            }

            return nameList;
        }
    }
}
