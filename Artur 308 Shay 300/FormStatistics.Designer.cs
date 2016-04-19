namespace Artur_308_Shay_300
{
    public partial class FormStatistics
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
            this.checkedListAlbumsStatistics = new System.Windows.Forms.CheckedListBox();
            this.checkedListEventsStatistics = new System.Windows.Forms.CheckedListBox();
            this.checkedListPostsStatistics = new System.Windows.Forms.CheckedListBox();
            this.buttonStatistics = new System.Windows.Forms.Button();
            this.tabUserStatistics = new System.Windows.Forms.TabControl();
            this.tabPostsStatistics = new System.Windows.Forms.TabPage();
            this.tabEventsStatistics = new System.Windows.Forms.TabPage();
            this.tabAlbumsStatistics = new System.Windows.Forms.TabPage();
            this.progressBarStatistics = new System.Windows.Forms.ProgressBar();
            this.tabUserStatistics.SuspendLayout();
            this.tabPostsStatistics.SuspendLayout();
            this.tabEventsStatistics.SuspendLayout();
            this.tabAlbumsStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListAlbumsStatistics
            // 
            this.checkedListAlbumsStatistics.CheckOnClick = true;
            this.checkedListAlbumsStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkedListAlbumsStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkedListAlbumsStatistics.FormattingEnabled = true;
            this.checkedListAlbumsStatistics.Items.AddRange(new object[] {
            "Number Of Albums",
            "Number Of Albums Liked By Other Pages",
            "Number Of Photos",
            "Number Of Liked Photos"});
            this.checkedListAlbumsStatistics.Location = new System.Drawing.Point(4, 4);
            this.checkedListAlbumsStatistics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListAlbumsStatistics.Name = "checkedListAlbumsStatistics";
            this.checkedListAlbumsStatistics.Size = new System.Drawing.Size(403, 106);
            this.checkedListAlbumsStatistics.TabIndex = 1;
            // 
            // checkedListEventsStatistics
            // 
            this.checkedListEventsStatistics.CheckOnClick = true;
            this.checkedListEventsStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkedListEventsStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkedListEventsStatistics.FormattingEnabled = true;
            this.checkedListEventsStatistics.Items.AddRange(new object[] {
            "Number Of Attending Users In Your Events",
            "Number Of Events Declining Users In Your Events",
            "Number Of Events Maybe Attending Users In Your Events",
            "Number Of Not Yet Replied Users In Your Events",
            "Number Of Events"});
            this.checkedListEventsStatistics.Location = new System.Drawing.Point(4, 4);
            this.checkedListEventsStatistics.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListEventsStatistics.Name = "checkedListEventsStatistics";
            this.checkedListEventsStatistics.Size = new System.Drawing.Size(403, 106);
            this.checkedListEventsStatistics.TabIndex = 4;
            // 
            // checkedListPostsStatistics
            // 
            this.checkedListPostsStatistics.CheckOnClick = true;
            this.checkedListPostsStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkedListPostsStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkedListPostsStatistics.FormattingEnabled = true;
            this.checkedListPostsStatistics.Items.AddRange(new object[] {
            "Number Of Posts",
            "Number Of Liked Posts"});
            this.checkedListPostsStatistics.Location = new System.Drawing.Point(4, 4);
            this.checkedListPostsStatistics.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListPostsStatistics.Name = "checkedListPostsStatistics";
            this.checkedListPostsStatistics.Size = new System.Drawing.Size(403, 106);
            this.checkedListPostsStatistics.TabIndex = 8;
            // 
            // buttonStatistics
            // 
            this.buttonStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(95)))), ((int)(((byte)(156)))));
            this.buttonStatistics.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(95)))), ((int)(((byte)(156)))));
            this.buttonStatistics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatistics.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonStatistics.ForeColor = System.Drawing.Color.Snow;
            this.buttonStatistics.Location = new System.Drawing.Point(1, 182);
            this.buttonStatistics.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.Size = new System.Drawing.Size(419, 33);
            this.buttonStatistics.TabIndex = 28;
            this.buttonStatistics.Text = "Statistics";
            this.buttonStatistics.UseVisualStyleBackColor = false;
            this.buttonStatistics.Click += new System.EventHandler(this.buttonStatistics_Click);
            // 
            // tabUserStatistics
            // 
            this.tabUserStatistics.Controls.Add(this.tabPostsStatistics);
            this.tabUserStatistics.Controls.Add(this.tabEventsStatistics);
            this.tabUserStatistics.Controls.Add(this.tabAlbumsStatistics);
            this.tabUserStatistics.Location = new System.Drawing.Point(1, 4);
            this.tabUserStatistics.Margin = new System.Windows.Forms.Padding(4);
            this.tabUserStatistics.Name = "tabUserStatistics";
            this.tabUserStatistics.SelectedIndex = 0;
            this.tabUserStatistics.Size = new System.Drawing.Size(419, 145);
            this.tabUserStatistics.TabIndex = 30;
            // 
            // tabPostsStatistics
            // 
            this.tabPostsStatistics.Controls.Add(this.checkedListPostsStatistics);
            this.tabPostsStatistics.Location = new System.Drawing.Point(4, 25);
            this.tabPostsStatistics.Margin = new System.Windows.Forms.Padding(4);
            this.tabPostsStatistics.Name = "tabPostsStatistics";
            this.tabPostsStatistics.Padding = new System.Windows.Forms.Padding(4);
            this.tabPostsStatistics.Size = new System.Drawing.Size(411, 116);
            this.tabPostsStatistics.TabIndex = 0;
            this.tabPostsStatistics.Text = "Posts Statistics:";
            this.tabPostsStatistics.UseVisualStyleBackColor = true;
            // 
            // tabEventsStatistics
            // 
            this.tabEventsStatistics.Controls.Add(this.checkedListEventsStatistics);
            this.tabEventsStatistics.Location = new System.Drawing.Point(4, 25);
            this.tabEventsStatistics.Margin = new System.Windows.Forms.Padding(4);
            this.tabEventsStatistics.Name = "tabEventsStatistics";
            this.tabEventsStatistics.Padding = new System.Windows.Forms.Padding(4);
            this.tabEventsStatistics.Size = new System.Drawing.Size(411, 116);
            this.tabEventsStatistics.TabIndex = 2;
            this.tabEventsStatistics.Text = "Events Statistics:";
            this.tabEventsStatistics.UseVisualStyleBackColor = true;
            // 
            // tabAlbumsStatistics
            // 
            this.tabAlbumsStatistics.Controls.Add(this.checkedListAlbumsStatistics);
            this.tabAlbumsStatistics.Location = new System.Drawing.Point(4, 25);
            this.tabAlbumsStatistics.Margin = new System.Windows.Forms.Padding(4);
            this.tabAlbumsStatistics.Name = "tabAlbumsStatistics";
            this.tabAlbumsStatistics.Padding = new System.Windows.Forms.Padding(4);
            this.tabAlbumsStatistics.Size = new System.Drawing.Size(411, 116);
            this.tabAlbumsStatistics.TabIndex = 3;
            this.tabAlbumsStatistics.Text = "Albums Statistics:";
            this.tabAlbumsStatistics.UseVisualStyleBackColor = true;
            // 
            // progressBarStatistics
            // 
            this.progressBarStatistics.AccessibleName = string.Empty;
            this.progressBarStatistics.Location = new System.Drawing.Point(1, 152);
            this.progressBarStatistics.Maximum = 3;
            this.progressBarStatistics.Name = "progressBarStatistics";
            this.progressBarStatistics.Size = new System.Drawing.Size(419, 23);
            this.progressBarStatistics.TabIndex = 31;
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(424, 215);
            this.Controls.Add(this.progressBarStatistics);
            this.Controls.Add(this.tabUserStatistics);
            this.Controls.Add(this.buttonStatistics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormStatistics";
            this.tabUserStatistics.ResumeLayout(false);
            this.tabPostsStatistics.ResumeLayout(false);
            this.tabEventsStatistics.ResumeLayout(false);
            this.tabAlbumsStatistics.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListAlbumsStatistics;
        private System.Windows.Forms.CheckedListBox checkedListEventsStatistics;
        private System.Windows.Forms.CheckedListBox checkedListPostsStatistics;
        private System.Windows.Forms.Button buttonStatistics;
        private System.Windows.Forms.TabControl tabUserStatistics;
        private System.Windows.Forms.TabPage tabPostsStatistics;
        private System.Windows.Forms.TabPage tabEventsStatistics;
        private System.Windows.Forms.TabPage tabAlbumsStatistics;
        private System.Windows.Forms.ProgressBar progressBarStatistics;
    }
}