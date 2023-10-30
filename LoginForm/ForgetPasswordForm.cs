using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class ForgetPasswordForm : Form
    {
        List<Login> _logins;
        Connections connection;
        public ForgetPasswordForm()
        {
            InitializeComponent();
            _logins= new List<Login>();
            connection= new Connections();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            // Cadastra os dados do login e adiciona a lista _logins e salva na txt.
            Login login;
            if(ValidForm())
            {
                login = new Login
                {
                    Email = txt_Login.Text,
                    Password = txt_Password.Text,
                };
                _logins.Add(login);
                connection.SaveInfoLogin(_logins);
                MessageBox.Show("Login Sucessfully Registered");
              
                
            }
            else
            {
                MessageBox.Show("Please fill in the fields correctly", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void btn_UserRegistered_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();       
            loginForm.Show();
           

        }
        /// <summary>
        /// Valida as caixas de texto login e password caso estejam vazia mostra uma mensagem de texto de erro.
        /// </summary>
        /// <returns>bool output</returns>
        private bool ValidForm()
        {
            bool output = true;
            if (string.IsNullOrEmpty(txt_Login.Text))
            {
                MessageBox.Show("Insert the email address!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            if (string.IsNullOrEmpty(txt_Password.Text))
            {
                MessageBox.Show("Insert the password!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            return output;

        }

        private void txt_newLogin_Click(object sender, EventArgs e)
        {
            txt_Login.BackColor = Color.White;
            pnl_Login.BackColor = Color.White;
            pnl_Password.BackColor = SystemColors.Control;
            txt_Password.BackColor = SystemColors.Control;
         
        }

        private void txt_Password2_Click(object sender, EventArgs e)
        {
            txt_Password.BackColor = Color.White;
            pnl_Password.BackColor = Color.White;
            pnl_Login.BackColor = SystemColors.Control;
            txt_Login.BackColor = SystemColors.Control;
     

        }

        private void txt_newPassword_Click(object sender, EventArgs e)
        {
        
            pnl_Login.BackColor = SystemColors.Control;
            txt_Login.BackColor = SystemColors.Control;
            pnl_Password.BackColor = SystemColors.Control;
            txt_Password.BackColor = SystemColors.Control;

        }
    

    }
}
