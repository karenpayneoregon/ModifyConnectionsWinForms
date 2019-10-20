using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataConnectionLibrary;
using SqlServerUtilititesLibrary;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Shows various code for how a novice coder might go about figuring out
    /// how to work with connection strings at runtime.
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChangeConnectionStringButton_Click(object sender, EventArgs e)
        {
            var connectionStringName = "SqlServer1"; 

            if (string.IsNullOrWhiteSpace(ServerNameTextBox.Text))
            {
                MessageBox.Show("Need a new server name");
                return;
            }

            if (!ConfigurationManager.ConnectionStrings.HasConnectionString(connectionStringName))
            {
                MessageBox.Show("Connection string does not exists");
                return;
            }
            
            // This variable represents the connection string to change
            var connectionName = $"{Path.GetFileNameWithoutExtension(Application.ExecutablePath)}.Properties.Settings.{connectionStringName}";

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //Get all connection strings
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            Console.WriteLine(connectionStringsSection.ConnectionStrings.Count);
            // Show connection string we are interested in
            Console.WriteLine(connectionStringsSection.ConnectionStrings[connectionName].ConnectionString);

            // Change the connection string, in this case just the [Data Source]
            connectionStringsSection.ConnectionStrings[connectionName].ConnectionString = 
                $"Data Source={ServerNameTextBox.Text};Initial Catalog=blah;UID=blah;password=blah";

            // save
            config.Save();

            // Important, needs to be done to recognize the change
            ConfigurationManager.RefreshSection("connectionStrings");
            
        }
        private void ChangeConnectionStringButton1_Click(object sender, EventArgs e)
        {
            var ops = new ConnectionHelper();
            ops.ChangeServer("WindowsFormsApp1.Properties.Settings.NorthWind", "MaryPC","A111");
        }
        private void ViewConnectionStringButton_Click(object sender, EventArgs e)
        {
            var connectionStringName = "SqlServer1";

            if (!ConfigurationManager.ConnectionStrings.HasConnectionString(connectionStringName))
            {
                MessageBox.Show("Connection string does not exists");
                return;
            }

            Console.WriteLine();
            // This variable represents the connection string to change
            var connectionName = $"{Path.GetFileNameWithoutExtension(Application.ExecutablePath)}.Properties.Settings.{connectionStringName}";

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //Get all connection strings
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            // Show connection string we are interested in
            Console.WriteLine(connectionStringsSection.ConnectionStrings[connectionName].ConnectionString);

        }

        private void GetDatabaseNamesButton_Click(object sender, EventArgs e)
        {
            var ops = new SqlServerOperations();
            listBox1.DataSource = ops.DatabaseNames();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ops = new ConnectionHelper();

            List<ProjectConnection> results = ops.Connections; 

            Console.WriteLine();
            foreach (ProjectConnection projectConnection in results)
            {
                ConnectionProperties item = ops.Properties(projectConnection.RealName());
                Console.WriteLine(projectConnection.RealName());
                //Console.WriteLine($"{projectConnection.Name}");
                //Console.WriteLine($"{item.DataSource}, {item.InitialCatalog},{item.IntegratedSecurity}, '{item.AttachDbFilename}', {item.IsAttached}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Connection string in app.config
            var connectionStringName = "SqlServer1";

            // New Server name
            var serverName = "JOHNS-PC";


            if (string.IsNullOrWhiteSpace(ServerNameTextBox.Text))
            {
                MessageBox.Show("Need a new server name");
                return;
            }

            // This variable represents the connection string to change
            var connectionName = $"{Path.GetFileNameWithoutExtension(Application.ExecutablePath)}" + 
                                 $".Properties.Settings.{connectionStringName}";

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //Get all connection strings
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            // Change the connection string, in this case just the [Data Source]
            connectionStringsSection.ConnectionStrings[connectionName].ConnectionString = 
                $"Data Source={serverName};Initial Catalog=blah;UID=blah;password=blah";
            // save
            config.Save();
            // Important, needs to be done to recognize the change
            ConfigurationManager.RefreshSection("connectionStrings");

        }

        private bool _working = false;
        private async void button3_Click(object sender, EventArgs e)
        {
            if (_working)
            {
                MessageBox.Show("Working");
                return;
                
            }
            var builder = new SqlConnectionStringBuilder
            {
                ConnectionString = Properties.Settings.Default.NorthWind
            };

            _working = true;
            var ops = new Helpers();
            var result = await ops.SqlServerIsAvailable(builder.DataSource).ConfigureAwait(true);
            
            _working = false;

        }

        private async void button4_Click(object sender, EventArgs e)
        {
            

            //var builder = new SqlConnectionStringBuilder
            //{
            //    ConnectionString = Properties.Settings.Default.NorthWind
            //};
            //Console.WriteLine(builder.DataSource);

            var ops = new Helpers();
            var result = await ops.ServerNames().ConfigureAwait(true);
            if (result.Count >0)
            {
                result.ForEach(name => Console.WriteLine($"'{name}'"));
            }
            else
            {
                Console.WriteLine("Done");
            }
        }
    }
}
