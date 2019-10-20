namespace ConnectionStrings2
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
            this.components = new System.ComponentModel.Container();
            this.northWindAzureDataSet = new ConnectionStrings2.NorthWindAzureDataSet();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new ConnectionStrings2.NorthWindAzureDataSetTableAdapters.CategoriesTableAdapter();
            this.tableAdapterManager = new ConnectionStrings2.NorthWindAzureDataSetTableAdapters.TableAdapterManager();
            this.categoriesComboBox = new System.Windows.Forms.ComboBox();
            this.ToggleCatalogButton = new System.Windows.Forms.Button();
            this.InitialCatalogLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.northWindAzureDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // northWindAzureDataSet
            // 
            this.northWindAzureDataSet.DataSetName = "NorthWindAzureDataSet";
            this.northWindAzureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.northWindAzureDataSet;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = this.categoriesTableAdapter;
            this.tableAdapterManager.UpdateOrder = ConnectionStrings2.NorthWindAzureDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // categoriesComboBox
            // 
            this.categoriesComboBox.DataSource = this.categoriesBindingSource;
            this.categoriesComboBox.DisplayMember = "CategoryName";
            this.categoriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriesComboBox.FormattingEnabled = true;
            this.categoriesComboBox.Location = new System.Drawing.Point(25, 12);
            this.categoriesComboBox.Name = "categoriesComboBox";
            this.categoriesComboBox.Size = new System.Drawing.Size(300, 21);
            this.categoriesComboBox.TabIndex = 1;
            this.categoriesComboBox.ValueMember = "CategoryID";
            // 
            // ToggleCatalogButton
            // 
            this.ToggleCatalogButton.Location = new System.Drawing.Point(100, 124);
            this.ToggleCatalogButton.Name = "ToggleCatalogButton";
            this.ToggleCatalogButton.Size = new System.Drawing.Size(151, 23);
            this.ToggleCatalogButton.TabIndex = 2;
            this.ToggleCatalogButton.Text = "Toggle Initial catalog";
            this.ToggleCatalogButton.UseVisualStyleBackColor = true;
            this.ToggleCatalogButton.Click += new System.EventHandler(this.ToggleCatalogButton_Click);
            // 
            // InitialCatalogLabel
            // 
            this.InitialCatalogLabel.AutoSize = true;
            this.InitialCatalogLabel.Location = new System.Drawing.Point(99, 100);
            this.InitialCatalogLabel.Name = "InitialCatalogLabel";
            this.InitialCatalogLabel.Size = new System.Drawing.Size(35, 13);
            this.InitialCatalogLabel.TabIndex = 3;
            this.InitialCatalogLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 159);
            this.Controls.Add(this.InitialCatalogLabel);
            this.Controls.Add(this.ToggleCatalogButton);
            this.Controls.Add(this.categoriesComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TableAdapter example";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.northWindAzureDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NorthWindAzureDataSet northWindAzureDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private NorthWindAzureDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private NorthWindAzureDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox categoriesComboBox;
        private System.Windows.Forms.Button ToggleCatalogButton;
        private System.Windows.Forms.Label InitialCatalogLabel;
    }
}

