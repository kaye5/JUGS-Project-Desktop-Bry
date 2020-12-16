namespace UAS_03082180053_03082190021
{
    partial class StockForm
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
            this.productNameTB = new System.Windows.Forms.TextBox();
            this.stockFormPanel = new System.Windows.Forms.Panel();
            this.productQtyNumeric = new System.Windows.Forms.NumericUpDown();
            this.productPriceNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.saveProductBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stockMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.product_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.product_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stockListView = new System.Windows.Forms.ListView();
            this.stockFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productQtyNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPriceNumeric)).BeginInit();
            this.stockMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // productNameTB
            // 
            this.productNameTB.Location = new System.Drawing.Point(111, 22);
            this.productNameTB.Name = "productNameTB";
            this.productNameTB.Size = new System.Drawing.Size(180, 20);
            this.productNameTB.TabIndex = 1;
            // 
            // stockFormPanel
            // 
            this.stockFormPanel.Controls.Add(this.productQtyNumeric);
            this.stockFormPanel.Controls.Add(this.productPriceNumeric);
            this.stockFormPanel.Controls.Add(this.label3);
            this.stockFormPanel.Controls.Add(this.addProductBtn);
            this.stockFormPanel.Controls.Add(this.saveProductBtn);
            this.stockFormPanel.Controls.Add(this.label2);
            this.stockFormPanel.Controls.Add(this.label1);
            this.stockFormPanel.Controls.Add(this.productNameTB);
            this.stockFormPanel.Location = new System.Drawing.Point(12, 256);
            this.stockFormPanel.Name = "stockFormPanel";
            this.stockFormPanel.Size = new System.Drawing.Size(294, 182);
            this.stockFormPanel.TabIndex = 4;
            // 
            // productQtyNumeric
            // 
            this.productQtyNumeric.Location = new System.Drawing.Point(111, 48);
            this.productQtyNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.productQtyNumeric.Name = "productQtyNumeric";
            this.productQtyNumeric.Size = new System.Drawing.Size(180, 20);
            this.productQtyNumeric.TabIndex = 10;
            // 
            // productPriceNumeric
            // 
            this.productPriceNumeric.Location = new System.Drawing.Point(111, 77);
            this.productPriceNumeric.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.productPriceNumeric.Name = "productPriceNumeric";
            this.productPriceNumeric.Size = new System.Drawing.Size(180, 20);
            this.productPriceNumeric.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Price";
            // 
            // addProductBtn
            // 
            this.addProductBtn.Location = new System.Drawing.Point(197, 134);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(94, 35);
            this.addProductBtn.TabIndex = 7;
            this.addProductBtn.Text = "Add";
            this.addProductBtn.UseVisualStyleBackColor = true;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // saveProductBtn
            // 
            this.saveProductBtn.Enabled = false;
            this.saveProductBtn.Location = new System.Drawing.Point(6, 134);
            this.saveProductBtn.Name = "saveProductBtn";
            this.saveProductBtn.Size = new System.Drawing.Size(94, 35);
            this.saveProductBtn.TabIndex = 6;
            this.saveProductBtn.Text = "Save";
            this.saveProductBtn.UseVisualStyleBackColor = true;
            this.saveProductBtn.Click += new System.EventHandler(this.saveProductBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Product Qty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Product Name";
            // 
            // stockMenuStrip
            // 
            this.stockMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.stockMenuStrip.Name = "stockMenuStrip";
            this.stockMenuStrip.Size = new System.Drawing.Size(108, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // productid
            // 
            this.productid.Text = "Product ID";
            // 
            // product_name
            // 
            this.product_name.Text = "Product Name";
            // 
            // product_price
            // 
            this.product_price.Text = "Price";
            // 
            // qty
            // 
            this.qty.Text = "Qty";
            // 
            // stockListView
            // 
            this.stockListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productid,
            this.product_name,
            this.qty,
            this.product_price});
            this.stockListView.Dock = System.Windows.Forms.DockStyle.Top;
            this.stockListView.FullRowSelect = true;
            this.stockListView.GridLines = true;
            this.stockListView.HideSelection = false;
            this.stockListView.Location = new System.Drawing.Point(0, 0);
            this.stockListView.Name = "stockListView";
            this.stockListView.Size = new System.Drawing.Size(776, 237);
            this.stockListView.TabIndex = 0;
            this.stockListView.UseCompatibleStateImageBehavior = false;
            this.stockListView.View = System.Windows.Forms.View.Details;
            this.stockListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.stockListView_MouseClick);
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 535);
            this.Controls.Add(this.stockFormPanel);
            this.Controls.Add(this.stockListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockForm";
            this.Text = "Stock";
            this.stockFormPanel.ResumeLayout(false);
            this.stockFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productQtyNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPriceNumeric)).EndInit();
            this.stockMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox productNameTB;
        private System.Windows.Forms.Panel stockFormPanel;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.Button saveProductBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown productPriceNumeric;
        private System.Windows.Forms.NumericUpDown productQtyNumeric;
        private System.Windows.Forms.ContextMenuStrip stockMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        
        private System.Windows.Forms.ColumnHeader productid;
        private System.Windows.Forms.ColumnHeader product_name;
        private System.Windows.Forms.ColumnHeader product_price;
        private System.Windows.Forms.ColumnHeader qty;
        private System.Windows.Forms.ListView stockListView;
    }
}