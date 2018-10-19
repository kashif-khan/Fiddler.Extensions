namespace Fiddler.Extensions
{
    partial class SearchableFilter
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
            this.singleFilterGroup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SearchConditionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.AddSearchConditionButton = new System.Windows.Forms.Button();
            this.SearchConditionsListBox = new System.Windows.Forms.ListBox();
            this.RemoveSearchConditionButton = new System.Windows.Forms.Button();
            this.singleFilterGroup.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // singleFilterGroup
            // 
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
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.23256F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.76744F));
            this.tableLayoutPanel1.Controls.Add(this.SearchConditionRichTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AddSearchConditionButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.SearchConditionsListBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.RemoveSearchConditionButton, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.87898F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.12102F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1075, 314);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SearchConditionRichTextBox
            // 
            this.SearchConditionRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchConditionRichTextBox.Location = new System.Drawing.Point(3, 3);
            this.SearchConditionRichTextBox.Name = "SearchConditionRichTextBox";
            this.SearchConditionRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.SearchConditionRichTextBox.Size = new System.Drawing.Size(878, 46);
            this.SearchConditionRichTextBox.TabIndex = 0;
            this.SearchConditionRichTextBox.Text = "";
            // 
            // AddSearchConditionButton
            // 
            this.AddSearchConditionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddSearchConditionButton.Location = new System.Drawing.Point(887, 3);
            this.AddSearchConditionButton.Name = "AddSearchConditionButton";
            this.AddSearchConditionButton.Size = new System.Drawing.Size(185, 46);
            this.AddSearchConditionButton.TabIndex = 1;
            this.AddSearchConditionButton.Text = "Add";
            this.AddSearchConditionButton.UseVisualStyleBackColor = true;
            this.AddSearchConditionButton.Click += new System.EventHandler(this.AddSearchConditionButton_Click);
            // 
            // SearchConditionsListBox
            // 
            this.SearchConditionsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchConditionsListBox.FormattingEnabled = true;
            this.SearchConditionsListBox.ItemHeight = 20;
            this.SearchConditionsListBox.Location = new System.Drawing.Point(3, 55);
            this.SearchConditionsListBox.Name = "SearchConditionsListBox";
            this.SearchConditionsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.SearchConditionsListBox.Size = new System.Drawing.Size(878, 256);
            this.SearchConditionsListBox.TabIndex = 2;
            // 
            // RemoveSearchConditionButton
            // 
            this.RemoveSearchConditionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveSearchConditionButton.Location = new System.Drawing.Point(887, 55);
            this.RemoveSearchConditionButton.Name = "RemoveSearchConditionButton";
            this.RemoveSearchConditionButton.Size = new System.Drawing.Size(185, 256);
            this.RemoveSearchConditionButton.TabIndex = 3;
            this.RemoveSearchConditionButton.Text = "Remove";
            this.RemoveSearchConditionButton.UseVisualStyleBackColor = true;
            this.RemoveSearchConditionButton.Click += new System.EventHandler(this.RemoveSearchConditionButton_Click);
            // 
            // SearchableFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.singleFilterGroup);
            this.Name = "SearchableFilter";
            this.Size = new System.Drawing.Size(1081, 339);
            this.singleFilterGroup.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox singleFilterGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox SearchConditionRichTextBox;
        private System.Windows.Forms.Button AddSearchConditionButton;
        private System.Windows.Forms.ListBox SearchConditionsListBox;
        private System.Windows.Forms.Button RemoveSearchConditionButton;
    }
}
