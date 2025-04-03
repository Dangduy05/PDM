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

namespace PDMcustom
{
    public partial class FormInitialization : Form
    {
        private SqlConnection conn;
        private void connect()
        {
            String cn = @"Data Source=LAPTOP-KVUNFFR7\SQLEXPRESS;Initial Catalog=PDM;Integrated Security=True;";
            try
            {
                conn = new SqlConnection(cn);
                conn.Open();
                wait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }
        private void disconnect()
        {
            if (conn != null)
            {
                conn.Close();
                conn.Dispose();
                conn = null;
            }
        }
        public FormInitialization()
        {
            InitializeComponent();
        }

        private void Form_Initialization_Load(object sender, EventArgs e)
        {
            connect();
        }
        private async void wait()
        {
            await Task.Delay(2000);
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void Form_Initialization_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            //await Task.Run(() => disconnect());
            Application.Exit();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            labelClock.Text = DateTime.Now.ToString("HH:mm");
        }
    }
}
