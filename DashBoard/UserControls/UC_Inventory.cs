using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace DashBoard.UserControls
{
    public partial class UC_Inventory : UserControl
    {
        public UC_Inventory()
        {
            InitializeComponent();

        }
        SqlConnection conn = new SqlConnection(@"Data Source=ALORIA;Initial Catalog=db_peanutbutter_inventory;Integrated Security=True");

        private void UC_Inventory_Load(object sender, EventArgs e)
        {
            fillDGV();
            inventoryDGV.Columns[0].Width = 50;
            inventoryDGV.Columns[1].Width = 280;
            inventoryDGV.Columns[2].Width = 180;
            inventoryDGV.Columns[3].Width = 180;
            inventoryDGV.Columns[4].Width = 180;


        }

        private void editInventory_Click_1(object sender, EventArgs e)
        {
            addItemInventory aiInventory = new addItemInventory();
            aiInventory.Show();
        }

        private void Notification_Click(object sender, EventArgs e)
        {

        }
    
        private void inventoryPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        public void fillDGV()
        {
            try
            { 
                conn.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM db_inventory", conn);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                inventoryDGV.DataSource = dt;
                inventoryDGV.Refresh();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"SQL Exception: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void refreshInventory_Click(object sender, EventArgs e)
        {
            fillDGV();
        }
    }
}
