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
    public partial class ReportForm : Form
    {
        Report report;
        public ReportForm()
        {
            InitializeComponent();
            report = new Report();
            setTodaySummaryListView();
            setAllSummaryListView();
            getTotalOrder();
            getTotalIncome();
            getBestSeller();
            getAllTotalIncome();
            getAllTotalOrder();
            getAllBestSeller();
        }

        private void setTodaySummaryListView()
        {
            List<List<String>> data = report.getTodayQtyProduct();
            todaySummaryListView.Items.Clear();
            foreach (var rows in data)
            {
                ListViewItem item = new ListViewItem();
                foreach (var row in rows)
                {
                    item.SubItems.Add(row);
                }
                item.SubItems.RemoveAt(0);
                todaySummaryListView.Items.Add(item);
            }
        }
        private void setAllSummaryListView()
        {
            List<List<String>> data = report.getAllQtyProduct();
            AllListView.Items.Clear();
            foreach (var rows in data)
            {
                ListViewItem item = new ListViewItem();
                foreach (var row in rows)
                {
                    item.SubItems.Add(row);
                }
                item.SubItems.RemoveAt(0);
                AllListView.Items.Add(item);
            }
        }
        private void getTotalOrder()
        {
            object totalOrder = report.getTodalTotalOrder();
            totalOrderTodayTB.Text = totalOrder.ToString();
        }
        private void getTotalIncome()
        {
            object totalIncome = report.getTodayTotalIncome();
            totalIncomeTodayTB.Text = totalIncome.ToString();
        }
        private void getAllTotalOrder()
        {
            object totalOrder = report.getAllTotalOrder();
            allTotalOrderTB.Text = totalOrder.ToString();
        }
        private void getAllTotalIncome()
        {
            object totalIncome= report.getAllTotalIncome();
            allTotalIncomeTB.Text = totalIncome.ToString();
        }
        
        private void getBestSeller()
        {
            List<List<String>> data = report.getTodayQtyProduct();
            String product = "";
            int max = 0;
            foreach (var rows in data)
            {
                int temp = int.Parse(rows[1]);
                if (max < temp)
                {
                    max = temp;
                    product = rows[0];
                }                    
            }
            todayBestTB.Text = product;
        }
        private void getAllBestSeller()
        {
            List<List<String>> data = report.getAllQtyProduct();
            String product = "";
            int max = 0;
            foreach (var rows in data)
            {
                int temp = int.Parse(rows[1]);
                if (max < temp)
                {
                    max = temp;
                    product = rows[0];
                }
            }
            allBestTB.Text = product;
        }
    }
}
