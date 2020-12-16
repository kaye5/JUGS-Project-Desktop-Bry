using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_03082180053_03082190021
{
    class Stock
    {
        List<List<String>> data = new List<List<String>>();
        public List<List<String>> getStock()
        {
            return db.executeQuery("select * from product");           
        }
        public void updateStock(List<string> form,string productid)
        {
            String sql = $"update product set product_name = '{form[0]}', stock = {form[1]}, price = {form[2]} where productid = {productid}";
            db.executeNonQuery(sql, $"product {productid} updated");
        }
        public void addStock(List<string> form)
        {
            
            String sql = $"insert into product(product_name,stock,price) values ('{form[0]}','{form[1]}','{form[2]}') ";
            db.executeNonQuery(sql, "Item Added");
        }
        public void deleteStock(string productid)
        {
            String sql = $"delete from product where productid = {productid}";
            db.executeNonQuery(sql, "Item Deleted");
        }
    }
}
