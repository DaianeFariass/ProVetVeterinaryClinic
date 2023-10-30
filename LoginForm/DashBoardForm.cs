using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class DashBoardForm : Form
    {
        List<Customers> customers;
        List<Pet> pets;
        List<Vet> vets;
        List<Appointment> apps;
        List<Bill> bills;
        Connections connection;
        public DashBoardForm()
        {
               
            
            connection = new Connections();
            customers = new List<Customers>();
            pets = new List<Pet>();
            vets = new List<Vet>();
            apps = new List<Appointment>();
            bills = new List<Bill>();
            InitializeComponent();

        }
        /// <summary>
        /// Método para customizar o dashboard inserindo os outros forms dentro do panelDashForm.
        /// </summary>
        private Form childForm = null;
        private void CustomizeDesigner(Form newform)
        {
            

            if (childForm != null)
                childForm.Close();
            childForm = newform;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDashForm.Controls.Add(newform);
            panelDashForm.Tag = newform;
            newform.BringToFront();
            newform.Show();


        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            customers = connection.ReadInfoCustomers();       
            CustomizeDesigner(new CustomerInfoForm(ref customers, ref pets, ref apps));
        }


        private void btn_Pet_Click(object sender, EventArgs e)
        {
            customers= connection.ReadInfoCustomers();
            pets = connection.ReadInfoPet();
            CustomizeDesigner(new PetInfoForm(ref pets, ref customers, ref apps));
        }

        private void btn_Vet_Click(object sender, EventArgs e)
        {
            vets = connection.ReadInfoVet();
            apps = connection.ReadInfoAppointment();
            CustomizeDesigner(new VetInfoForm(ref vets, ref apps));

        }

        private void btn_Appointment_Click(object sender, EventArgs e)
        {
            
            pets = connection.ReadInfoPet();
            vets = connection.ReadInfoVet();
            apps = connection.ReadInfoAppointment();
            CustomizeDesigner(new AppointmentForm(ref apps, ref pets, ref vets));
        }

        private void Bill_Click(object sender, EventArgs e)
        {
            apps = connection.ReadInfoAppointment();
            bills = connection.ReadInfoBill();  
            CustomizeDesigner(new BillForm(ref bills, ref apps));
        }

        private void DashBoardForm_Load(object sender, EventArgs e)
        {
            apps = connection.ReadInfoAppointment();
            pets = connection.ReadInfoPet();
            bills = connection.ReadInfoBill();
            guna2CircleProgressPending.Value = 100;
            guna2CircleProgressBarPets.Value = 100;
            guna2CircleProgressBarVets.Value = 100;
            guna2CircleProgressBarAppointment.Value = 100;
            lbl_Pets.Text = pets.Count.ToString();
            lbl_Pending.Text = apps.Count.ToString();
            lbl_Bills.Text = bills.Count.ToString();
            foreach(Appointment app in apps)
            {           
                lbl_Date.Text = app.Date.ToString();
            }
          

        }

        private void btn_ContactForm_Click(object sender, EventArgs e)
        {
            CustomizeDesigner(new ContactForm(ref customers, ref vets));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}