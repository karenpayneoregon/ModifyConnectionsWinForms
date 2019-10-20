using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using static System.Configuration.ConfigurationManager;

namespace DataConnectionLibrary  
{
    /// <summary>
    /// Provides methods to interact with connection strings at runtime.
    /// Designed to use by referencing this project to a Windows Form project.
    /// </summary>
    public class ConnectionHelper
    {
        /// <summary>
        /// Provides functionality to obtain parent application namespace
        /// </summary>
        private readonly AssemblyHelpers _assemblyHelpers = new AssemblyHelpers();

        /// <summary>
        /// Return all connection string in app.config include default localDb or SQLEXPRESS
        /// </summary>
        /// <returns></returns>
        public List<ProjectConnection> Connections => ConnectionStrings.Cast<ConnectionStringSettings>().Select((item) => new ProjectConnection
        {
            Name = item.Name.Replace($"{this.GetType().Namespace}.Properties.Settings.", ""),
            Provider = item.ProviderName, 
            ConnectionString = item.ConnectionString
        }).ToList();
      

        /// <summary>
        /// Determine if there are local connections
        /// </summary>
        public bool HasConnections => Connections.Count > 1;
        /// <summary>
        /// Get local connection
        /// </summary>
        public ProjectConnection LocalConnection => Connections[0];
        /// <summary>
        /// Get first connection
        /// </summary>
        /// <remarks>
        /// Used when there is one known connection string
        /// </remarks>
        public ProjectConnection SoleConnection => Connections[1];
        /// <summary>
        /// Get properties for a single connection string
        /// </summary>
        /// <param name="pConnectionName"></param>
        /// <returns></returns>
        public ConnectionProperties Properties(string pConnectionName)
        {
            var connectionProperties = new ConnectionProperties();
            
            if (ConnectionStrings.Cast<ConnectionStringSettings>().FirstOrDefault((css) => css.Name == pConnectionName) == null)
            {
                return connectionProperties;
            }

            Configuration configuration = OpenExeConfiguration(_assemblyHelpers.CallingNamespace());
            var section = (ConnectionStringsSection)configuration.GetSection("connectionStrings");

            try
            {
                var currentConnectionString = section.ConnectionStrings[pConnectionName].ConnectionString;

                var builder = new SqlConnectionStringBuilder
                {
                    ConnectionString = currentConnectionString
                };
                
                connectionProperties = new ConnectionProperties
                {
                    DataSource = builder.DataSource,
                    InitialCatalog = builder.InitialCatalog,
                    Authentication = builder.Authentication,
                    AttachDbFilename = builder.AttachDBFilename,
                    IntegratedSecurity = builder.IntegratedSecurity,
                    IsValid = true
                };

            }
            catch (Exception)
            {
                connectionProperties.IsValid = false;
            }

            return connectionProperties;

        }

        /// <summary>
        /// Change server in connection string
        /// </summary>
        /// <param name="pConnectionName">Existing connection string in app.config</param>
        /// <param name="pServerName">Replace server name currently in app.config with this server name</param>
        public bool ChangeServer(string pConnectionName, string pServerName)
        {

            try
            {
                // Assert named connection string pConnectionName exists
                if (ConnectionStrings.Cast<ConnectionStringSettings>().FirstOrDefault((css) => css.Name == pConnectionName) != null)
                {

                    Configuration configuration = OpenExeConfiguration(_assemblyHelpers.CallingNamespace());
                    var section = (ConnectionStringsSection)configuration.GetSection("connectionStrings");

                    var currentConnectionString = section.ConnectionStrings[pConnectionName].ConnectionString;

                    var builder = new SqlConnectionStringBuilder
                    {
                        ConnectionString = currentConnectionString,
                        DataSource = pServerName
                    };

                    section.ConnectionStrings[pConnectionName].ConnectionString = builder.ConnectionString;
                    configuration.Save(ConfigurationSaveMode.Modified);
                    RefreshSection("connectionStrings");
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }
        /// <summary>
        /// Change server and catalog in connection string
        /// </summary>
        /// <param name="pConnectionName">Existing connection string in app.config</param>
        /// <param name="pServerName">Replace server name currently in app.config with this server name</param>
        /// <param name="pCatalog">Replace current catalog with replacement catalog</param>
        public void ChangeServer(string pConnectionName, string pServerName, string pCatalog)
        {

            // Assert named connection string pConnectionName exists
            if (ConnectionStrings.Cast<ConnectionStringSettings>().FirstOrDefault((css) => css.Name == pConnectionName) != null)
            {

                Configuration configuration = OpenExeConfiguration(_assemblyHelpers.CallingNamespace());
                var section = (ConnectionStringsSection)configuration.GetSection("connectionStrings");

                var currentConnectionString = section.ConnectionStrings[pConnectionName].ConnectionString;

                var builder = new SqlConnectionStringBuilder
                {
                    ConnectionString = currentConnectionString,
                    InitialCatalog = pCatalog,
                    DataSource = pServerName
                };

                section.ConnectionStrings[pConnectionName].ConnectionString = builder.ConnectionString;
                configuration.Save(ConfigurationSaveMode.Modified);
                RefreshSection("connectionStrings");

            }
        }
        /// <summary>
        /// Change initial catalog for specific connection string
        /// </summary>
        /// <param name="pConnectionName">Existing connection string in app.config</param>
        /// <param name="pCatalog">Replace current catalog with replacement catalog</param>
        public void ChangeInitialCatalog(string pConnectionName, string pCatalog)
        {

            // Assert named connection string pConnectionName exists
            if (ConnectionStrings.Cast<ConnectionStringSettings>().FirstOrDefault((css) => css.Name == pConnectionName) != null)
            {

                Configuration configuration = OpenExeConfiguration(_assemblyHelpers.CallingNamespace());
                var section = (ConnectionStringsSection)configuration.GetSection("connectionStrings");

                var currentConnectionString = section.ConnectionStrings[pConnectionName].ConnectionString;

                var builder = new SqlConnectionStringBuilder
                {
                    ConnectionString = currentConnectionString,
                    InitialCatalog = pCatalog
                };

                section.ConnectionStrings[pConnectionName].ConnectionString = builder.ConnectionString;
                configuration.Save(ConfigurationSaveMode.Modified);
                RefreshSection("connectionStrings");
            }
        }
    }
}
