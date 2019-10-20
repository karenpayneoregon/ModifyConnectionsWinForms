namespace ConnectionStrings1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.connectionsListView = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ConnectionStringColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.ConnectionNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProviderTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // connectionsListView
            // 
            this.connectionsListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.ConnectionStringColumn});
            this.connectionsListView.FullRowSelect = true;
            this.connectionsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.connectionsListView.Location = new System.Drawing.Point(12, 12);
            this.connectionsListView.Name = "connectionsListView";
            this.connectionsListView.Size = new System.Drawing.Size(776, 142);
            this.connectionsListView.TabIndex = 0;
            this.connectionsListView.UseCompatibleStateImageBehavior = false;
            this.connectionsListView.View = System.Windows.Forms.View.Details;
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Nice name";
            this.NameColumn.Width = 120;
            // 
            // ConnectionStringColumn
            // 
            this.ConnectionStringColumn.Text = "Connection string";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connection internal name";
            // 
            // ConnectionNameTextBox
            // 
            this.ConnectionNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectionNameTextBox.Location = new System.Drawing.Point(150, 168);
            this.ConnectionNameTextBox.Name = "ConnectionNameTextBox";
            this.ConnectionNameTextBox.Size = new System.Drawing.Size(638, 20);
            this.ConnectionNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Provider";
            // 
            // ProviderTextBox
            // 
            this.ProviderTextBox.Location = new System.Drawing.Point(150, 202);
            this.ProviderTextBox.Name = "ProviderTextBox";
            this.ProviderTextBox.Size = new System.Drawing.Size(172, 20);
            this.ProviderTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 263);
            this.Controls.Add(this.ProviderTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConnectionNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connectionsListView);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Connections";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView connectionsListView;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader ConnectionStringColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ConnectionNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProviderTextBox;
    }
}

