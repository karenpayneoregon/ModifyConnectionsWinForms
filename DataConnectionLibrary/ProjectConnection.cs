using System.IO;

namespace DataConnectionLibrary
{
    /// <summary>
    /// Container for connection string properties
    /// </summary>
    public class ProjectConnection
    {
        /// <summary>
        /// Connection name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Return connection name without leading namespace
        /// </summary>
        /// <returns></returns>
        public string RealName()
        {
            var helper = new AssemblyHelpers();
            var workSection = $"{Path.GetFileNameWithoutExtension(helper.CallingNamespace())}.Properties.Settings.";
            return Name.Replace(workSection, "");
        }
        /// <summary>
        /// Connection string
        /// </summary>
        public string ConnectionString { get; set; }
        /// <summary>
        /// Data provider for connection
        /// </summary>
        public string Provider { get; set; }
        public override string ToString()
        {
            return Name;
        }
        /// <summary>
        /// Used for loading a ListView control easily.
        /// </summary>
        public string[] ItemArray => new[]
        {
            RealName(),
            ConnectionString
        };
    }
}