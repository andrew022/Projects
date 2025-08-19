using MySql.Data.MySqlClient;
using Org.BouncyCastle.Cms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c969
{
    public partial class AddAppointmentRecord : Form
    {
        private readonly TimeZoneInfo localTimeZone = TimeZoneInfo.Local;
        private readonly TimeZoneInfo easternZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
        public AddAppointmentRecord()
        {
            InitializeComponent();
            LoadData();
            dateTimePicker1_ValueChanged(null, null);
            TimeOverlapChecker();

        }

        private void LoadData()
        {
            string city = "SELECT cityId, city FROM city";
            try
            {
                MySqlCommand cmd = new MySqlCommand(city, DataConnection.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                locationComboBox.DataSource = dataTable;
                locationComboBox.DisplayMember = "city";
                locationComboBox.ValueMember = "cityId";
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            string customer = "SELECT customerId, customerName FROM customer";
            try
            {
                MySqlCommand cmd = new MySqlCommand(customer, DataConnection.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                customerComboBox.DataSource = dataTable;
                customerComboBox.DisplayMember = "customerName";
                customerComboBox.ValueMember = "customerId";
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            string user = "SELECT userId, userName FROM user WHERE userName = @user;";
            try
            {
                MySqlCommand cmd = new MySqlCommand(user, DataConnection.GetConnection());
                cmd.Parameters.AddWithValue("@user", Session.loggedUser);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    userIdTxt.Text = Convert.ToString(reader["userId"]);
                }
                reader.Close();
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
            if (string.IsNullOrEmpty(customerComboBox.Text) || string.IsNullOrEmpty(userIdTxt.Text) || string.IsNullOrEmpty(titleTxt.Text) || string.IsNullOrEmpty(descriptionTxt.Text) || string.IsNullOrEmpty(locationComboBox.Text) || string.IsNullOrEmpty(contactTxt.Text) || string.IsNullOrEmpty(typeComboBox.Text))
            {
                MessageBox.Show("Please fill in all required fields!");
                return;
            }
            if ((string)comboBox1.SelectedItem == "Unavailable")
            {
                MessageBox.Show("Please select an available time!");
                return;
            }

            string selectedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            DateTime localTime = DateTime.Parse($"{selectedDate} {comboBox1.SelectedItem}");
            DateTime utcTime = TimeZoneInfo.ConvertTimeToUtc(localTime, localTimeZone);
            DateTime estStart = TimeZoneInfo.ConvertTimeFromUtc(utcTime, easternZone);
            DateTime estEnd = estStart.AddHours(1);

            string startTime = estStart.ToString("yyyy-MM-dd HH:mm:ss");
            string endTime = estEnd.ToString("yyyy-MM-dd HH:mm:ss");

            DialogResult result = MessageBox.Show("Confirm this appointment?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string query = @"INSERT INTO appointment (customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy)
                         VALUES (@customerId, @userId, @title, @description, @location, @contact, @type, 'not needed', @start, @end, CURDATE(), @user, CURDATE(), @user);";
                try // Part 3.B
                {
                    MySqlCommand cmd = new MySqlCommand(query, DataConnection.GetConnection());
                    cmd.Parameters.AddWithValue("@customerId", Convert.ToInt32(customerComboBox.SelectedValue));
                    cmd.Parameters.AddWithValue("@userId", userIdTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("@title", titleTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("@description", descriptionTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("@location", locationComboBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@contact", contactTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("@type", typeComboBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@user", Session.loggedUser);
                    cmd.Parameters.AddWithValue("@start", startTime);
                    cmd.Parameters.AddWithValue("@end", endTime);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            DateTime selectedDate = dateTimePicker1.Value.Date;

            TimeZoneInfo localTimeZone = TimeZoneInfo.Local;
            TimeZoneInfo easternZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");

            for (int hour = 9; hour <= 16; hour++) // Part 3.A - Time selection stops at 4pm since appointments are 1hr long
            {
                DateTime estTime = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, hour, 0, 0);
                DateTime utcTime = TimeZoneInfo.ConvertTimeToUtc(estTime, easternZone);
                DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, localTimeZone);

                comboBox1.Items.Add(localTime.ToString("hh:mm tt"));
            }

            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;

            TimeOverlapChecker();
        }
        private void TimeOverlapChecker() // Part 3.A
        {
            TimeZoneInfo localTimeZone = TimeZoneInfo.Local;
            TimeZoneInfo easternZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");

            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                DateTime localTime;
                bool parsed = DateTime.TryParse($"{dateTimePicker1.Value:yyyy-MM-dd} {comboBox1.Items[i]}", out localTime);

                if (!parsed)
                    continue;

                DateTime utcTime = TimeZoneInfo.ConvertTimeToUtc(localTime, localTimeZone);
                DateTime estTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, easternZone);

                string wantedTime = estTime.ToString("yyyy-MM-dd HH:mm:ss");

                string query = "SELECT EXISTS(SELECT * FROM appointment WHERE start = @wantedTime);";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, DataConnection.GetConnection());
                    cmd.Parameters.AddWithValue("@wantedTime", wantedTime);
                    bool exists = Convert.ToBoolean(cmd.ExecuteScalar());
                    if (exists)
                    {
                        comboBox1.Items[i] = "Unavailable";
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
