﻿namespace Fiddler.Extensions
{
    partial class AddOrRemoveFilters
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
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.singleFilterGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.singleFilterGroup.Location = new System.Drawing.Point(0, 0);
            this.singleFilterGroup.Name = "groupBox1";
            this.singleFilterGroup.Size = new System.Drawing.Size(150, 150);
            this.singleFilterGroup.TabIndex = 0;
            this.singleFilterGroup.TabStop = false;
            this.singleFilterGroup.Text = "groupBox1";
            // 
            // AddOrRemoveFilters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.singleFilterGroup);
            this.Name = "AddOrRemoveFilters";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox singleFilterGroup;
    }
}
