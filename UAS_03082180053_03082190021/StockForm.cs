using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS_03082180053_03082190021
{
    public partial class StockForm : Form
    {
        Stock stock;
        ListViewItem selectedProduct;
        List<List<String>> data = new List<List<String>>();
        public StockForm()
        {
            InitializeComponent();
            stock = new Stock();            
            setItemListView();
        }
        public void addItem()
        {
            Boolean flag = true;
            List<String> form = new List<String>();
            if(productNameTB.Text == "")
            {
                flag = false;
            }
            form.Add(productNameTB.Text);
            form.Add(productQtyNumeric.Value.ToString());
            form.Add(productPriceNumeric.Value.ToString());
            if (flag)
            {
                stock.addStock(form);
                setItemListView();
            }

            
        }
        private void setItemListView()
        {            
            data = stock.getStock();
            stockListView.Items.Clear();
            foreach (List<String> rows in data)
            {
                ListViewItem row = new ListViewItem();                
                foreach (String item in rows)
                {                                        
                    row.SubItems.Add(item);
                }
                row.SubItems.RemoveAt(0);
                stockListView.Items.Add(row);
            }
            
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            addItem();
            clearInput();
        }

        private void stockListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (stockListView.FocusedItem.Bounds.Contains(e.Location))
                {
                    stockMenuStrip.Show(Cursor.Position);
                    int itemIndex = stockListView.FocusedItem.Index;
                    selectedProduct = stockListView.Items[itemIndex];

                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveProductBtn.Enabled = true;
            addProductBtn.Enabled = false;
            productNameTB.Text = selectedProduct.SubItems[1].Text;
            productQtyNumeric.Value = int.Parse(selectedProduct.SubItems[2].Text);
            productPriceNumeric.Value = int.Parse(selectedProduct.SubItems[3].Text);
        }

        private void saveProductBtn_Click(object sender, EventArgs e)
        {
            List<String> form = new List<String>();
            form.Add(productNameTB.Text);
            form.Add(productQtyNumeric.Value.ToString());
            form.Add(productPriceNumeric.Value.ToString());
            stock.updateStock(form, selectedProduct.SubItems[0].Text);
            saveProductBtn.Enabled = false;
            addProductBtn.Enabled = true;
            setItemListView();
            clearInput();
        }

        private void clearInput()
        {
            productNameTB.Text = "";
            productQtyNumeric.Value = 0;
            productPriceNumeric.Value = 0;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stock.deleteStock(selectedProduct.SubItems[0].Text);
            setItemListView();
        }
    }
}
