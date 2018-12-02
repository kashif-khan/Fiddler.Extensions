using System.Windows.Forms;

namespace Fiddler.Extensions
{
    partial class SearchFiltersContainerUserControl : UserControl
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
            this.FilterUseTableLayout.AutoSize = true;
            this.FilterUseTableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FilterUseTableLayout.ColumnCount = 1;
            this.FilterUseTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilterUseTableLayout.Controls.Add(this.FilterSearchAndEnableTableLayout, 0, 0);
            this.FilterUseTableLayout.Controls.Add(this.FiltersTableLayout, 0, 1);
            this.FilterUseTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilterUseTableLayout.Location = new System.Drawing.Point(0, 0);
            this.FilterUseTableLayout.Name = "FilterUseTableLayout";
            this.FilterUseTableLayout.RowCount = 2;
            this.FilterUseTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FilterUseTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FilterUseTableLayout.Size = new System.Drawing.Size(653, 44);
            this.FilterUseTableLayout.TabIndex = 0;
            // 
            // FilterSearchAndEnableTableLayout
            // 
            this.FilterSearchAndEnableTableLayout.AutoSize = true;
            this.FilterSearchAndEnableTableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FilterSearchAndEnableTableLayout.BackColor = System.Drawing.SystemColors.Control;
            this.FilterSearchAndEnableTableLayout.ColumnCount = 2;
            this.FilterSearchAndEnableTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilterSearchAndEnableTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilterSearchAndEnableTableLayout.Controls.Add(this.EnableFilterCheckbox, 0, 0);
            this.FilterSearchAndEnableTableLayout.Controls.Add(this.SearchFiltersTextBox, 1, 0);
            this.FilterSearchAndEnableTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilterSearchAndEnableTableLayout.Location = new System.Drawing.Point(3, 3);
            this.FilterSearchAndEnableTableLayout.Name = "FilterSearchAndEnableTableLayout";
            this.FilterSearchAndEnableTableLayout.RowCount = 1;
            this.FilterSearchAndEnableTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FilterSearchAndEnableTableLayout.Size = new System.Drawing.Size(647, 32);
            this.FilterSearchAndEnableTableLayout.TabIndex = 0;
            // 
            // EnableFilterCheckbox
            // 
            this.EnableFilterCheckbox.AutoSize = true;
            this.EnableFilterCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnableFilterCheckbox.Location = new System.Drawing.Point(3, 3);
            this.EnableFilterCheckbox.Name = "EnableFilterCheckbox";
            this.EnableFilterCheckbox.Size = new System.Drawing.Size(111, 26);
            this.EnableFilterCheckbox.TabIndex = 0;
            this.EnableFilterCheckbox.Text = "Use Filters";
            this.EnableFilterCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EnableFilterCheckbox.UseVisualStyleBackColor = true;
            this.EnableFilterCheckbox.CheckedChanged += new System.EventHandler(this.EnableFilterCheckbox_CheckedChanged);
            // 
            // SearchFiltersTextBox
            // 
            this.SearchFiltersTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchFiltersTextBox.Location = new System.Drawing.Point(120, 3);
            this.SearchFiltersTextBox.Name = "SearchFiltersTextBox";
            this.SearchFiltersTextBox.Size = new System.Drawing.Size(524, 26);
            this.SearchFiltersTextBox.TabIndex = 1;
            this.SearchFiltersTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchFiltersTextBox_KeyUp);
            // 
            // FiltersTableLayout
            // 
            this.FiltersTableLayout.AutoSize = true;
            this.FiltersTableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FiltersTableLayout.ColumnCount = 1;
            this.FiltersTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FiltersTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiltersTableLayout.Location = new System.Drawing.Point(3, 41);
            this.FiltersTableLayout.Name = "FiltersTableLayout";
            this.FiltersTableLayout.RowCount = 1;
            this.FiltersTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FiltersTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.FiltersTableLayout.Size = new System.Drawing.Size(647, 1);
            this.FiltersTableLayout.TabIndex = 1;
            // 
            // SearchFiltersContainerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.FilterUseTableLayout);
            this.Name = "SearchFiltersContainerUserControl";
            this.Size = new System.Drawing.Size(653, 44);
            this.FilterUseTableLayout.ResumeLayout(false);
            this.FilterUseTableLayout.PerformLayout();
            this.FilterSearchAndEnableTableLayout.ResumeLayout(false);
            this.FilterSearchAndEnableTableLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel FilterUseTableLayout;
        private System.Windows.Forms.TableLayoutPanel FilterSearchAndEnableTableLayout;
        private System.Windows.Forms.CheckBox EnableFilterCheckbox;
        private System.Windows.Forms.TextBox SearchFiltersTextBox;
        private System.Windows.Forms.TableLayoutPanel FiltersTableLayout;
    }
}
