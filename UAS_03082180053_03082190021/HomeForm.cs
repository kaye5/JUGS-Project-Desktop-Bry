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
    public partial class HomeForm : Form
    {
        Stock stock;
        private Dictionary<ListViewItem.ListViewSubItemCollection, int> cart = new Dictionary<ListViewItem.ListViewSubItemCollection, int>();
        private List<List<string>> data;

        public HomeForm()
        {
            InitializeComponent();
            stock = new Stock();
            setItemListView();
        }

        private void setItemListView()
        {            
            data = stock.getStock();
            homeProductListView.Items.Clear();
            foreach (List<String> rows in data)
            {
                ListViewItem row = new ListViewItem();
                foreach (String item in rows)
                {
                    row.SubItems.Add(item);
                }
                row.SubItems.RemoveAt(0);
                homeProductListView.Items.Add(row);
            }

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if(homeProductListView.SelectedItems.Count != 0)
            {
                ListViewItem.ListViewSubItemCollection item = homeProductListView.FocusedItem.SubItems;                
                int count;
                cart.TryGetValue(item, out count);
                if (int.Parse(item[2].Text) > count )
                {
                    if (count == 0)
                        cart.Add(item, 1);
                    else
                        cart[item]++;
                    updateCartListView();
                }
                                    
            }            
            
        }
        private void updateCartListView()
        {
            homeCartListView.Items.Clear();
            foreach (KeyValuePair< ListViewItem.ListViewSubItemCollection, int> entry in cart)
            {
                ListViewItem cartListView = new ListViewItem();
                cartListView.SubItems.Add(entry.Key[0].Text);
                cartListView.SubItems.Add(entry.Key[1].Text);
                cartListView.SubItems.Add(entry.Value.ToString());
                int price = int.Parse(entry.Key[3].Text);
                cartListView.SubItems.Add( (price * entry.Value).ToString() );
                cartListView.SubItems.RemoveAt(0);
                homeCartListView.Items.Add(cartListView);
            }
        }
        private void Remove_Click(object sender, EventArgs e)
        {
            if (homeCartListView.SelectedItems.Count != 0)
            {
                ListViewItem.ListViewSubItemCollection item = homeProductListView.FocusedItem.SubItems;
                cart.Remove(item);
                updateCartListView();
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {

            refresh();
        }
        private void refresh()
        {
            cart.Clear();
            homeCartListView.Items.Clear();
            setItemListView();
        }
        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.createOrder(cart);
            refresh();
        }
    }
}
