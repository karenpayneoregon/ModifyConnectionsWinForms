using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataConnectionLibrary;
using static DataConnectionLibrary.ConnectionHelpers;

namespace ConnectionStrings2
{
    public partial class Form1 : Form
    {
        private List<ProjectConnection> _projectConnections;
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Load Categories table using current connection string from the
        /// configuration file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            if (Environment.UserName == "Karens")
            {
                categoriesTableAdapter.Fill(northWindAzureDataSet.Categories);
            }

            var ops = new ConnectionHelper();
            _projectConnections = ops.Connections;

            /*
             * Get connection name
             */
            var connectionName = DefaultConnectionPath(CurrentNamespace(), _projectConnections[1].RealName());
            /*
             * Get current connection InitialCatalog
             */
            InitialCatalogLabel.Text = $"Current catalog '{ops.Properties(connectionName).InitialCatalog}'";

        }
        private void ToggleCatalogButton_Click(object sender, EventArgs e)
        {
            var ops = new ConnectionHelper();
            _projectConnections = ops.Connections;

            var connectionName = DefaultConnectionPath(CurrentNamespace(), _projectConnections[1].RealName());

            /*
             * Get connection properties for the current connection string in connectionName
             */
            var properties = ops.Properties(connectionName);

            /*
             * Toggle between two databases - both must match for the TableAdapter classes
             */
            ops.ChangeInitialCatalog(connectionName, properties.InitialCatalog == "NorthWindAzure1" ? 
                "NorthWindAzure3" : 
                "NorthWindAzure1");

            connectionName = DefaultConnectionPath(CurrentNamespace(), _projectConnections[1].RealName());

            InitialCatalogLabel.Text = $"Current catalog '{ops.Properties(connectionName).InitialCatalog}'";

            // restart app to use no catalog
            Application.Restart();
        }
    }
}
