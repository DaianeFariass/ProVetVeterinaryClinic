using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class LoginForm : Form
    {
        List<Login> logins;
        Connections connection;
        DashBoardForm dash;
        bool logged;
        public LoginForm()
        {
            dash = new DashBoardForm();
            InitializeComponent();
            pnl_Login.Focus();
            connection = new Connections();
            logins = connection.ReadInfoLogin();
            logged = false;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_NewRegistration_Click(object sender, EventArgs e)
        {
            ForgetPasswordForm newform = new ForgetPasswordForm();
            newform.Show();

        }

        private void txt_Login_Click(object sender, EventArgs e)
        {
            txt_Login.BackColor = Color.White;
            pnl_Login.BackColor = Color.White;
            pnl_Password.BackColor = SystemColors.Control;
            txt_Password.BackColor = SystemColors.Control;
        }

        private void txt_Password_Click(object sender, EventArgs e)
        {
            txt_Password.BackColor = Color.White;
            pnl_Password.BackColor = Color.White;
            pnl_Login.BackColor = SystemColors.Control;
            txt_Login.BackColor = SystemColors.Control;
        }
        private void ValidForm()
        {

            if (string.IsNullOrEmpty(txt_Login.Text))
            {
                MessageBox.Show("Insert the email address!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (string.IsNullOrEmpty(txt_Password.Text))
            {
                MessageBox.Show("Insert the password!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void pictureBox_Password_MouseDown(object sender, MouseEventArgs e)
        {
            txt_Password.UseSystemPasswordChar = false;
        }
   

        private void label8_Click(object sender, EventArgs e)
        {

        }
   
        private void btnLogin_Click(object sender, EventArgs e)
        {
            ValidForm();
            foreach (Login log in logins)
            {                
                if (log.Email.Equals(txt_Login.Text) && log.Password.Equals(txt_Password.Text))
                {

                    dash.Show();

                }
                else
                {
                    MessageBox.Show("Email or password incorrect! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

        }
    }
}
