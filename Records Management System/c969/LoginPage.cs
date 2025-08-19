using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c969
{
    public static class Session
    {
        public static string loggedUser { get; set; }
    }
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            RegionChecker();
            passwordTxt.PasswordChar = '*';
            DataHelper.Server = "127.0.0.1";
            DataHelper.Port = "3306";
            DataHelper.DatabaseName = "client_schedule";
            DataHelper.Uid = "sqlUser";
            DataHelper.Pwd = "Passw0rd!";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string connectionString = $"server={DataHelper.Server};port={DataHelper.Port};database={DataHelper.DatabaseName};user={DataHelper.Uid};password={DataHelper.Pwd}";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = connectionString;
                conn.Open();
                try
                {
                    string sql = "SELECT userId FROM user WHERE userName=@username AND password=@password AND active=1";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    int userId = -1;
                    string region = RegionInfo.CurrentRegion.EnglishName;

                    cmd.Parameters.AddWithValue("@username", usernameTxt.Text);
                    cmd.Parameters.AddWithValue("@password", passwordTxt.Text);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        userId = reader.GetInt32("userId");
                        if (userId > 0) // Part 1.C
                        {
                            Session.loggedUser = usernameTxt.Text;
                            MainPage mainPage = new MainPage();
                            using(StreamWriter writer = File.AppendText("Login_History.txt")) // saves to bin/debug
                            {
                                writer.WriteLine($"Login Time: {DateTime.UtcNow}\nUsername: {Session.loggedUser}");
                                writer.WriteLine();
                            }
                            mainPage.Show();
                            this.Hide();
                            return;
                        }
                    }
                    if (usernameTxt.Text == "" ||  passwordTxt.Text == "")
                    {
                        if (region == "United States")
                        {
                            MessageBox.Show("Please enter a username or password!");
                        }
                        if (region == "Japan") // Part 1.b
                        {
                            MessageBox.Show("ユーザー名またはパスワードを入力してください！");
                        }
                    }
                    if (!reader.Read() && !string.IsNullOrWhiteSpace(usernameTxt.Text) && !string.IsNullOrWhiteSpace(passwordTxt.Text))
                    {
                        if(region == "United States")
                        {
                            MessageBox.Show("Invalid credentials!");
                        }
                        if (region == "Japan") // Part 1.b
                        {
                            MessageBox.Show("無効な資格情報です！");
                        }
                    }
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

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
        private void RegionChecker()
        {
            string region = RegionInfo.CurrentRegion.EnglishName; // Part 1.A
            if (region == "United States")
            {
                usernameLabel.Text = "Username";
                passwordLabel.Text = "Password";
                signInBtn.Text = "Sign-In";
                cancelBtn.Text = "Cancel";
                loginLabel.Text = "Login Screen";
                this.Text = "Login";
            }
            if (region == "Japan") // Part 1.b
            {
                usernameLabel.Text = "ユーザー名";
                passwordLabel.Text = "パスワード";
                signInBtn.Text = "サインイン";
                cancelBtn.Text = "キャンセル";
                loginLabel.Text = "ログイン画面";
                this.Text = "ログイン";
            }
        }
    }
}
