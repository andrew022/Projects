using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Pkcs;
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
    public partial class UpdateCustomerRecord : Form
    {
        private int _customerId;
        private int _addressId;
        public UpdateCustomerRecord(int customerId)
        {
            InitializeComponent();
            this.Text = "Update Customer";
            _customerId = customerId;
            LoadCity();
            LoadData();
        }
        private void LoadCity()
        {
            string query = "SELECT cityId, city FROM city;";
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
        private void LoadData()
        {
            string query = @"SELECT c.customerId, c.customerName, a.addressId, a.address, a.address2, a.cityId, a.postalCode, a.phone
                             FROM customer c
                             JOIN address a ON c.addressId = a.addressId
                             WHERE c.customerId = @customerId;";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, DataConnection.GetConnection());
                cmd.Parameters.AddWithValue("@customerId", _customerId);
                try
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        nameTxt.Text = reader["customerName"].ToString();
                        addressTxt.Text = reader["address"].ToString();
                        address2Txt.Text = reader["address2"].ToString();
                        postalTxt.Text = reader["postalCode"].ToString();
                        phoneTxt.Text = reader["phone"].ToString();
                        cityDropDown.SelectedValue = Convert.ToInt32(reader["cityId"]);
                        _addressId = Convert.ToInt32(reader["addressId"]);
                    }
                    reader.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            int selectedCity = Convert.ToInt32(cityDropDown.SelectedValue);

            if (string.IsNullOrEmpty(nameTxt.Text) || string.IsNullOrEmpty(addressTxt.Text) || string.IsNullOrEmpty(cityDropDown.Text) || string.IsNullOrEmpty(postalTxt.Text) || string.IsNullOrEmpty(phoneTxt.Text))
            {
                MessageBox.Show("Please fill in all required fields!");
                return;
            }
            foreach (char c in postalTxt.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Please only use numbers for postal code!");
                    return;
                }
            }
            foreach (char c in phoneTxt.Text)
            {
                if (!(char.IsDigit(c) || c == '-'))
                {
                    MessageBox.Show("Please only use numbers and '-'.");
                    return;
                }
            }
            DialogResult result = MessageBox.Show("Are you sure you want to update this record?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string updateAddress = @"UPDATE address
                                  SET address = @address, address2 = @address2, cityId = @cityId, postalCode = @postalCode, phone = @phone, lastUpdate = CURDATE(), lastUpdateBy = @user
                                  WHERE addressId = @addressId;";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(updateAddress, DataConnection.GetConnection());
                    cmd.Parameters.AddWithValue("@address", addressTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("@address2", address2Txt.Text.Trim());
                    cmd.Parameters.AddWithValue("@cityId", Convert.ToInt32(cityDropDown.SelectedValue));
                    cmd.Parameters.AddWithValue("@postalCode", postalTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("@phone", phoneTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("@user", Session.loggedUser);
                    cmd.Parameters.AddWithValue("addressId", _addressId);
                    cmd.ExecuteNonQuery();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                string updateCustomer = @"UPDATE customer
                                   SET customerName = @name, lastUpdate = CURDATE(), lastUpdateBy = @user
                                   WHERE customerId = @customerId;";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(updateCustomer, DataConnection.GetConnection());
                    cmd.Parameters.AddWithValue("@name", nameTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("@customerId", _customerId);
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
            if (result == DialogResult.No)
            {
                return;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
