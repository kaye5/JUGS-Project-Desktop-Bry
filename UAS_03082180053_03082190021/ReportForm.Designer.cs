namespace UAS_03082180053_03082190021
{
    partial class ReportForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.todaySummaryListView = new System.Windows.Forms.ListView();
            this.AllListView = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totalOrderTodayTB = new System.Windows.Forms.TextBox();
            this.totalIncomeTodayTB = new System.Windows.Forms.TextBox();
            this.todayBestTB = new System.Windows.Forms.TextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.allBestTB = new System.Windows.Forms.TextBox();
            this.allTotalIncomeTB = new System.Windows.Forms.TextBox();
            this.allTotalOrderTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Order Today";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Income Today";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Today Best Seller";
            // 
            // todaySummaryListView
            // 
            this.todaySummaryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.todaySummaryListView.HideSelection = false;
            this.todaySummaryListView.Location = new System.Drawing.Point(16, 176);
            this.todaySummaryListView.Name = "todaySummaryListView";
            this.todaySummaryListView.Size = new System.Drawing.Size(364, 308);
            this.todaySummaryListView.TabIndex = 3;
            this.todaySummaryListView.UseCompatibleStateImageBehavior = false;
            this.todaySummaryListView.View = System.Windows.Forms.View.Details;
            // 
            // AllListView
            // 
            this.AllListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.AllListView.HideSelection = false;
            this.AllListView.Location = new System.Drawing.Point(384, 176);
            this.AllListView.Name = "AllListView";
            this.AllListView.Size = new System.Drawing.Size(364, 308);
            this.AllListView.TabIndex = 4;
            this.AllListView.UseCompatibleStateImageBehavior = false;
            this.AllListView.View = System.Windows.Forms.View.Details;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Today Summary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "All Time Summary";
            // 
            // totalOrderTodayTB
            // 
            this.totalOrderTodayTB.Enabled = false;
            this.totalOrderTodayTB.Location = new System.Drawing.Point(141, 21);
            this.totalOrderTodayTB.Name = "totalOrderTodayTB";
            this.totalOrderTodayTB.Size = new System.Drawing.Size(219, 20);
            this.totalOrderTodayTB.TabIndex = 7;
            // 
            // totalIncomeTodayTB
            // 
            this.totalIncomeTodayTB.Enabled = false;
            this.totalIncomeTodayTB.Location = new System.Drawing.Point(141, 64);
            this.totalIncomeTodayTB.Name = "totalIncomeTodayTB";
            this.totalIncomeTodayTB.Size = new System.Drawing.Size(219, 20);
            this.totalIncomeTodayTB.TabIndex = 8;
            // 
            // todayBestTB
            // 
            this.todayBestTB.Enabled = false;
            this.todayBestTB.Location = new System.Drawing.Point(141, 108);
            this.todayBestTB.Name = "todayBestTB";
            this.todayBestTB.Size = new System.Drawing.Size(219, 20);
            this.todayBestTB.TabIndex = 9;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product Name";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Total";
            this.columnHeader2.Width = 116;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Product Name";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            // 
            // allBestTB
            // 
            this.allBestTB.Enabled = false;
            this.allBestTB.Location = new System.Drawing.Point(529, 111);
            this.allBestTB.Name = "allBestTB";
            this.allBestTB.Size = new System.Drawing.Size(219, 20);
            this.allBestTB.TabIndex = 12;
            // 
            // allTotalIncomeTB
            // 
            this.allTotalIncomeTB.Enabled = false;
            this.allTotalIncomeTB.Location = new System.Drawing.Point(529, 67);
            this.allTotalIncomeTB.Name = "allTotalIncomeTB";
            this.allTotalIncomeTB.Size = new System.Drawing.Size(219, 20);
            this.allTotalIncomeTB.TabIndex = 11;
            // 
            // allTotalOrderTB
            // 
            this.allTotalOrderTB.Enabled = false;
            this.allTotalOrderTB.Location = new System.Drawing.Point(529, 24);
            this.allTotalOrderTB.Name = "allTotalOrderTB";
            this.allTotalOrderTB.Size = new System.Drawing.Size(219, 20);
            this.allTotalOrderTB.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Best Seller";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(411, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total Income";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(411, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Total Order";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 496);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.allBestTB);
            this.Controls.Add(this.allTotalIncomeTB);
            this.Controls.Add(this.allTotalOrderTB);
            this.Controls.Add(this.todayBestTB);
            this.Controls.Add(this.totalIncomeTodayTB);
            this.Controls.Add(this.totalOrderTodayTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AllListView);
            this.Controls.Add(this.todaySummaryListView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView todaySummaryListView;
        private System.Windows.Forms.ListView AllListView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totalOrderTodayTB;
        private System.Windows.Forms.TextBox totalIncomeTodayTB;
        private System.Windows.Forms.TextBox todayBestTB;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox allBestTB;
        private System.Windows.Forms.TextBox allTotalIncomeTB;
        private System.Windows.Forms.TextBox allTotalOrderTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}