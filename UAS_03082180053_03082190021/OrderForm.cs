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
    public partial class OrderForm : Form
    {
        Order order = new Order();
        
        public OrderForm()
        {
            InitializeComponent();
            setOrderListView();
        }

        private void setOrderListView()
        {
            List<List<String>> data = order.getOrder();
            foreach (List<String> rows in data)
            {
                ListViewItem item = new ListViewItem();
                foreach (String row in rows)
                {
                    item.SubItems.Add(row);                                        
                }
                item.SubItems.RemoveAt(0);
                myOrderListView.Items.Add(item);
            }
        }

        private void setOrderDetailListView(String orderid)
        {
            List<List<String>> data = order.getOrderDetail(orderid);
            int sum = 0;
            orderDetailListView.Items.Clear();
            foreach (var rows in data)
            {
                ListViewItem item = new ListViewItem();
                foreach (var row in rows)
                {
                    item.SubItems.Add(row);                    
                }
                int total = int.Parse(rows[1]) * int.Parse(rows[2]);
                sum += total;
                item.SubItems.Add(total.ToString());
                item.SubItems.RemoveAt(0);
                orderDetailListView.Items.Add(item);
            }
            ListViewItem temp = new ListViewItem();         
            temp.SubItems.Add("");
            temp.SubItems.Add("");
            temp.SubItems.Add(sum.ToString());
            orderDetailListView.Items.Add(temp);
        }

        private void myOrderListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(myOrderListView.SelectedItems.Count != 0)
            {
                setOrderDetailListView(myOrderListView.FocusedItem.SubItems[0].Text);
            }
        }
        
    }
}
