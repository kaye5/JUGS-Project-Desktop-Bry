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
    public partial class MainForm : Form
    {
        HomeForm homePage;
        StockForm stockPage;
        public MainForm()
        {
            InitializeComponent();
            homePage = new HomeForm();
            stockPage = new StockForm();
            showPage(homePage,homeTab);
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabMain.SelectedIndex)
            {
                case 0:
                    showPage(new HomeForm(),homeTab);
                    break;
                case 1:
                    showPage(new StockForm(), stockTab);
                    break;
                case 2:
                    showPage(new OrderForm(), orderTab);
                    break;
                case 3:
                    showPage(new ReportForm(), reportTab);
                    break;
                default:
                    break;
            }
        }

        void showPage(Form container,TabPage tabPage)
        {
            container.TopLevel = false;
            container.Visible = true;
            tabPage.Controls.Add(container);
        }
    }
}
