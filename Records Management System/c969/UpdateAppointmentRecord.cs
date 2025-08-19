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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace c969
{
    public partial class UpdateAppointmentRecord : Form
    {
        private int _appointmentId;
        private readonly TimeZoneInfo localTimeZone = TimeZoneInfo.Local;
        private readonly TimeZoneInfo easternZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
        public UpdateAppointmentRecord(int appointmentId)
        {
            InitializeComponent();
            _appointmentId = appointmentId;
            LoadCustomer();
            LoadLocation();
            LoadData();
            updateDateTimePicker1_ValueChanged(null, null);
            TimeOverlapChecker();
        }
        private void LoadCustomer()
        {
            string query = "SELECT customerId, customerName FROM customer;";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, DataConnection.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                updateCustomerComboBox.DataSource = dataTable;
                updateCustomerComboBox.DisplayMember = "customerName";
                updateCustomerComboBox.ValueMember = "customerId";
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadLocation()
        {
            string query = "SELECT city FROM city;";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, DataConnection.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                updateLocationComboBox.DataSource = dataTable;
                updateLocationComboBox.DisplayMember = "city";
                updateLocationComboBox.ValueMember = "city";
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadData()
        {
            string query = @"SELECT a.appointmentId, c.customerName, u.userId, a.title, a.description, a.location, a.contact, a.type 
                             FROM appointment a
                             JOIN customer c ON c.customerId = a.customerId
                             JOIN user u ON u.userId = a.userId
                             WHERE a.appointmentId = @appointmentId;";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, DataConnection.GetConnection());
                cmd.Parameters.AddWithValue("@appointmentId", _appointmentId);
                try
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        updateCustomerComboBox.Text = reader["customerName"].ToString();
                        updateUserIdTxt.Text = reader["userId"].ToString();
                        updateTitleTxt.Text = reader["title"].ToString();
                        updateDescriptionTxt.Text = reader["description"].ToString();
                        updateLocationComboBox.Text = reader["location"].ToString();
                        updateContactTxt.Text = reader["contact"].ToString();
                        updateTypeComboBox.Text = reader["type"].ToString();
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

        private void updateSaveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(updateCustomerComboBox.Text) || string.IsNullOrEmpty(updateUserIdTxt.Text) || string.IsNullOrEmpty(updateTitleTxt.Text) || string.IsNullOrEmpty(updateDescriptionTxt.Text) || string.IsNullOrEmpty(updateLocationComboBox.Text) || string.IsNullOrEmpty(updateContactTxt.Text) || string.IsNullOrEmpty(updateTypeComboBox.Text))
            {
                MessageBox.Show("Please fill in all required fields!");
                return;
            }
            if ((string)updateComboBox1.SelectedItem == "Unavailable")
            {
                MessageBox.Show("Please select an available time!");
                return;
            }

            string selectedDate = updateDateTimePicker1.Value.ToString("yyyy-MM-dd");
            DateTime localTime = DateTime.Parse($"{selectedDate} {updateComboBox1.SelectedItem}");
            DateTime utcTime = TimeZoneInfo.ConvertTimeToUtc(localTime, localTimeZone);
            DateTime estStart = TimeZoneInfo.ConvertTimeFromUtc(utcTime, easternZone);
            DateTime estEnd = estStart.AddHours(1);

            string startTime = estStart.ToString("yyyy-MM-dd HH:mm:ss");
            string endTime = estEnd.ToString("yyyy-MM-dd HH:mm:ss");

            DialogResult result = MessageBox.Show("Confirm appointment update?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string query = @"UPDATE appointment
                                 SET customerId = @customerId, title = @title, description = @description, location = @location, contact = @contact, type = @type, start = @start, end = @end, lastUpdate = CURDATE(), lastUpdateBy = @userName
                                 WHERE appointmentId = @appointmentId;"; // Part 3.B
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, DataConnection.GetConnection());
                    cmd.Parameters.AddWithValue("@customerId", Convert.ToInt32(updateCustomerComboBox.SelectedValue));
                    cmd.Parameters.AddWithValue("@title", updateTitleTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("@description", updateDescriptionTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("@location", updateLocationComboBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@contact", updateContactTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("@type", updateTypeComboBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@start", startTime);
                    cmd.Parameters.AddWithValue("@end", endTime);
                    cmd.Parameters.AddWithValue("@userName", Session.loggedUser);
                    cmd.Parameters.AddWithValue("@appointmentId", _appointmentId);
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

        private void updateDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            updateComboBox1.Items.Clear();

            DateTime selectedDate = updateDateTimePicker1.Value.Date;

            TimeZoneInfo localTimeZone = TimeZoneInfo.Local;
            TimeZoneInfo easternZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");

            for (int hour = 9; hour <= 16; hour++) // Part 3.A - Time selection stops at 4pm since appointments are 1 hr long
            {
                DateTime estTime = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, hour, 0, 0);
                DateTime utcTime = TimeZoneInfo.ConvertTimeToUtc(estTime, easternZone);
                DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, localTimeZone);

                updateComboBox1.Items.Add(localTime.ToString("hh:mm tt"));
            }

            if (updateComboBox1.Items.Count > 0)
                updateComboBox1.SelectedIndex = 0;

            TimeOverlapChecker();
        }
        private void TimeOverlapChecker() // Part 3.A
        {
            TimeZoneInfo localTimeZone = TimeZoneInfo.Local;
            TimeZoneInfo easternZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");

            for (int i = 0; i < updateComboBox1.Items.Count; i++)
            {
                DateTime localTime;
                bool parsed = DateTime.TryParse($"{updateDateTimePicker1.Value:yyyy-MM-dd} {updateComboBox1.Items[i]}", out localTime);

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
                        updateComboBox1.Items[i] = "Unavailable";
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void updateCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
