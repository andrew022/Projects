using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c969
{
    public partial class AddCustomerRecord : Form
    {
        public AddCustomerRecord()
        {
            InitializeComponent();
            this.Text = "Add Customer";
            LoadCity();
        }

        private void LoadCity()
        {
            string query = "SELECT cityId, city FROM city";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, DataConnection.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                cityDropDown.DataSource = dataTable;
                cityDropDown.DisplayMember = "city";
                cityDropDown.ValueMember = "cityId";
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTxt.Text) || string.IsNullOrEmpty(addressTxt.Text) || string.IsNullOrEmpty(cityDropDown.Text) || string.IsNullOrEmpty(postalTxt.Text) || string.IsNullOrEmpty(phoneTxt.Text))
            {
                MessageBox.Show("Please fill in all required fields!");
                return;
            }
            foreach(char c in postalTxt.Text)
            {
                if(!char.IsDigit(c))
                {
                    MessageBox.Show("Please only use numbers for postal code!");
                    return;
                }
            }
            foreach(char c in phoneTxt.Text)
            {
                if (!(char.IsDigit(c) || c == '-'))
                {
                    MessageBox.Show("Please only use numbers and '-'.");
                    return;
                }
            }
            DialogResult result = MessageBox.Show("Add this new record?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string addAddress = @"INSERT INTO address (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy)
                                   VALUES (@address, @address2, @cityId, @postalCode, @phone, CURDATE(), @user, CURDATE(), @user);";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(addAddress, DataConnection.GetConnection());
                    cmd.Parameters.AddWithValue("@address", addressTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("@address2", address2Txt.Text.Trim());
                    cmd.Parameters.AddWithValue("@cityId", Convert.ToInt32(cityDropDown.SelectedValue));
                    cmd.Parameters.AddWithValue("@postalCode", postalTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("@phone", phoneTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("@user", Session.loggedUser);
                    cmd.ExecuteNonQuery();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                int addressId;
                using (MySqlCommand cmd = new MySqlCommand("SELECT LAST_INSERT_ID();", DataConnection.GetConnection()))
                {
                    addressId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                string addCustomer = @"INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy)
                                   VALUES (@name, @addressId, 1, CURDATE(), @user, CURDATE(), @user);";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(addCustomer, DataConnection.GetConnection());
                    cmd.Parameters.AddWithValue("@name", nameTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("@addressId", addressId);
                    cmd.Parameters.AddWithValue("@user", Session.loggedUser);
                    cmd.ExecuteNonQuery();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            if(result == DialogResult.No)
            {
                return;
            }
        }
    }
}
