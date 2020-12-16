using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS_03082180053_03082190021
{
    class Order
    {
        List<String> data = new List<String>();
        public void createOrder(Dictionary<ListViewItem.ListViewSubItemCollection, int> cart)
        {
            int sum = 0;            
            foreach (KeyValuePair<ListViewItem.ListViewSubItemCollection, int> entry in cart)
            {
                List<string> row = new List<string>();
                int price = int.Parse(entry.Key[3].Text);
                int qty = entry.Value;
                sum += (price * qty);
                row.Add(entry.Key[0].Text);
                row.Add(qty.ToString());
                
                data.Add(String.Join(",",row.ToArray()));
            }
            String sql = $"insert into `order` (total) values ({sum})";
            int modified = db.executeNonQuery(sql,"Order Created");          
            insertOrderHasProduct(modified);
            reduceStock();
        }


        public List<List<String>> getOrder()
        {
            String sql = "select * from `order` order by order_date desc";
            List<List<String>> data = db.executeQuery(sql);
            return data;
        }

        public List<List<String>> getOrderDetail(String orderid){
            String sql = "SELECT product_name,qty,price " +
                         $"FROM product INNER JOIN order_has_product ON product.productid = order_has_product.productid where orderid = {orderid}; ";
            return db.executeQuery(sql);
        }

        private void insertOrderHasProduct(int orderid)
        {
            
            foreach (String row in data)
            {                
                String value = $"({orderid},{row})";
                String sql = $"insert into order_has_product (orderid,productid,qty) values {value}";
                db.executeNonQuery(sql);
            }            
        }


        private void reduceStock()
        {
            foreach (String row in data)
            {
                String[] temp = row.Split(',');
                String sql = $"update product set stock = stock - {temp[1]} where productid = {temp[0]}";
                db.executeNonQuery(sql);
            }
        }
    }
}
