using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDMcustom
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }
        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }
        static Regex validate_emailaddress = email_validation();
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
                tbUsername.ForeColor = Color.Silver;
            }
        }

        private void btnReturnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SendVerificationCode_button_Click(object sender, EventArgs e)
        {
            if (!validate_emailaddress.IsMatch(tbUsername.Text))
            {
                labelError.Text = "* Email không hợp lệ.";
            }
            else
            {
                labelError.Text = "Vui long đợi trong giây lát";
                panelForgotPassword.Hide();
                panelVerifyCode.Show();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //nothing
        }

        private void tbVerifyCode_Enter(object sender, EventArgs e)
        {
            if (tbVerifyCode.Text == "NHẬP MÃ XÁC NHẬN")
            {
                tbVerifyCode.Text = "";
                tbVerifyCode.ForeColor = Color.Black;
            }
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            panelVerifyCode.Hide();
            labelError.Text = "";
        }

        private void tbVerifyCode_Leave(object sender, EventArgs e)
        {
            if (tbVerifyCode.Text == "")
            {
                tbVerifyCode.Text = "NHẬP MÃ XÁC NHẬN";
                tbVerifyCode.ForeColor = Color.Silver;
            }
        }

        private void Return_FP_Click(object sender, EventArgs e)
        {
            panelVerifyCode.Hide();
            panelForgotPassword.Show();
        }

        private void btnReturnFP_Click(object sender, EventArgs e)
        {
            panelVerifyCode.Hide();
            panelForgotPassword.Show();
        }

    }
}
