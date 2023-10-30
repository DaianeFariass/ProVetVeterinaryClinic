
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class ContactForm : Form
    {
        List<Customers> _customers;
        List<Vet> _vets;
        Connections connection;
        public ContactForm(ref List<Customers> cus, ref List<Vet> vets)
        {
            InitializeComponent();
            _customers = cus;
            _vets = vets;
            connection = new Connections();
            FillEmailCustomers();
            FillEmailVets();
            guna2TextBoxFrom.Text = "daiane.farias.26769@formandos.cinel.pt";

        }
        /// <summary>
        /// Método que preenche comboboxcustomers com o Email dos clientes.
        /// </summary>      
        private void FillEmailCustomers()
        {
            _customers = connection.ReadInfoCustomers();
            foreach (Customers customer in _customers)
            {
                guna2ComboBoxCustomers.Items.Add(customer);
                guna2ComboBoxCustomers.DisplayMember = "Email";

            }
        }
        /// <summary>
        ///  Método que preenche comboboxcustomers com o Email dos veterinários.
        /// </summary>  
        private void FillEmailVets()
        {
            _vets = connection.ReadInfoVet();
            foreach (Vet vet in _vets)
            {
                guna2ComboBoxVets.Items.Add(vet);
                guna2ComboBoxVets.DisplayMember = "Email";

            }
        }
        private void btn_Send_Click(object sender, EventArgs e)
        {
            SendEmailCustomer();
            SendEmailVets();

        }
        /// <summary>
        /// Médodo para enviar email com anexo aos customers.
        /// </summary>
        private void SendEmailCustomer()
        {
            Customers cus = (Customers)guna2ComboBoxCustomers.SelectedItem;
            //string mail = guna2ComboBoxCustomers.SelectedItem.ToString();
            //string[] ml = mail.Split('-');

            try
            {
                using (SmtpClient smtp = new SmtpClient())
                {
                    using (MailMessage email = new MailMessage())
                    {
                        // Servidor SMTP
                        smtp.Host = "smtp.office365.com";
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new NetworkCredential("daiane.farias.26769@formandos.cinel.pt", "Cuj29736");
                        smtp.Port = 587;
                        smtp.EnableSsl = true;

                        // Email Message
                        email.From = new MailAddress(guna2TextBoxFrom.Text);
                        email.To.Add(cus.Email);
                        email.Subject = guna2TextBoxSubject.Text;
                        email.IsBodyHtml = false;

                        // Logo
                        var contentID = "Image";
                        var inlineLogo = new System.Net.Mail.Attachment(@"C:\Users\daia_\Desktop\Clinica Veterinária\logo.png");
                        inlineLogo.ContentId = contentID;
                        inlineLogo.ContentDisposition.Inline = true;
                        inlineLogo.ContentDisposition.DispositionType = System.Net.Mime.DispositionTypeNames.Inline;
                        email.Attachments.Add(inlineLogo);
                        email.Body += "<br /><br /><img src=\"cid:" + contentID + "\" height=\"42\" width=\"42\"><br />";
                        email.Body = guna2TextBoxDescription.Text;

                        // Anexo
                        if (lbl_FileName.Text != "")
                        {
                            var attach = lbl_FileName.Text.Split(';');
                            for (int i = 0; i < attach.Count(); i++)
                                email.Attachments.Add(new Attachment(attach[i]));

                        }

                        // Send Email
                        smtp.Send(email);
                        MessageBox.Show("Email sent sucessfuly");


                    }


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// Método para enviar email com anexo aos veterinários.
        /// </summary>
        private void SendEmailVets()
        {
            Vet vet = (Vet)guna2ComboBoxVets.SelectedItem;
            //string mail2 = guna2ComboBoxVets.SelectedItem.ToString();
            //string[] mls = mail2.Split('-');

            try
            {
                using (SmtpClient smtp = new SmtpClient())
                {
                    using (MailMessage email = new MailMessage())
                    {
                        // Servidor SMTP
                        smtp.Host = "smtp.office365.com";
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new NetworkCredential("daiane.farias.26769@formandos.cinel.pt", "Cuj29736");
                        smtp.Port = 587;
                        smtp.EnableSsl = true;

                        // Email Message
                        email.From = new MailAddress(guna2TextBoxFrom.Text);
                        email.To.Add(vet.Email);
                        email.Subject = guna2TextBoxSubject.Text;
                        email.IsBodyHtml = false;

                        // Logo
                        var contentID = "Image";
                        var inlineLogo = new System.Net.Mail.Attachment(@"C:\Users\daia_\Desktop\Clinica Veterinária\logo.png");
                        inlineLogo.ContentId = contentID;
                        inlineLogo.ContentDisposition.Inline = true;
                        inlineLogo.ContentDisposition.DispositionType = System.Net.Mime.DispositionTypeNames.Inline;
                        email.Attachments.Add(inlineLogo);
                        email.Body += "<br /><br /><img src=\"cid:" + contentID + "\" height=\"42\" width=\"42\"><br />";
                        email.Body = guna2TextBoxDescription.Text;

                        // Permite anexar mais de um anexo
                        if (lbl_FileName.Text != "")
                        {
                            var attach = lbl_FileName.Text.Split(';');
                            for (int i = 0; i < attach.Count(); i++)
                                email.Attachments.Add(new Attachment(attach[i]));

                        }

                        // Send Email
                        smtp.Send(email);
                        MessageBox.Show("Email sent sucessfuly");


                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Evento LinkClicked para abrir o file dialog. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var attach = new OpenFileDialog();
            // Permite adicionar mais de um anexo
            attach.Multiselect = true;
            attach.Title = "Attach file";

            if (attach.ShowDialog() == DialogResult.OK)
                for (int i = 0; i < attach.FileNames.Count(); i++)
                    if (i == 0)
                        lbl_FileName.Text = attach.FileNames[i];
                    else
                        lbl_FileName.Text = lbl_FileName.Text + ";" + attach.FileNames[i];

        }
    }
}
