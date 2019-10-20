namespace WindowsFormsApp1
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
            this.ChangeConnectionStringButton = new System.Windows.Forms.Button();
            this.ViewConnectionStringButton = new System.Windows.Forms.Button();
            this.ServerNameTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.GetDatabaseNamesButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ChangeConnectionStringButton1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChangeConnectionStringButton
            // 
            this.ChangeConnectionStringButton.Location = new System.Drawing.Point(42, 27);
            this.ChangeConnectionStringButton.Name = "ChangeConnectionStringButton";
            this.ChangeConnectionStringButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeConnectionStringButton.TabIndex = 0;
            this.ChangeConnectionStringButton.Text = "Change";
            this.ChangeConnectionStringButton.UseVisualStyleBackColor = true;
            this.ChangeConnectionStringButton.Click += new System.EventHandler(this.ChangeConnectionStringButton_Click);
            // 
            // ViewConnectionStringButton
            // 
            this.ViewConnectionStringButton.Location = new System.Drawing.Point(42, 56);
            this.ViewConnectionStringButton.Name = "ViewConnectionStringButton";
            this.ViewConnectionStringButton.Size = new System.Drawing.Size(75, 23);
            this.ViewConnectionStringButton.TabIndex = 1;
            this.ViewConnectionStringButton.Text = "View";
            this.ViewConnectionStringButton.UseVisualStyleBackColor = true;
            this.ViewConnectionStringButton.Click += new System.EventHandler(this.ViewConnectionStringButton_Click);
            // 
            // ServerNameTextBox
            // 
            this.ServerNameTextBox.Location = new System.Drawing.Point(140, 27);
            this.ServerNameTextBox.Name = "ServerNameTextBox";
            this.ServerNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ServerNameTextBox.TabIndex = 2;
            this.ServerNameTextBox.Text = "MyServer";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(434, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(255, 238);
            this.listBox1.TabIndex = 3;
            // 
            // GetDatabaseNamesButton
            // 
            this.GetDatabaseNamesButton.Location = new System.Drawing.Point(434, 256);
            this.GetDatabaseNamesButton.Name = "GetDatabaseNamesButton";
            this.GetDatabaseNamesButton.Size = new System.Drawing.Size(75, 23);
            this.GetDatabaseNamesButton.TabIndex = 4;
            this.GetDatabaseNamesButton.Text = "Databases";
            this.GetDatabaseNamesButton.UseVisualStyleBackColor = true;
            this.GetDatabaseNamesButton.Click += new System.EventHandler(this.GetDatabaseNamesButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChangeConnectionStringButton1
            // 
            this.ChangeConnectionStringButton1.Location = new System.Drawing.Point(262, 25);
            this.ChangeConnectionStringButton1.Name = "ChangeConnectionStringButton1";
            this.ChangeConnectionStringButton1.Size = new System.Drawing.Size(75, 23);
            this.ChangeConnectionStringButton1.TabIndex = 6;
            this.ChangeConnectionStringButton1.Text = "Change";
            this.ChangeConnectionStringButton1.UseVisualStyleBackColor = true;
            this.ChangeConnectionStringButton1.Click += new System.EventHandler(this.ChangeConnectionStringButton1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(42, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(45, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(45, 239);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(249, 185);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 318);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ChangeConnectionStringButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GetDatabaseNamesButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ServerNameTextBox);
            this.Controls.Add(this.ViewConnectionStringButton);
            this.Controls.Add(this.ChangeConnectionStringButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Change Connection string";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangeConnectionStringButton;
        private System.Windows.Forms.Button ViewConnectionStringButton;
        private System.Windows.Forms.TextBox ServerNameTextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button GetDatabaseNamesButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ChangeConnectionStringButton1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

