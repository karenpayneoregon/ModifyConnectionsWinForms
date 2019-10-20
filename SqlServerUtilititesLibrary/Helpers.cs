using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceProcess;
using BaseConnectionLibrary;

namespace SqlServerUtilititesLibrary
{
    public class Helpers : BaseExceptionProperties
    {
        /// <summary> 
        /// Determine if a specific SQL-Server is available 
        /// </summary> 
        /// <param name="pServerName"></param> 
        /// <returns></returns> 
        public async Task<bool> SqlServerIsAvailable(string pServerName)
        {
            mHasException = false;
            bool success = false;

            try
            {
                await Task.Run(() =>
                {
                    var sqlDataSourceEnumeratorInstance = SqlDataSourceEnumerator.Instance;
                    DataTable dt = sqlDataSourceEnumeratorInstance.GetDataSources();

                    // ReSharper disable once ConditionIsAlwaysTrueOrFalse
                    // ReSharper disable once InvertIf
                    if (dt != null)
                    {
                        if (dt.Rows.Count > 0)
                        {
                            var row = dt.AsEnumerable().FirstOrDefault(
                                dataRow => 
                                    dataRow.Field<string>("ServerName") == pServerName.ToUpper());

                            success = row != null;

                        }
                        else
                        {
                            success = false;
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                mHasException = true;
                mLastException = ex;
            }

            return success;
        }
        public async Task<List<string>> ServerNames()
        {
            mHasException = false;
            var serverNames = new List<string>();

            try
            {
                await Task.Run(() =>
                {
                    var sqlDataSourceEnumeratorInstance = SqlDataSourceEnumerator.Instance;
                    DataTable dt = sqlDataSourceEnumeratorInstance.GetDataSources();

                    // ReSharper disable once ConditionIsAlwaysTrueOrFalse
                    // ReSharper disable once InvertIf
                    if (dt != null)
                    {
                        if (dt.Rows.Count > 0)
                        {
                            foreach (DataRow row in dt.Rows)
                            {
                                serverNames.Add(row.Field<string>("ServerName"));
                            }
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                mHasException = true;
                mLastException = ex;
            }

            return serverNames;
        }

        /// <summary>
        /// Determine if a specific service is running e.g.
        /// SQL-Server: MSSQLServer
        /// MSSQLSERVER
        /// SQL Server Agent: SQLServerAgent 
        /// SQL Server Analysis Services: MSSQLServerOLAPService
        /// SQL Server Browser: SQLBrowser
        /// </summary>
        /// <param name="serviceName">Service name to find</param>
        /// <returns>True if found, false if not</returns>
        public static bool IsWindowsServiceRunning(string serviceName) 
        {
            var isRunning = false;
            var services = ServiceController.GetServices().Where(sc => sc.ServiceName.Contains("SQL")).ToList();

            foreach (var service in services)
            {
                if (service.ServiceName == serviceName)
                {
                    if (service.Status == ServiceControllerStatus.Running)
                    {
                        isRunning = true;
                    }

                }
            }

            return isRunning;

        }
    }
}
