using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlLibrary;
using DataConnectionLibrary;

namespace ConnectionStrings1
{
    public partial class Form1 : Form
    {
        private List<ProjectConnection> _projectConnections; 
        public Form1()
        {
            InitializeComponent();
            Shown += Form1_Shown;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
            var extender = new ListViewExtender(connectionsListView);

            var buttonAction = new ListViewButtonColumn(0) {FixedWidth = true};
            buttonAction.Click += OnButtonActionClick;
            
            extender.AddColumn(buttonAction);

            var ops = new ConnectionHelper();
            _projectConnections = ops.Connections;

            if (_projectConnections.Count == 0)
            {
                return;
            }

            connectionsListView.ItemSelectionChanged += ConnectionsListView_ItemSelectionChanged;

            foreach (var projectConnection in _projectConnections)
            {
                connectionsListView.Items.Add(new ListViewItem(projectConnection.ItemArray)
                {
                    Tag = projectConnection.Name /* This is what we need to access a connection string */
                }) ;
            }

            connectionsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            connectionsListView.FocusedItem = connectionsListView.Items[0];
            connectionsListView.Items[0].Selected = true;

            ActiveControl = connectionsListView;

        }
        /// <summary>
        /// Show several properties for the selected connection string
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConnectionsListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (!e.IsSelected) return;

            var projectConnection = _projectConnections
                .FirstOrDefault(projectConnectionItem => projectConnectionItem.Name == e.Item.Tag.ToString());

            ConnectionNameTextBox.Text = projectConnection?.Name;
            ProviderTextBox.Text = projectConnection?.Provider;

        }
        private void OnButtonActionClick(object sender, ListViewColumnMouseEventArgs e)
        {
            // not stored in app configuration file
            if (e.SubItem.Text == "LocalSqlServer")
            {
                MessageBox.Show("Can not change LocalSqlServer connection!!!");
                return;
            }

            // Get current connection
            var projectConnection = _projectConnections
                .FirstOrDefault(projectConnectionItem => projectConnectionItem.Name == e.Item.Tag.ToString());

            var f = new ChangeServerForm(e.SubItem.Text);

            try
            {
                if (f.ShowDialog() != DialogResult.OK) return;

                var ops = new ConnectionHelper();
                ops.ChangeServer(projectConnection.Name, f.NewServerName);
                e.SubItem.Text = f.NewServerName;

            }
            finally
            {
                f.Dispose();
            }

        }
    }
}
