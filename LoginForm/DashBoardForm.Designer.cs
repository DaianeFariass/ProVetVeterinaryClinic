namespace LoginForm
{
    partial class DashBoardForm
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.btn_ContactForm = new System.Windows.Forms.Button();
            this.Bill = new System.Windows.Forms.Button();
            this.btn_Appointment = new System.Windows.Forms.Button();
            this.btn_Vet = new System.Windows.Forms.Button();
            this.btn_Pet = new System.Windows.Forms.Button();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelDashForm = new System.Windows.Forms.Panel();
            this.guna2CircleProgressBarAppointment = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Bills = new System.Windows.Forms.Label();
            this.guna2CircleProgressBarPets = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Pets = new System.Windows.Forms.Label();
            this.guna2CircleProgressBarVets = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2CircleProgressPending = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Pending = new System.Windows.Forms.Label();
            this.panelSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelDashForm.SuspendLayout();
            this.guna2CircleProgressBarAppointment.SuspendLayout();
            this.guna2CircleProgressBarPets.SuspendLayout();
            this.guna2CircleProgressBarVets.SuspendLayout();
            this.guna2CircleProgressPending.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelSideMenu.Controls.Add(this.pictureBox1);
            this.panelSideMenu.Controls.Add(this.button7);
            this.panelSideMenu.Controls.Add(this.btn_ContactForm);
            this.panelSideMenu.Controls.Add(this.Bill);
            this.panelSideMenu.Controls.Add(this.btn_Appointment);
            this.panelSideMenu.Controls.Add(this.btn_Vet);
            this.panelSideMenu.Controls.Add(this.btn_Pet);
            this.panelSideMenu.Controls.Add(this.btn_Customer);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 660);
            this.panelSideMenu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pictureBox1.Image = global::LoginForm.Properties.Resources.veterinary;
            this.pictureBox1.Location = new System.Drawing.Point(28, 447);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(150, 625);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(97, 32);
            this.button7.TabIndex = 1;
            this.button7.Text = "Logout";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_ContactForm
            // 
            this.btn_ContactForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ContactForm.Location = new System.Drawing.Point(0, 387);
            this.btn_ContactForm.Name = "btn_ContactForm";
            this.btn_ContactForm.Size = new System.Drawing.Size(250, 45);
            this.btn_ContactForm.TabIndex = 1;
            this.btn_ContactForm.Text = "Contact Form";
            this.btn_ContactForm.UseVisualStyleBackColor = true;
            this.btn_ContactForm.Click += new System.EventHandler(this.btn_ContactForm_Click);
            // 
            // Bill
            // 
            this.Bill.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bill.Location = new System.Drawing.Point(0, 342);
            this.Bill.Name = "Bill";
            this.Bill.Size = new System.Drawing.Size(250, 45);
            this.Bill.TabIndex = 1;
            this.Bill.Text = "Billings";
            this.Bill.UseVisualStyleBackColor = true;
            this.Bill.Click += new System.EventHandler(this.Bill_Click);
            // 
            // btn_Appointment
            // 
            this.btn_Appointment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Appointment.Location = new System.Drawing.Point(0, 297);
            this.btn_Appointment.Name = "btn_Appointment";
            this.btn_Appointment.Size = new System.Drawing.Size(250, 45);
            this.btn_Appointment.TabIndex = 1;
            this.btn_Appointment.Text = "Appointment";
            this.btn_Appointment.UseVisualStyleBackColor = true;
            this.btn_Appointment.Click += new System.EventHandler(this.btn_Appointment_Click);
            // 
            // btn_Vet
            // 
            this.btn_Vet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Vet.Location = new System.Drawing.Point(0, 252);
            this.btn_Vet.Name = "btn_Vet";
            this.btn_Vet.Size = new System.Drawing.Size(250, 45);
            this.btn_Vet.TabIndex = 1;
            this.btn_Vet.Text = "Veterinary";
            this.btn_Vet.UseVisualStyleBackColor = true;
            this.btn_Vet.Click += new System.EventHandler(this.btn_Vet_Click);
            // 
            // btn_Pet
            // 
            this.btn_Pet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Pet.Location = new System.Drawing.Point(0, 207);
            this.btn_Pet.Name = "btn_Pet";
            this.btn_Pet.Size = new System.Drawing.Size(250, 45);
            this.btn_Pet.TabIndex = 1;
            this.btn_Pet.Text = "Pet";
            this.btn_Pet.UseVisualStyleBackColor = true;
            this.btn_Pet.Click += new System.EventHandler(this.btn_Pet_Click);
            // 
            // btn_Customer
            // 
            this.btn_Customer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Customer.Location = new System.Drawing.Point(0, 162);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(250, 45);
            this.btn_Customer.TabIndex = 1;
            this.btn_Customer.Text = "Customer";
            this.btn_Customer.UseVisualStyleBackColor = true;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelLogo.Controls.Add(this.label6);
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 162);
            this.panelLogo.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(140, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 33);
            this.label6.TabIndex = 2;
            this.label6.Text = "ProVet";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LoginForm.Properties.Resources.d1209956586417_Y3JvcCw0MjU5LDMzMzMsMCwyNDE;
            this.pictureBox2.Location = new System.Drawing.Point(14, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panelDashForm
            // 
            this.panelDashForm.Controls.Add(this.guna2CircleProgressBarAppointment);
            this.panelDashForm.Controls.Add(this.guna2CircleProgressBarPets);
            this.panelDashForm.Controls.Add(this.guna2CircleProgressBarVets);
            this.panelDashForm.Controls.Add(this.guna2CircleProgressPending);
            this.panelDashForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashForm.Location = new System.Drawing.Point(250, 0);
            this.panelDashForm.Name = "panelDashForm";
            this.panelDashForm.Size = new System.Drawing.Size(732, 660);
            this.panelDashForm.TabIndex = 1;
            // 
            // guna2CircleProgressBarAppointment
            // 
            this.guna2CircleProgressBarAppointment.Controls.Add(this.label2);
            this.guna2CircleProgressBarAppointment.Controls.Add(this.lbl_Bills);
            this.guna2CircleProgressBarAppointment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.guna2CircleProgressBarAppointment.FillThickness = 18;
            this.guna2CircleProgressBarAppointment.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2CircleProgressBarAppointment.ForeColor = System.Drawing.Color.White;
            this.guna2CircleProgressBarAppointment.Location = new System.Drawing.Point(408, 348);
            this.guna2CircleProgressBarAppointment.Minimum = 0;
            this.guna2CircleProgressBarAppointment.Name = "guna2CircleProgressBarAppointment";
            this.guna2CircleProgressBarAppointment.ProgressColor = System.Drawing.Color.MediumSlateBlue;
            this.guna2CircleProgressBarAppointment.ProgressColor2 = System.Drawing.Color.MediumSlateBlue;
            this.guna2CircleProgressBarAppointment.ProgressThickness = 18;
            this.guna2CircleProgressBarAppointment.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBarAppointment.Size = new System.Drawing.Size(301, 301);
            this.guna2CircleProgressBarAppointment.TabIndex = 1;
            this.guna2CircleProgressBarAppointment.Text = "guna2CircleProgressBar1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Location = new System.Drawing.Point(115, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bills";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Bills
            // 
            this.lbl_Bills.AutoSize = true;
            this.lbl_Bills.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bills.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lbl_Bills.Location = new System.Drawing.Point(105, 155);
            this.lbl_Bills.Name = "lbl_Bills";
            this.lbl_Bills.Size = new System.Drawing.Size(31, 34);
            this.lbl_Bills.TabIndex = 0;
            this.lbl_Bills.Text = "0";
            this.lbl_Bills.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2CircleProgressBarPets
            // 
            this.guna2CircleProgressBarPets.Controls.Add(this.label4);
            this.guna2CircleProgressBarPets.Controls.Add(this.lbl_Pets);
            this.guna2CircleProgressBarPets.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.guna2CircleProgressBarPets.FillThickness = 18;
            this.guna2CircleProgressBarPets.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2CircleProgressBarPets.ForeColor = System.Drawing.Color.White;
            this.guna2CircleProgressBarPets.Location = new System.Drawing.Point(408, 41);
            this.guna2CircleProgressBarPets.Minimum = 0;
            this.guna2CircleProgressBarPets.Name = "guna2CircleProgressBarPets";
            this.guna2CircleProgressBarPets.ProgressColor = System.Drawing.Color.CornflowerBlue;
            this.guna2CircleProgressBarPets.ProgressColor2 = System.Drawing.Color.CornflowerBlue;
            this.guna2CircleProgressBarPets.ProgressThickness = 18;
            this.guna2CircleProgressBarPets.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBarPets.Size = new System.Drawing.Size(301, 301);
            this.guna2CircleProgressBarPets.TabIndex = 1;
            this.guna2CircleProgressBarPets.Text = "guna2CircleProgressBar1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label4.Location = new System.Drawing.Point(105, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 34);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pets";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Pets
            // 
            this.lbl_Pets.AutoSize = true;
            this.lbl_Pets.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lbl_Pets.Location = new System.Drawing.Point(94, 156);
            this.lbl_Pets.Name = "lbl_Pets";
            this.lbl_Pets.Size = new System.Drawing.Size(31, 34);
            this.lbl_Pets.TabIndex = 0;
            this.lbl_Pets.Text = "0";
            this.lbl_Pets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2CircleProgressBarVets
            // 
            this.guna2CircleProgressBarVets.Controls.Add(this.label5);
            this.guna2CircleProgressBarVets.Controls.Add(this.lbl_Date);
            this.guna2CircleProgressBarVets.Controls.Add(this.label3);
            this.guna2CircleProgressBarVets.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.guna2CircleProgressBarVets.FillThickness = 18;
            this.guna2CircleProgressBarVets.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2CircleProgressBarVets.ForeColor = System.Drawing.Color.White;
            this.guna2CircleProgressBarVets.Location = new System.Drawing.Point(36, 348);
            this.guna2CircleProgressBarVets.Minimum = 0;
            this.guna2CircleProgressBarVets.Name = "guna2CircleProgressBarVets";
            this.guna2CircleProgressBarVets.ProgressColor = System.Drawing.Color.DarkTurquoise;
            this.guna2CircleProgressBarVets.ProgressColor2 = System.Drawing.Color.DarkTurquoise;
            this.guna2CircleProgressBarVets.ProgressThickness = 18;
            this.guna2CircleProgressBarVets.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBarVets.Size = new System.Drawing.Size(301, 301);
            this.guna2CircleProgressBarVets.TabIndex = 1;
            this.guna2CircleProgressBarVets.Text = "guna2CircleProgressBar1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label5.Location = new System.Drawing.Point(84, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 34);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date App";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lbl_Date.Location = new System.Drawing.Point(36, 170);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(31, 34);
            this.lbl_Date.TabIndex = 0;
            this.lbl_Date.Text = "0";
            this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label3.Location = new System.Drawing.Point(366, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 34);
            this.label3.TabIndex = 0;
            this.label3.Text = "label1";
            // 
            // guna2CircleProgressPending
            // 
            this.guna2CircleProgressPending.Controls.Add(this.label1);
            this.guna2CircleProgressPending.Controls.Add(this.lbl_Pending);
            this.guna2CircleProgressPending.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.guna2CircleProgressPending.FillThickness = 18;
            this.guna2CircleProgressPending.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2CircleProgressPending.ForeColor = System.Drawing.Color.White;
            this.guna2CircleProgressPending.Location = new System.Drawing.Point(36, 41);
            this.guna2CircleProgressPending.Minimum = 0;
            this.guna2CircleProgressPending.Name = "guna2CircleProgressPending";
            this.guna2CircleProgressPending.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2CircleProgressPending.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2CircleProgressPending.ProgressThickness = 18;
            this.guna2CircleProgressPending.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressPending.Size = new System.Drawing.Size(301, 301);
            this.guna2CircleProgressPending.TabIndex = 1;
            this.guna2CircleProgressPending.Text = "guna2CircleProgressBar1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(41, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Appointments";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Pending
            // 
            this.lbl_Pending.AutoSize = true;
            this.lbl_Pending.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pending.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lbl_Pending.Location = new System.Drawing.Point(98, 166);
            this.lbl_Pending.Name = "lbl_Pending";
            this.lbl_Pending.Size = new System.Drawing.Size(31, 34);
            this.lbl_Pending.TabIndex = 0;
            this.lbl_Pending.Text = "0";
            this.lbl_Pending.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 660);
            this.Controls.Add(this.panelDashForm);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DashBoardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoardForm";
            this.Load += new System.EventHandler(this.DashBoardForm_Load);
            this.panelSideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelDashForm.ResumeLayout(false);
            this.guna2CircleProgressBarAppointment.ResumeLayout(false);
            this.guna2CircleProgressBarAppointment.PerformLayout();
            this.guna2CircleProgressBarPets.ResumeLayout(false);
            this.guna2CircleProgressBarPets.PerformLayout();
            this.guna2CircleProgressBarVets.ResumeLayout(false);
            this.guna2CircleProgressBarVets.PerformLayout();
            this.guna2CircleProgressPending.ResumeLayout(false);
            this.guna2CircleProgressPending.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btn_ContactForm;
        private System.Windows.Forms.Button Bill;
        private System.Windows.Forms.Button btn_Appointment;
        private System.Windows.Forms.Button btn_Vet;
        private System.Windows.Forms.Button btn_Pet;
        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelDashForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressPending;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBarAppointment;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBarPets;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBarVets;
        private System.Windows.Forms.Label lbl_Bills;
        private System.Windows.Forms.Label lbl_Pets;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Pending;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
    }
}