using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c969
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            this.Text = "Home Screen";
            try
            {
                DataConnection.GetConnection();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            Customer();
            Appointment();
            ReminderChecker();
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Customer()
        {
            try
            {
                string query = "SELECT * FROM customer;";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, DataConnection.GetConnection());
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                customerData.DataSource = dataTable;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Appointment()
        {
            try
            {
                string query = @"SELECT a.appointmentId, a.customerId, c.customerName, a.userId, u.userName, a.title, a.description, a.location, a.contact, a.type, a.start, a.end 
                         FROM appointment a
                         JOIN user u ON a.userId = u.userId
                         JOIN customer c ON a.customerId = c.customerId;";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, DataConnection.GetConnection());
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                TimeZoneInfo easternZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
                TimeZoneInfo localZone = TimeZoneInfo.Local;

                foreach (DataRow row in dataTable.Rows)
                {
                    if (DateTime.TryParse(row["start"].ToString(), out DateTime estStart))
                    {
                        DateTime localStart = TimeZoneInfo.ConvertTime(estStart, easternZone, localZone);
                        row["start"] = localStart;
                    }

                    if (DateTime.TryParse(row["end"].ToString(), out DateTime estEnd))
                    {
                        DateTime localEnd = TimeZoneInfo.ConvertTime(estEnd, easternZone, localZone);
                        row["end"] = localEnd;
                    }
                }

                appointmentData.DataSource = dataTable;

                AppointmentList.Appointment.Clear();
                foreach (DataRow row in dataTable.Rows)
                {
                    Appointments appointment = new Appointments
                    {
                        AppointmentId = Convert.ToInt32(row["appointmentId"]),
                        CustomerId = Convert.ToInt32(row["customerId"]),
                        UserId = Convert.ToInt32(row["userId"]),
                        Title = row["title"].ToString(),
                        Description = row["description"].ToString(),
                        Location = row["location"].ToString(),
                        Contact = row["contact"].ToString(),
                        Type = row["type"].ToString(),
                        Start = Convert.ToDateTime(row["start"]),
                        End = Convert.ToDateTime(row["end"]),
                        CustomerName = row["customerName"].ToString(),
                        UserName = row["userName"].ToString()
                    };
                    AppointmentList.Appointment.Add(appointment);
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DayAppointments()
        {
            var searchTerm = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
            string query = $"SELECT appointmentId, title, description, location, type, start, end FROM appointment WHERE start LIKE '%{searchTerm}%';";
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, DataConnection.GetConnection());
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                TimeZoneInfo easternZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
                TimeZoneInfo localZone = TimeZoneInfo.Local;

                foreach (DataRow row in dataTable.Rows)
                {
                    if (DateTime.TryParse(row["start"].ToString(), out DateTime estStart))
                    {
                        DateTime localStart = TimeZoneInfo.ConvertTime(estStart, easternZone, localZone);
                        row["start"] = localStart;
                    }

                    if (DateTime.TryParse(row["end"].ToString(), out DateTime estEnd))
                    {
                        DateTime localEnd = TimeZoneInfo.ConvertTime(estEnd, easternZone, localZone);
                        row["end"] = localEnd;
                    }
                }

                dataGridView1.DataSource = dataTable;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void customerData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void customerAddBtn_Click(object sender, EventArgs e)
        {
            using (AddCustomerRecord addCustomerRecord = new AddCustomerRecord())
            {
                var result = addCustomerRecord.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Customer();
                }
            }
        }

        private void customerUpdateBtn_Click(object sender, EventArgs e)
        {
            if(customerData.CurrentRow != null)
            {
                int customerId = Convert.ToInt32(customerData.CurrentRow.Cells["customerId"].Value);
                using(UpdateCustomerRecord updateCustomerRecord = new UpdateCustomerRecord(customerId))
                {
                    var result = updateCustomerRecord.ShowDialog();
                    if(result == DialogResult.OK)
                    {
                        Customer();
                    }
                }
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Customer();
        }

        private void customerDelBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this customer record and the associated address record?","Confirm",MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                int customerId = Convert.ToInt32(customerData.CurrentRow.Cells["customerId"].Value);
                int addressId = Convert.ToInt32(customerData.CurrentRow.Cells["addressId"].Value);

                string query = @"START TRANSACTION;
                             DELETE FROM customer WHERE customerId = @customerId;
                             DELETE FROM address WHERE addressId = @addressId;
                             COMMIT;";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, DataConnection.GetConnection());
                    cmd.Parameters.AddWithValue("@customerId", customerId);
                    cmd.Parameters.AddWithValue("@addressId", addressId);
                    cmd.ExecuteNonQuery();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Customer();
            }
            if(result == DialogResult.No)
            {
                return;
            }
        }

        private void appointmentRefreshBtn_Click(object sender, EventArgs e)
        {
            Appointment();
        }

        private void appointmentAddBtn_Click(object sender, EventArgs e)
        {
            using (AddAppointmentRecord addAppointmentRecord = new AddAppointmentRecord())
            {
                var result = addAppointmentRecord.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Appointment();
                }
            }
        }

        private void appointmentCalendarBtn_Click(object sender, EventArgs e)
        {
            DayAppointments();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DayAppointments();
        }

        private void appointmentUpdateBtn_Click(object sender, EventArgs e)
        {
            if (customerData.CurrentRow != null)
            {
                int appointmentId = Convert.ToInt32(appointmentData.CurrentRow.Cells["appointmentId"].Value);
                using (UpdateAppointmentRecord updateAppointmentRecord = new UpdateAppointmentRecord(appointmentId))
                {
                    var result = updateAppointmentRecord.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        Appointment();
                    }
                }
            }
        }

        private void appointmentDelBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this appointment record and the associated address record?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int appointmentId = Convert.ToInt32(appointmentData.CurrentRow.Cells["appointmentId"].Value);

                string query = "DELETE FROM appointment WHERE appointmentId = @appointmentId;";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, DataConnection.GetConnection());
                    cmd.Parameters.AddWithValue("@appointmentId", appointmentId);
                    cmd.ExecuteNonQuery();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Appointment();
            }
            if (result == DialogResult.No)
            {
                return;
            }
        }
        private void AppointmentTypeMonths()
        {
            var report = AppointmentList.Appointment
                .GroupBy(a => new { a.Start.Year, a.Start.Month, a.Type })
                .Select(g => new { Year = g.Key.Year, Month = g.Key.Month, Type = g.Key.Type, Count = g.Count() });
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in report)
            {
                string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(item.Month);
                stringBuilder.AppendLine($"{monthName} {item.Year} - {item.Type}: {item.Count}");
            }
            MessageBox.Show(stringBuilder.ToString(), "# of Appointmnent Types per Month");
        }
        private void UserSchedule()
        {
            var report = AppointmentList.Appointment
                .GroupBy(a => new { a.UserId, a.UserName})
                .Select(g => new { UserId = g.Key.UserId, UserName = g.Key.UserName ,ApptList = g });
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in report)
            {
                stringBuilder.AppendLine($"{item.UserName} (Id: {item.UserId}):");
                foreach(var  item2 in item.ApptList)
                {
                    stringBuilder.AppendLine($"    {item2.Title}: {item2.Start} - {item2.End}");
                }
            }
            MessageBox.Show(stringBuilder.ToString(), "User Schedule's");
        }
        private void CustomerAppointmentCount()
        {
            var report = AppointmentList.Appointment
                .GroupBy(a => new { a.CustomerId, a.CustomerName })
                .Select(g => new { CustomerId = g.Key.CustomerId, CustomerName = g.Key.CustomerName, Count = g.Count() });
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in report)
            {
                stringBuilder.AppendLine($"{item.CustomerName} (Id: {item.CustomerId})    -    {item.Count} Appointments");
            }
            MessageBox.Show(stringBuilder.ToString(), "Customer Appointment Count");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AppointmentTypeMonths();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserSchedule();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomerAppointmentCount();
        }
        private void ReminderChecker()
        {
            List<string> userID = new List<string>();
            var searchName = Session.loggedUser.ToString();
            string userNameQuery = $"SELECT userId from user WHERE userName = '{searchName}';";

            try
            {
                MySqlCommand cmd = new MySqlCommand(userNameQuery, DataConnection.GetConnection());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    userID.Add(reader["userId"].ToString());
                }
                reader.Close();
                foreach (var item in AppointmentList.Appointment)
                {
                    if(item.UserId != Convert.ToInt32(userID[0]))
                    {
                        return;
                    }
                    TimeZoneInfo localTimeZone = TimeZoneInfo.Local;
                    TimeZoneInfo easternZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
                    DateTime originalTime = item.Start;
                    DateTime UtcTime = TimeZoneInfo.ConvertTimeToUtc(originalTime, easternZone);
                    DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(UtcTime, localTimeZone);
                    TimeSpan timeDiff = localTime - DateTime.Now;
                    if (timeDiff.TotalMinutes > 0 && timeDiff.TotalMinutes <= 15)
                    {
                        MessageBox.Show($"Appointment coming up: {item.Title} at {item.Start.ToString("HH:mm:ss")}", "Reminder!");
                    }
                    continue;
                }
                return;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
