namespace Fiddler.Extensions
{
    partial class QueryStringGridFilterUserControl : AbstractFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.singleFilterGroup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.searchConditionDataGrid = new System.Windows.Forms.DataGridView();
            this.searchConditionTextBox = new System.Windows.Forms.TextBox();
            this.IsVisible = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FilterConditionType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.FilterCondition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singleFilterGroup.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchConditionDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // singleFilterGroup
            // 
            this.singleFilterGroup.AutoSize = true;
            this.singleFilterGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.singleFilterGroup.Controls.Add(this.tableLayoutPanel1);
            this.singleFilterGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.singleFilterGroup.Location = new System.Drawing.Point(0, 0);
            this.singleFilterGroup.Name = "singleFilterGroup";
            this.singleFilterGroup.Size = new System.Drawing.Size(1081, 339);
            this.singleFilterGroup.TabIndex = 0;
            this.singleFilterGroup.TabStop = false;
            this.singleFilterGroup.Text = "SearchableFilterGroupBox";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.searchConditionDataGrid, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchConditionTextBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1075, 314);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // searchConditionDataGrid
            // 
            this.searchConditionDataGrid.AllowUserToOrderColumns = true;
            this.searchConditionDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.searchConditionDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchConditionDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsVisible,
            this.FilterConditionType,
            this.FilterCondition});
            this.searchConditionDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchConditionDataGrid.Location = new System.Drawing.Point(3, 35);
            this.searchConditionDataGrid.Name = "searchConditionDataGrid";
            this.searchConditionDataGrid.RowTemplate.Height = 28;
            this.searchConditionDataGrid.Size = new System.Drawing.Size(1069, 276);
            this.searchConditionDataGrid.TabIndex = 4;
            this.searchConditionDataGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.searchConditionDataGrid_CellFormatting);
            // 
            // searchConditionTextBox
            // 
            this.searchConditionTextBox.AcceptsReturn = true;
            this.searchConditionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchConditionTextBox.Location = new System.Drawing.Point(3, 3);
            this.searchConditionTextBox.Name = "searchConditionTextBox";
            this.searchConditionTextBox.Size = new System.Drawing.Size(1069, 26);
            this.searchConditionTextBox.TabIndex = 5;
            this.searchConditionTextBox.TextChanged += new System.EventHandler(this.searchConditionTextBox_TextChanged);
            this.searchConditionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchConditionTextBox_KeyPress);
            // 
            // IsVisible
            // 
            this.IsVisible.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.IsVisible.HeaderText = "Show/Hide";
            this.IsVisible.MinimumWidth = 90;
            this.IsVisible.Name = "IsVisible";
            this.IsVisible.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsVisible.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsVisible.ToolTipText = "This checkbox enables this condition to show or hide the session in the sessions " +
    "window.";
            this.IsVisible.Width = 122;
            // 
            // FilterConditionType
            // 
            this.FilterConditionType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FilterConditionType.HeaderText = "Type";
            this.FilterConditionType.Items.AddRange(new object[] {
            "EXACT",
            "REGEX",
            "CONTAINS"});
            this.FilterConditionType.Name = "FilterConditionType";
            this.FilterConditionType.Width = 54;
            // 
            // FilterPredicate
            // 
            this.FilterCondition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FilterCondition.HeaderText = "Filter condition";
            this.FilterCondition.Name = "FilterPredicate";
            // 
            // QueryStringGridFilterUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.singleFilterGroup);
            this.Name = "QueryStringGridFilterUserControl";
            this.Size = new System.Drawing.Size(1081, 339);
            this.singleFilterGroup.ResumeLayout(false);
            this.singleFilterGroup.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchConditionDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox singleFilterGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        protected System.Windows.Forms.DataGridView searchConditionDataGrid;
        private System.Windows.Forms.TextBox searchConditionTextBox;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsVisible;
        private System.Windows.Forms.DataGridViewComboBoxColumn FilterConditionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilterCondition;
    }
}
