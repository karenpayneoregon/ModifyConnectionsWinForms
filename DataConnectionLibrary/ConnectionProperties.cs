using System.Data.SqlClient;

namespace DataConnectionLibrary
{
    public class ConnectionProperties
    {
        /// <summary>
        /// Server name
        /// </summary>
        public string DataSource { get; set; }
        /// <summary>
        /// Database to access
        /// </summary>
        public string InitialCatalog { get; set; }
        /// <summary>
        /// User id (not used)
        /// </summary>
        public string UserId { get; set; }
        /// <summary>
        /// User password (not used)
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Name of local database such as one stored for a database
        /// stored in the application folder.
        /// </summary>
        public string AttachDbFilename { get; set; }
        /// <summary>
        /// True if the database is an attached database, false if not
        /// </summary>
        public bool IsAttached => !string.IsNullOrWhiteSpace(AttachDbFilename);
        /// <summary>
        /// Describes the different SQL authentication methods that can be used
        /// by a client connecting to Azure SQL Database.
        /// </summary>
        /// <remarks>
        /// https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlauthenticationmethod?view=netframework-4.8
        /// </remarks>
        public SqlAuthenticationMethod Authentication { get; set; }
        /// <summary>
        /// True if integrated security is used, false if not
        /// </summary>
        public bool IntegratedSecurity { get; set; }
        /// <summary>
        /// Indicates if the object is valid
        /// </summary>
        public bool IsValid { get; set; }

        
    }
}
