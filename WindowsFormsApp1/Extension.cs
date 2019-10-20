using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public static class Extension
    {
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
                Console.WriteLine(System.Reflection.Assembly.GetEntryAssembly().Location);
                return value[$"{Path.GetFileNameWithoutExtension(Application.ExecutablePath)}.Properties.Settings.{key}"]
                           .ConnectionString.Length > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}