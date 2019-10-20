using System.Data.SqlClient;

namespace DataConnectionLibrary
{
    public class ConnectionProperties
    {
        public string DataSource { get; set; }
        public string InitialCatalog { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public string AttachDbFilename { get; set; }
        public bool IsAttached => !string.IsNullOrWhiteSpace(AttachDbFilename);
        public SqlAuthenticationMethod Authentication { get; set; }
        public bool IntegratedSecurity { get; set; }
        public bool IsValid { get; set; }

        
    }
}
