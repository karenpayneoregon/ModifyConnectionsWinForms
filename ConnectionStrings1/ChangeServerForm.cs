using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlLibrary;

namespace ConnectionStrings1
{
    public partial class ChangeServerForm : Form
    {
        private string _currentServerName;
        private string _NewServerName = "";
        public string NewServerName => _NewServerName;
        public ChangeServerForm()
        {
            InitializeComponent();
        }

        public ChangeServerForm(string currentServerName)
        {
            InitializeComponent();

            _currentServerName = currentServerName;

            CurrentServerTextBox.Text = currentServerName;

            CurrentServerTextBox.ReadOnly = true;
            CurrentServerTextBox.Select(0,0);

            NewServerNameTextBox.SetCueText("Enter server name");

            ActiveControl = CurrentServerTextBox;
        }

        private void OkayButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(NewServerNameTextBox.Text))
            {
                MessageBox.Show("Server name required");
                return;
            }

            /*
             * Enclose server name with spaces with square brackets.
             */
            if (NewServerNameTextBox.Text.Contains(" ") && !Regex.IsMatch(NewServerNameTextBox.Text, @"^\[.*?\]$"))
            {
                NewServerNameTextBox.Text = $"[{NewServerNameTextBox.Text}]";
            }

            _NewServerName = NewServerNameTextBox.Text;
            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
