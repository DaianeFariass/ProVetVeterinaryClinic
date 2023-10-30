namespace LoginForm
{
    partial class ForgetPasswordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.pnl_Password = new System.Windows.Forms.Panel();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.pictureBox_Password = new System.Windows.Forms.PictureBox();
            this.pnl_Login = new System.Windows.Forms.Panel();
            this.txt_Login = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_UserRegistered = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_Password.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Password)).BeginInit();
            this.pnl_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btn_Close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 500);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_UserRegistered);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btn_Save);
            this.panel1.Controls.Add(this.pnl_Password);
            this.panel1.Controls.Add(this.pnl_Login);
            this.panel1.Location = new System.Drawing.Point(59, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 461);
            this.panel1.TabIndex = 4;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.White;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_Save.Location = new System.Drawing.Point(26, 395);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(148, 35);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "New Register";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // pnl_Password
            // 
            this.pnl_Password.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_Password.Controls.Add(this.txt_Password);
            this.pnl_Password.Controls.Add(this.pictureBox_Password);
            this.pnl_Password.Location = new System.Drawing.Point(0, 248);
            this.pnl_Password.Name = "pnl_Password";
            this.pnl_Password.Size = new System.Drawing.Size(475, 45);
            this.pnl_Password.TabIndex = 1;
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Password.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txt_Password.Location = new System.Drawing.Point(55, 14);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(370, 21);
            this.txt_Password.TabIndex = 2;
            this.txt_Password.Click += new System.EventHandler(this.txt_Password2_Click);
            // 
            // pictureBox_Password
            // 
            this.pictureBox_Password.Image = global::LoginForm.Properties.Resources.user__1_;
            this.pictureBox_Password.Location = new System.Drawing.Point(15, 11);
            this.pictureBox_Password.Name = "pictureBox_Password";
            this.pictureBox_Password.Size = new System.Drawing.Size(24, 24);
            this.pictureBox_Password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Password.TabIndex = 0;
            this.pictureBox_Password.TabStop = false;
            // 
            // pnl_Login
            // 
            this.pnl_Login.BackColor = System.Drawing.Color.White;
            this.pnl_Login.Controls.Add(this.txt_Login);
            this.pnl_Login.Controls.Add(this.pictureBox2);
            this.pnl_Login.Location = new System.Drawing.Point(0, 185);
            this.pnl_Login.Name = "pnl_Login";
            this.pnl_Login.Size = new System.Drawing.Size(475, 45);
            this.pnl_Login.TabIndex = 1;
            // 
            // txt_Login
            // 
            this.txt_Login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txt_Login.Location = new System.Drawing.Point(55, 15);
            this.txt_Login.Name = "txt_Login";
            this.txt_Login.Size = new System.Drawing.Size(370, 25);
            this.txt_Login.TabIndex = 1;
            this.txt_Login.Click += new System.EventHandler(this.txt_newLogin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LoginForm.Properties.Resources.user__2_;
            this.pictureBox2.Location = new System.Drawing.Point(15, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_Close.Location = new System.Drawing.Point(560, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(40, 40);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label6.Location = new System.Drawing.Point(121, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 33);
            this.label6.TabIndex = 5;
            this.label6.Text = "New Registration";
            // 
            // btn_UserRegistered
            // 
            this.btn_UserRegistered.BackColor = System.Drawing.Color.White;
            this.btn_UserRegistered.FlatAppearance.BorderSize = 0;
            this.btn_UserRegistered.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UserRegistered.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UserRegistered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_UserRegistered.Location = new System.Drawing.Point(228, 395);
            this.btn_UserRegistered.Name = "btn_UserRegistered";
            this.btn_UserRegistered.Size = new System.Drawing.Size(225, 35);
            this.btn_UserRegistered.TabIndex = 6;
            this.btn_UserRegistered.Text = "I\'m already registered!";
            this.btn_UserRegistered.UseVisualStyleBackColor = false;
            this.btn_UserRegistered.Click += new System.EventHandler(this.btn_UserRegistered_Click);
            // 
            // ForgetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ForgetPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetPasswordForm";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_Password.ResumeLayout(false);
            this.pnl_Password.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Password)).EndInit();
            this.pnl_Login.ResumeLayout(false);
            this.pnl_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Panel pnl_Password;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.PictureBox pictureBox_Password;
        private System.Windows.Forms.Panel pnl_Login;
        private System.Windows.Forms.TextBox txt_Login;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_UserRegistered;
    }
}