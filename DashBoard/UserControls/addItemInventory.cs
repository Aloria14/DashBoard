using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using DashBoard;
using System.Management.Instrumentation;


namespace DashBoard.UserControls
{
    public partial class addItemInventory : Form
    {
        public addItemInventory()
        {

            InitializeComponent();

        }
        SqlConnection conn = new SqlConnection(@"Data Source=ALORIA;Initial Catalog=db_peanutbutter_inventory;Integrated Security=True");
        private void addItemInventory_Load(object sender, EventArgs e)
        {
 
        }
        public void Data() 
        {
            UC_Inventory inven = new UC_Inventory();        
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM db_inventry", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            sd.Update(dt);
            inven.inventoryDGV.DataSource = dt;
        }
        private void itemAdd_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO db_inventory (ID, Items, Weight, Quantity, Price) VALUES (@ID, @Items, @Weight, @Quantity, @Price)", conn);
                cmd.Parameters.AddWithValue("@ID", int.Parse(txtID.Text));
                cmd.Parameters.AddWithValue("@Items", txtItemname.Text);
                cmd.Parameters.AddWithValue("@Weight", int.Parse(txtWeight.Text));
                cmd.Parameters.AddWithValue("@Quantity", int.Parse(txtQuantity.Text));
                cmd.Parameters.AddWithValue("@Price", double.Parse(txtprice.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully added");
                Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Clear();
                txtItemname.Clear();
                txtWeight.Clear();
                txtQuantity.Clear();
                txtprice.Clear();
                txtID.Focus();
            }
            finally
            {
                conn.Close();
            }
        }

        private void itemDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM db_inventory WHERE ID = @ID", conn);
                cmd.Parameters.AddWithValue("@ID", int.Parse(txtID.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Successfully Deleted");
                Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Clear();
                txtItemname.Clear();
                txtWeight.Clear();
                txtQuantity.Clear();
                txtprice.Clear();
                txtID.Focus();
            }
            finally
            {
                conn.Close();
            }

        }

        private void itemUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE db_inventory SET Items = @Items, Weight = @Weight, Quantity = @Quantity, Price = @Price WHERE ID = @ID", conn);
                cmd.Parameters.AddWithValue("@ID", int.Parse(txtID.Text));
                cmd.Parameters.AddWithValue("@Items", txtItemname.Text);
                cmd.Parameters.AddWithValue("@Weight", int.Parse(txtWeight.Text));
                cmd.Parameters.AddWithValue("@Quantity", int.Parse(txtQuantity.Text));
                cmd.Parameters.AddWithValue("@Price", double.Parse(txtprice.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Successfully Updated");
                Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Clear();
                txtItemname.Clear();
                txtWeight.Clear();
                txtQuantity.Clear();
                txtprice.Clear();
                txtID.Focus();
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
