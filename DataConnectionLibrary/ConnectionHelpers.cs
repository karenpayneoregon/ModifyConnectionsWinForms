using System;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace DataConnectionLibrary
{
    public static class ConnectionHelpers
    {
        /// <summary>
        /// Get default namespace
        /// </summary>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static string CurrentNamespace()
        {
            return Assembly.GetCallingAssembly().EntryPoint.DeclaringType.Namespace;
        }
        /// <summary>
        /// Create path to specific setting in caller's configuration file
        /// </summary>
        /// <param name="projectNamespace">Namespace where configuration file resides</param>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static string DefaultConnectionPath(string projectNamespace,string sender)
        {
            return $"{projectNamespace}.Properties.Settings.{sender}";
        }

        /// <summary>
        /// Determine if a connection string exists
        /// </summary>
        /// <param name="value"></param>
        /// <param name="key">ConnectionString name</param>
        /// <returns>true if connection string exists, false if not found</returns>
        /// <remarks>
        /// Throws an exception if not found, we ignore this.
        /// </remarks>
        public static bool HasConnectionString(this ConnectionStringSettingsCollection value, string key)
        {
            try
            {
                var location = Assembly.GetEntryAssembly().Location;
                return value[$"{Path.GetFileNameWithoutExtension(location)}.Properties.Settings.{key}"].ConnectionString.Length > 0;
            }
            catch
            {
                return false;
            }
        }

    }
}
