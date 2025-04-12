using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Drive.v3.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PDMcustom
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private SqlConnection conn;
        private DataTable dt = new DataTable();
        private SqlDataAdapter da = new SqlDataAdapter();

        private void connect()
        {
            String cn = @"Data Source=LAPTOP-KVUNFFR7\SQLEXPRESS;Initial Catalog=PDM;Integrated Security=True;";
            try
            {
                conn = new SqlConnection(cn);
                conn.Open();
                //labelStatus.Text = "Status: Successfully connected to the database";
                //labelStatus.ForeColor = System.Drawing.Color.Green;
                tbUsername.Enabled = true;
                tbPassword.Enabled = true;
                version();
            }
            catch (Exception ex)
            {
                labelStatus.Text = "Status: Failed to connect to the server";
                labelStatus.ForeColor = System.Drawing.Color.Red;
                //await Task.Delay(2000);
                //Status_label.Text = "Trying to reconnect...";
                //Status_label.ForeColor = System.Drawing.Color.Yellow;
            }
        }
        private void disconnect()
        {
            conn.Close();
            conn.Dispose();
            conn = null;
        }
        private void version()
        {
            labelVersion.Text = "Version.0";
            labelVersion.ForeColor = Color.Black;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void tbUsername_Enter(object sender, EventArgs e)
        {
            if (tbUsername.Text == "Email")
            {
                tbUsername.Text = "";
                tbUsername.ForeColor = Color.Black;
            }
        }

        private void tbUsername_Leave(object sender, EventArgs e)
        {
            if (tbUsername.Text == "")
            {
                tbUsername.Text = "Email";
                tbUsername.ForeColor = Color.DarkGray;
            }
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "●●●●●●●●")
            {
                tbPassword.Text = "";
                tbPassword.ForeColor = Color.Black;
            }
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                tbPassword.Text = "●●●●●●●●";
                tbPassword.ForeColor = Color.DarkGray;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (chkSaveLogin.Checked)
            {
                Properties.Settings.Default.Username = tbUsername.Text;
                //Properties.Settings.Default.Password = tbPassword.Text;
                Properties.Settings.Default.Save();
            }
            if ((tbUsername.Text == "Email" && tbPassword.Text == "●●●●●●●●")
                || tbUsername.ForeColor == Color.DarkGray
                || tbPassword.ForeColor == Color.DarkGray)
            {
                labelStatus.Text = "Please enter your email and password";
                labelStatus.ForeColor = Color.Red;
            }
            else
            {
                labelStatus.Text = "Logging in...";
                labelStatus.ForeColor = Color.Black;
            }
            try
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("userLogin", conn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", tbUsername.Text);
                    cmd.Parameters.AddWithValue("@password", tbPassword.Text);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string message = reader["Message"].ToString();
                            if (message == "Login successful")
                            {
                                // Login successful
                                labelStatus.Text = "Login successful! Heading to main window...";
                                labelStatus.ForeColor = Color.Green;
                                this.Hide();
                                Main main = new Main();
                                main.Show();
                            }
                            else
                            {
                                // Invalid username or password
                                labelStatus.Text = "Invalid username or password";
                                labelStatus.ForeColor = Color.Red;
                            }
                        }
                    }
                }
                else
                {
                    labelStatus.Text = "Failed to connect to the server";
                    labelStatus.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                labelStatus.Text = "An error occurred: " + ex.Message;
                labelStatus.ForeColor = Color.Red;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            picHide.BringToFront();
            picShow.SendToBack();
            tbPassword.PasswordChar = '●';
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            picHide.SendToBack();
            picShow.BringToFront();
            tbPassword.PasswordChar = '\0';
        }

        private void labelForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
        }

        private void chkSaveLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSaveLogin.Checked)
            {
                Properties.Settings.Default.Username = tbUsername.Text;
                //Properties.Settings.Default.Password = tbPassword.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Username = "";
                //Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            labelStatus.Text = "";
            version();
            connect();
            tbUsername.Text = Properties.Settings.Default.Username;
            //tbPassword.Text = Properties.Settings.Default.Password;
            if (Properties.Settings.Default.Username != "")
            {
                tbUsername.ForeColor = Color.Black;
                chkSaveLogin.Checked = true;
            }
        }
    }
}
