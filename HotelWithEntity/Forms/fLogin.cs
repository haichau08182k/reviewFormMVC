using HotelWithEntity.Forms;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelWithEntity.Forms
{
    public partial class fLogin : Form
    {
        private IEmployeeService _employeeService;
        public fLogin(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
            InitializeComponent();
        }



        private void fLogin_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            lblMgsError.Visible = false;
        }

        private void picbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void txbUsername_Click(object sender, EventArgs e)
        {
            if (txbUsername.Text == "username")
            {
                txbUsername.Text = "";
            }
        }

        private void txbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void txbUsername_Leave(object sender, EventArgs e)
        {
            if (txbUsername.Text == "")
            {
                txbUsername.Text = "username";
                txbUsername.ForeColor = Color.FromArgb(64, 85, 128);

            }
        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {
            this.txbPassword.PasswordChar = 'ᴏ';
        }

        private void txbPassword_Leave(object sender, EventArgs e)
        {
            if (txbPassword.Text == "")
            {
                txbPassword.Text = "password";
                txbPassword.PasswordChar = '\0';
                txbPassword.ForeColor = Color.FromArgb(64, 85, 128);
            }
        }

        private void txbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();

            }
        }

        private void txbPassword_Click(object sender, EventArgs e)
        {
            if (txbPassword.Text == "password")
            {
                txbPassword.Text = "";
            }
        }

        void MessageError(string mgsEr)
        {
            lblMgsError.Text = mgsEr;
            lblMgsError.Visible = true;
            lblMgsError.ForeColor = Color.FromArgb(253, 102, 93);
        }
        void Login()
        {
            if (txbUsername.Text!="username" && txbPassword.TextLength>0)
            {
                if (txbPassword.Text!="password")
                {
                    if (_employeeService.CheckLogin(Int32.Parse(txbUsername.Text),(txbPassword.Text).ToString())==true)
                    {
                        fMain main = new fMain();
                        this.Hide();
                        main.ShowDialog();
                    }else
                    {
                        MessageError("Bạn đã nhập sai tên đăng nhập hoặc mật khẩu!");
                    }    
                }
                else
                {
                    MessageError("Bạn chưa nhập mật khẩu!");
                }

            }
            else
            {
                MessageError("Bạn chưa nhập tên tài khoản!");
                txbUsername.Focus();
            }    
        }


    }
}
