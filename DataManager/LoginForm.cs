using DataManager.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataManager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUser.Text.Trim()))
            {
                MessageHelper.ShowError("用户名不能为空！");
                tbUser.Focus();
                return;
            }
            
            if (string.IsNullOrEmpty(tbPassword.Text.Trim()))
            {
                MessageHelper.ShowError("密码不能为空！");
                tbPassword.Focus();
                return;
            }

            if ("admin".Equals(tbUser.Text) && "admin2018".Equals(tbPassword.Text))
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
                Application.ExitThread();
            }
            else
            {
                MessageHelper.ShowError("用户名密码不正确，请检查！");
                tbPassword.Focus();
                return;
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
