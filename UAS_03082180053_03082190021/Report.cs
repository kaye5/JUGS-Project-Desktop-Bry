using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_03082180053_03082190021
{
    class Report
    {
        public List<List<String>> getTodayQtyProduct()
        {
            String sql = "SELECT product.product_name, Sum(order_has_product.qty) AS qty " +
                        "FROM product INNER JOIN([order] INNER JOIN order_has_product ON order.orderid = order_has_product.orderid) ON product.productid = order_has_product.productid " +
                        "where order_date > Date() " +
                        "GROUP BY product.product_name ORDER BY Sum(order_has_product.qty) desc;";
            return db.executeQuery(sql);            
        }
        public List<List<String>> getAllQtyProduct()
        {
            String sql = "SELECT product.product_name, Sum(order_has_product.qty) AS qty " +
                        "FROM product INNER JOIN([order] INNER JOIN order_has_product ON order.orderid = order_has_product.orderid) ON product.productid = order_has_product.productid " +
                        "where order_date < Date() " +
                        "GROUP BY product.product_name ORDER BY Sum(order_has_product.qty) desc;";
            return db.executeQuery(sql);
        }

        public object getTodayTotalIncome()
        {
            String sql = "select sum(total) as price from  `order` where order_date > Date();";
            return db.executeScalar(sql);
        }

        public object getTodalTotalOrder()
        {
            String sql = "select count(*) as price from  `order` where order_date > Date();";
            return db.executeScalar(sql);
        }

        public object getAllTotalOrder()
        {
            String sql = "select count(*) as price from  `order`";
            return db.executeScalar(sql);
        }

        public object getAllTotalIncome()
        {
            String sql = "select sum(total) as price from  `order`";
            return db.executeScalar(sql);
        }
    }
}
