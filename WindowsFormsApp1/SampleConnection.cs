using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseConnectionLibrary.ConnectionClasses;

namespace WindowsFormsApp1
{
    public class SampleConnection : SqlServerConnection
    {
        public SampleConnection()
        {
            DatabaseServer = "KARENS-PC";
            DefaultCatalog = "NorthWind";
        }
        public void PutConnectionTogetherForMe()
        {
            using (var cn = new SqlConnection() {ConnectionString = ConnectionString})
            {
                cn.Open();
            }
        }

        public void TemporaryChangeConnectionString(string connectionString)
        {
            var builder = new SqlConnectionStringBuilder
            {
                ConnectionString = connectionString
            };

            builder.DataSource = "SomeOtherServer";

            using (var cn = new SqlConnection() { ConnectionString = builder.ConnectionString })
            {
                cn.Open();
            }
        }

        public void FromApplicationConfigurationFileConnectionString()
        {
            using (var cn = new SqlConnection())
            {
                cn.ConnectionString = Properties.Settings.Default.NorthWind;
                cn.Open();
            }
        }

        public void HardWiredConnectionString() 
        {
            using (var cn = new SqlConnection())
            {
                cn.ConnectionString = "Data Source=KARENS-PC;Initial Catalog=NorthWind;Integrated Security=True";
                cn.Open();
            }
        }



    }
}
