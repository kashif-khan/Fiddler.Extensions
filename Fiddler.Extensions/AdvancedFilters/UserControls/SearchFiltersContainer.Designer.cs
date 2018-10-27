namespace Fiddler.Extensions
{
    partial class SearchFiltersContainer
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
            this.FilterUseTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.FilterSearchAndEnableTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.EnableFilterCheckbox = new System.Windows.Forms.CheckBox();
            this.SearchFiltersTextBox = new System.Windows.Forms.TextBox();
            this.FiltersTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.FilterUseTableLayout.SuspendLayout();
            this.FilterSearchAndEnableTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilterUseTableLayout
            // 
            this.FilterUseTableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FilterUseTableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.FilterUseTableLayout.ColumnCount = 1;
            this.FilterUseTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilterUseTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.FilterUseTableLayout.Controls.Add(this.FilterSearchAndEnableTableLayout, 0, 0);
            this.FilterUseTableLayout.Controls.Add(this.FiltersTableLayout, 0, 1);
            this.FilterUseTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilterUseTableLayout.Location = new System.Drawing.Point(0, 0);
            this.FilterUseTableLayout.Name = "FilterUseTableLayout";
            this.FilterUseTableLayout.RowCount = 2;
            this.FilterUseTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.813084F));
            this.FilterUseTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.18691F));
            this.FilterUseTableLayout.Size = new System.Drawing.Size(653, 428);
            this.FilterUseTableLayout.TabIndex = 0;
            // 
            // FilterSearchAndEnableTableLayout
            // 
            this.FilterSearchAndEnableTableLayout.AutoSize = true;
            this.FilterSearchAndEnableTableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FilterSearchAndEnableTableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.FilterSearchAndEnableTableLayout.ColumnCount = 2;
            this.FilterSearchAndEnableTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilterSearchAndEnableTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilterSearchAndEnableTableLayout.Controls.Add(this.EnableFilterCheckbox, 0, 0);
            this.FilterSearchAndEnableTableLayout.Controls.Add(this.SearchFiltersTextBox, 1, 0);
            this.FilterSearchAndEnableTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilterSearchAndEnableTableLayout.Location = new System.Drawing.Point(4, 4);
            this.FilterSearchAndEnableTableLayout.Name = "FilterSearchAndEnableTableLayout";
            this.FilterSearchAndEnableTableLayout.RowCount = 1;
            this.FilterSearchAndEnableTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FilterSearchAndEnableTableLayout.Size = new System.Drawing.Size(650, 35);
            this.FilterSearchAndEnableTableLayout.TabIndex = 0;
            // 
            // EnableFilterCheckbox
            // 
            this.EnableFilterCheckbox.AutoSize = true;
            this.EnableFilterCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnableFilterCheckbox.Location = new System.Drawing.Point(4, 4);
            this.EnableFilterCheckbox.Name = "EnableFilterCheckbox";
            this.EnableFilterCheckbox.Size = new System.Drawing.Size(111, 27);
            this.EnableFilterCheckbox.TabIndex = 0;
            this.EnableFilterCheckbox.Text = "Use Filters";
            this.EnableFilterCheckbox.UseVisualStyleBackColor = true;
            this.EnableFilterCheckbox.CheckedChanged += new System.EventHandler(this.EnableFilterCheckbox_CheckedChanged);
            // 
            // SearchFiltersTextBox
            // 
            this.SearchFiltersTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchFiltersTextBox.Location = new System.Drawing.Point(122, 4);
            this.SearchFiltersTextBox.Name = "SearchFiltersTextBox";
            this.SearchFiltersTextBox.Size = new System.Drawing.Size(524, 26);
            this.SearchFiltersTextBox.TabIndex = 1;
            this.SearchFiltersTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchFiltersTextBox_KeyPress);
            // 
            // FiltersTableLayout
            // 
            this.FiltersTableLayout.AutoSize = true;
            this.FiltersTableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FiltersTableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.FiltersTableLayout.ColumnCount = 1;
            this.FiltersTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FiltersTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiltersTableLayout.Location = new System.Drawing.Point(4, 46);
            this.FiltersTableLayout.Name = "FiltersTableLayout";
            this.FiltersTableLayout.RowCount = 1;
            this.FiltersTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FiltersTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 377F));
            this.FiltersTableLayout.Size = new System.Drawing.Size(650, 378);
            this.FiltersTableLayout.TabIndex = 1;
            // 
            // SearchFilters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FilterUseTableLayout);
            this.Name = "SearchFilters";
            this.Size = new System.Drawing.Size(653, 428);
            this.FilterUseTableLayout.ResumeLayout(false);
            this.FilterUseTableLayout.PerformLayout();
            this.FilterSearchAndEnableTableLayout.ResumeLayout(false);
            this.FilterSearchAndEnableTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel FilterUseTableLayout;
        private System.Windows.Forms.TableLayoutPanel FilterSearchAndEnableTableLayout;
        private System.Windows.Forms.CheckBox EnableFilterCheckbox;
        private System.Windows.Forms.TextBox SearchFiltersTextBox;
        private System.Windows.Forms.TableLayoutPanel FiltersTableLayout;
    }
}
