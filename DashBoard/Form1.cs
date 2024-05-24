using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Web.UI.Design.WebControls;
using DashBoard.UserControls;
using System.Data.SqlClient;
using System.Data;

namespace DashBoard
{
    public partial class Dashboard : Form
    { 
        public Dashboard()
        {
            InitializeComponent();

        }


        public void addUserControl (UserControl userControl) 
        {
           
                userControl.Dock = DockStyle.Fill;
                panelContainer.Controls.Clear();
                panelContainer.Controls.Add(userControl);
                userControl.BringToFront();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            UC_Dashboard dashboard = new UC_Dashboard();
            addUserControl (dashboard);
        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            UC_Inventory inventory = new UC_Inventory();
            addUserControl(inventory);


        }

        private void Order_Click(object sender, EventArgs e)
        {
            UC_Order order = new UC_Order();
            addUserControl(order);
        }

        private void Accounting_Click(object sender, EventArgs e)
        {
            UC_Finance finance = new UC_Finance();
            addUserControl(finance);
        }

        private void OrderHistory_Click_1(object sender, EventArgs e)
        {
            UC_OrderHistory history = new UC_OrderHistory();
            addUserControl(history);
        }

        private void User_Click(object sender, EventArgs e)
        {
            UC_User user = new UC_User();
            addUserControl(user);
        }

    }
}
