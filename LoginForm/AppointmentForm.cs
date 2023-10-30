using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class AppointmentForm : Form
    {
        List<Appointment> _apps;
        List<Pet> _pets;
        List<Vet> _vets;
        Connections _connection;
        int countApp = 0;
        int indexRow = -1;
        public AppointmentForm(ref List<Appointment> app, ref List<Pet> pet, ref List<Vet> vet)
        {
            InitializeComponent();
            _connection = new Connections();
            _apps = app;
            _pets = pet;
            _vets = vet;
            countApp = app.Count + 1;
            lbl_ID.Text = countApp.ToString();
            AddTime();
        }
        /// <summary>
        /// Método que preenche a comboxNamePet com o nome do Pet e NameVet o nome do veterinário.
        /// </summary>
        private void Fill()
        {

            _pets = _connection.ReadInfoPet();
            foreach (Pet pet in _pets)
            {
                comboBoxNamePet.Items.Add(pet);
                comboBoxNamePet.DisplayMember = "NamePet";

            }
            _vets = _connection.ReadInfoVet();
            foreach (Vet vet in _vets)
            {
                comboBoxNameVet.Items.Add(vet);
                comboBoxNameVet.DisplayMember = "NameVet";
            }

        }
        private void btn_NewAppointment_Click(object sender, EventArgs e)
        {
          
            if (_pets.Count == 0 && _vets.Count == 0)
            {
                MessageBox.Show("Please criate the Pet and Vet first");
                return;

            }
            else
                panel4.Enabled = true;
                CleanControls();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {       
            DateTime date = (DateTime)dateTimePicker1.Value;
            if (date < DateTime.Now)
            {
                MessageBox.Show("This Date is unvailable");
                return;
            }
            string timeTmp = comboBoxTime.SelectedItem.ToString();
            string[] tm = timeTmp.Split(':');

            DateTime newDate = new DateTime(date.Year, date.Month, date.Day, Convert.ToInt32(tm[0]),
                    Convert.ToInt32(tm[1]), 0);
            Vet vet = (Vet)comboBoxNameVet.SelectedItem;
            foreach (Appointment appointment in _apps)
            {

                if (appointment.Date.Equals(newDate) && appointment.Vet.Equals(vet))
                {
                    MessageBox.Show("This time is unvailable");
                    return;
                }
            }
            Appointment app = new Appointment();
            try
            {
               
                app.IdAppointment = countApp;
                string[] time = comboBoxTime.Text.Split(':');
                app.Date = new DateTime(date.Year, date.Month, date.Day, Convert.ToInt32(time[0]),
                    Convert.ToInt32(time[1]), 0);
                app.Pet = new Pet();
                app.Pet = (Pet)comboBoxNamePet.SelectedItem;
                app.Vet = new Vet();
                app.Vet = (Vet)comboBoxNameVet.SelectedItem;
                _apps.Add(app);
                _connection.SaveInfoAppointment(_apps);
                MessageBox.Show("Appointment Successfully Added!");
                SendEmail();
                countApp++;
                lbl_ID.Text = countApp.ToString();
                PopulateDataGridAppointment();
                CleanControls();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
          

        }
        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            Fill();
            PopulateDataGridAppointment();

        }
        /// <summary>
        /// Método para popular a datagridviewappointment.
        /// </summary>
        public void PopulateDataGridAppointment()
        {
            _pets = _connection.ReadInfoPet();
            dataGridViewAppointment.DataSource = null;
            dataGridViewAppointment.DataSource = _apps;
            for (int i = 0; i < _apps.Count; i++)
            {
                dataGridViewAppointment.Rows[i].Selected = false;

            }

        }
        /// <summary>
        /// Evento que ao clicar na linha da datagridviewappointments os dados de cada célula retorna separadamente para as labels e txts.
        /// </summary>        
        private void dataGridViewAppointment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridViewAppointment.Rows[indexRow];
            lbl_ID.Text = row.Cells[0].Value.ToString();         
            comboBoxNamePet.SelectedItem = row.Cells[2].Value;
            comboBoxNameVet.SelectedItem = row.Cells[3].Value;


        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

            if (dataGridViewAppointment.CurrentCell == null || dataGridViewAppointment.CurrentCell.RowIndex < 0)
            {
                MessageBox.Show("Please select the Appointment to Delete!!!");
                return;
                
            }
            else
            {
                indexRow = dataGridViewAppointment.CurrentCell.RowIndex;
                for (int i = 0; i < _apps.Count; i++)
                {

                    if (dataGridViewAppointment.Rows[i].Selected == true)
                    {
                        _apps.RemoveAt(indexRow);
                        _connection.SaveInfoAppointment(_apps);
                        MessageBox.Show("Appointment Successfully Deleted!");
                        PopulateDataGridAppointment();
                        CleanControls();
                    }

                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

            if (dataGridViewAppointment.CurrentCell == null || dataGridViewAppointment.CurrentCell.RowIndex < 0)
            {
                MessageBox.Show("Please select the Appointment to Update!!!");
                
            }
            else
            {
                indexRow = dataGridViewAppointment.CurrentCell.RowIndex;
                try
                {

                    Appointment app = _apps[indexRow];
                    DateTime date = (DateTime)dateTimePicker1.Value;
                    string[] time = comboBoxTime.Text.Split(':');
                    app.Date = new DateTime(date.Year, date.Month, date.Day, Convert.ToInt32(time[0]),
                        Convert.ToInt32(time[1]), 0);
                    app.Pet = (Pet)comboBoxNamePet.SelectedItem;
                    app.Vet = (Vet)comboBoxNameVet.SelectedItem;
                    _apps[indexRow] = app;
                    _connection.SaveInfoAppointment(_apps);
                    MessageBox.Show("Appointment Successfully Updated!");
                    PopulateDataGridAppointment();
                    CleanControls();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            int key = 0;
            dataGridViewAppointment.Rows[key].Selected = false;
            foreach (Appointment apps in _apps)
            {
                dataGridViewAppointment.Rows[key].Selected = false;
                if (apps.IdAppointment.ToString().Contains(txt_Search.Text))
                {
                    dataGridViewAppointment.Rows[key].Selected = true;

                }
                key++;

            }
        }
        /// <summary>
        /// Método para preencher a combobox time com os horários de funcionamento da Clinica.
        /// </summary>
        private void AddTime()
        {
            DateTime time = DateTime.Today;
            for (DateTime _time = time.AddHours(08); _time < time.AddHours(18); _time = _time.AddMinutes(30))
            {
                comboBoxTime.Items.Add(_time.ToShortTimeString());

            }
        }
        private void comboBoxTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strTime_Start = comboBoxTime.SelectedItem.ToString();
            string strTime_End = "18:00";
            DateTime dateTime_Start = Convert.ToDateTime(strTime_Start);
            DateTime dateTime_End = Convert.ToDateTime(strTime_End);

        }
        private void comboBoxNameVet_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vet select = (Vet)comboBoxNameVet.SelectedItem;
            lbl_Room.Text = select.Room.ToString();

        }
        private void comboBoxNamePet_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            Pet select = (Pet)comboBoxNamePet.SelectedItem;
            lbl_NameCustomer.Text = select.Customer.ToString();
            
        }
        /// <summary>
        /// Valida a datatimePicker caso não tenha nada selecionado mosta uma message box informando que a Data e o Horário é requerido.
        /// </summary>
        /// <returns> false </returns>
        private bool ValidDate()
        {
            bool dateOk = false;
            if (dateTimePicker1.Value.Date == null || comboBoxTime.Items == null)
            {
                MessageBox.Show("Date and Time is required");
                return false;
            }

            // Percorre a datagrid comparando se a data e o horário selecionados forem iguais ao que já está adicionado a datagrid a data e o horário não está disponível.
            foreach (DataGridViewRow dgvd in dataGridViewAppointment.Rows)
            {
                if (dgvd.Cells[4].Value == null)
                    continue;
                string[] values = dgvd.Cells[4].Value.ToString().Split(' ');

                if (values[0].Equals(dateTimePicker1.Text))
                {
                    dateOk = true;
                    break;

                }
            }
            bool timeOk = false;
            foreach (DataGridViewRow dgvd in dataGridViewAppointment.Rows)
            {
                if (dgvd.Cells[5].Value == null)
                    continue;
                if (dgvd.Cells[5].Value.ToString().Equals(comboBoxTime.Text))
                {
                    timeOk = true;
                    break;

                }

            }
            if (dateOk && timeOk)
            {
                MessageBox.Show("Date and Time unvailable");
                return false;
            }
            return true;


        }
        /// <summary>
        /// Método para limpar as comboboxs NamePet e NameVet, a label Room e o datetimerpicker.
        /// </summary>
        private void CleanControls()
        {
            comboBoxNamePet.ResetText();
            comboBoxNameVet.ResetText();
            lbl_Room.ResetText();
            dateTimePicker1.ResetText();
            comboBoxTime.ResetText();
            indexRow = -1;

        }

        public void SendEmail()
        {
            Pet pet = (Pet)comboBoxNamePet.SelectedItem;
                 
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
                        email.From = new MailAddress("daiane.farias.26769@formandos.cinel.pt");
                        email.To.Add(pet.Customer.Email);
                        email.Subject = "Consulta agendada!!!";
                        email.IsBodyHtml = false;

                        // Logo
                        var contentID = "Image";
                        var inlineLogo = new System.Net.Mail.Attachment(@"C:\Users\daia_\Desktop\Clinica Veterinária\logo.png");
                        inlineLogo.ContentId = contentID;
                        inlineLogo.ContentDisposition.Inline = true;
                        inlineLogo.ContentDisposition.DispositionType = System.Net.Mime.DispositionTypeNames.Inline;
                        email.Attachments.Add(inlineLogo);
                        email.Body += "<br /><br /><img src=\"cid:" + contentID + "\" height=\"42\" width=\"42\"><br />";
                        email.Body = "Olá querido Cliente!!!";
                        email.Body = "A consulta do seu Pet foi agendada com Sucesso!!!";
                        email.Body = lbl_NameCustomer.Text;
                        email.Body = dateTimePicker1.Value.Date.ToString();
                        email.Body = comboBoxTime.SelectedItem.ToString();



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

        private void comboBoxRoomVet(object sender, EventArgs e)
        {


        }

    }
}


