namespace PSTforms
{
    partial class MainForm
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
            this.btnChangeCountry = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCountry = new System.Windows.Forms.Label();
            this.btnHeadlines = new System.Windows.Forms.Button();
            this.btnSources = new System.Windows.Forms.Button();
            this.lBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSelectSource = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnChangeCountry
            // 
            this.btnChangeCountry.Location = new System.Drawing.Point(545, 51);
            this.btnChangeCountry.Name = "btnChangeCountry";
            this.btnChangeCountry.Size = new System.Drawing.Size(113, 23);
            this.btnChangeCountry.TabIndex = 1;
            this.btnChangeCountry.Text = "Change Country";
            this.btnChangeCountry.UseVisualStyleBackColor = true;
            this.btnChangeCountry.Click += new System.EventHandler(this.btnChangeCountry_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(12, 25);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(318, 20);
            this.tbSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(238, 51);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Give me news";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(542, 25);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(35, 13);
            this.lblCountry.TabIndex = 5;
            this.lblCountry.Text = "label2";
            // 
            // btnHeadlines
            // 
            this.btnHeadlines.Location = new System.Drawing.Point(149, 51);
            this.btnHeadlines.Name = "btnHeadlines";
            this.btnHeadlines.Size = new System.Drawing.Size(83, 23);
            this.btnHeadlines.TabIndex = 7;
            this.btnHeadlines.Text = "Top headlines";
            this.btnHeadlines.UseVisualStyleBackColor = true;
            this.btnHeadlines.Click += new System.EventHandler(this.btnHeadlines_Click);
            // 
            // btnSources
            // 
            this.btnSources.Location = new System.Drawing.Point(336, 23);
            this.btnSources.Name = "btnSources";
            this.btnSources.Size = new System.Drawing.Size(117, 23);
            this.btnSources.TabIndex = 8;
            this.btnSources.Text = "Sources";
            this.btnSources.UseVisualStyleBackColor = true;
            this.btnSources.Click += new System.EventHandler(this.btnSources_Click);
            // 
            // lBox
            // 
            this.lBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lBox.FormattingEnabled = true;
            this.lBox.ItemHeight = 15;
            this.lBox.Location = new System.Drawing.Point(12, 101);
            this.lBox.Name = "lBox";
            this.lBox.Size = new System.Drawing.Size(646, 210);
            this.lBox.TabIndex = 9;
            this.lBox.DoubleClick += new System.EventHandler(this.DoubleClickListItem);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Double click item to view more info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Enter search term, or get top headlines";
            // 
            // cmbSelectSource
            // 
            this.cmbSelectSource.FormattingEnabled = true;
            this.cmbSelectSource.Location = new System.Drawing.Point(336, 53);
            this.cmbSelectSource.Name = "cmbSelectSource";
            this.cmbSelectSource.Size = new System.Drawing.Size(117, 21);
            this.cmbSelectSource.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 326);
            this.Controls.Add(this.cmbSelectSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lBox);
            this.Controls.Add(this.btnSources);
            this.Controls.Add(this.btnHeadlines);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnChangeCountry);
            this.Name = "MainForm";
            this.Text = "Give me News";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnChangeCountry;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Button btnHeadlines;
        private System.Windows.Forms.Button btnSources;
        private System.Windows.Forms.ListBox lBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSelectSource;
    }
}

