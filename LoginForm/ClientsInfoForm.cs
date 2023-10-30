using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace LoginForm
{
    public partial class CustomerInfoForm : Form
    {
        List<Customers> _customers;
        List<Pet> _pets;
        List<Appointment> _apps;
        Connections _connect;
        int countCustomer;
     
        public CustomerInfoForm(ref List<Customers> cus, ref List<Pet> pets, ref List<Appointment> apps)
        {

            InitializeComponent();
            _connect = new Connections();
            _customers = cus;
            _pets = pets;
            _apps = apps;
            countCustomer = _customers.Count + 1;
            lbl_ID.Text = countCustomer.ToString();
            PopulateDataGrid();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers();
            try
            {
                customer.IdCustomer = countCustomer;
                customer.NameCustomer = txt_Name.Text;
                customer.Document = txt_Document.Text;
                customer.Address = txt_Address.Text;
                customer.Phone = txt_Phone.Text;
                customer.Email = txt_Email.Text;
                customer.Pets = new List<Pet>();
                customer.Appointments = new List<Appointment>();
                _customers.Add(customer);
                _connect.SaveInfoCustomers(_customers);
                MessageBox.Show("Customer Successfully Added!");
                countCustomer++;
                lbl_ID.Text = countCustomer.ToString();
                PopulateDataGrid();
                CleanControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
          
            
        }
        /// <summary>
        /// Método para limpar as caixas de textos.
        /// </summary>
        private void CleanControls()
        {
            txt_Name.ResetText();
            txt_Document.ResetText();
            txt_Address.ResetText();
            txt_Phone.ResetText();
            txt_Email.ResetText();
            txt_Name.Enabled = true;
            txt_Name.Focus();
            

        }
        /// <summary>
        /// Método que preenche a datagridviewCustomers com os dados da lista _customers.
        /// </summary>
        public void PopulateDataGrid()
        {
            
            dataGridViewCustomers.DataSource = null;
            dataGridViewCustomers.DataSource = _customers;
            for (int i = 0; i < _customers.Count; i++)
            {
                dataGridViewCustomers.Rows[i].Selected = false;

            }
        }
        /// <summary>
        /// Evento que ao clicar na linha da datagridviewcustomers os dados de cada célula retorna separadamente para as labels e txts.
        /// </summary>        
        private void dataGridViewCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {    

                
                var indexRow = e.RowIndex;
                DataGridViewRow row = dataGridViewCustomers.Rows[indexRow];
                lbl_ID.Text = row.Cells[0].Value.ToString();
                txt_Name.Text = row.Cells[1].Value.ToString();
                txt_Document.Text = row.Cells[2].Value.ToString();
                txt_Address.Text = row.Cells[3].Value.ToString();
                txt_Phone.Text = row.Cells[4].Value.ToString();
                txt_Email.Text = row.Cells[5].Value.ToString();
            
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            
            if (dataGridViewCustomers.CurrentCell == null || dataGridViewCustomers.CurrentCell.RowIndex < 0)
            {
                MessageBox.Show("Please select the Customer to Delete!!!");
                return;
            }
            else 
            {
                // Guarda na variável indexrow a linha selecionada corrente.
                var indexRow = dataGridViewCustomers.CurrentCell.RowIndex;
                // Percorre a Lista de customers.
                for (int i = 0; i < _customers.Count; i++)
                {
                    // Se a linha na posição i estiver selecionada é removida da lista e da datagridviewcustomers.
                    if (dataGridViewCustomers.Rows[i].Selected == true)
                    {
                        _customers.RemoveAt(indexRow);
                        _connect.SaveInfoCustomers(_customers);
                        MessageBox.Show("Customer Successfully Deleted!");
                        PopulateDataGrid();
                        CleanControls();

                    }
                   
                }
            }        
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {            
            if (dataGridViewCustomers.CurrentCell == null || dataGridViewCustomers.CurrentCell.RowIndex < 0)
            {
                MessageBox.Show("Please select The Customer to Update!");
                return;
            }
            else
            {
                // Guarda na variável indexrow a linha selecionada corrente.
                var indexRow = dataGridViewCustomers.CurrentCell.RowIndex;
                // Tenta fazer o update da linha na datagridview e na lista.
                try
                {
                    Customers cus = _customers[indexRow];
                    cus.NameCustomer = txt_Name.Text;
                    cus.Document = txt_Document.Text;
                    cus.Address = txt_Address.Text;
                    cus.Phone = txt_Phone.Text;
                    cus.Email = txt_Email.Text;
                    _customers[indexRow] = cus;
                    _connect.SaveInfoCustomers(_customers);
                    MessageBox.Show("Customer Successfully Updated!");
                    PopulateDataGrid();
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
            //  Percorre a lista _customers e verifica se na lista contém o mesmo dados que o usúario digitou na txt_search.
            int key = 0;
            dataGridViewCustomers.Rows[key].Selected = false;
            foreach (Customers cus in _customers)
            {
                dataGridViewCustomers.Rows[key].Selected = false;
                if (cus.IdCustomer.ToString().Equals(txt_Search.Text))
                {
                    dataGridViewCustomers.Rows[key].Selected = true;

                }
                if (cus.NameCustomer.Contains(txt_Search.Text))
                {
                    dataGridViewCustomers.Rows[key].Selected = true;

                }
                if (cus.Document.Contains(txt_Search.Text))
                {
                    dataGridViewCustomers.Rows[key].Selected = true;

                }
                if (cus.Document.Contains(txt_Search.Text))
                {
                    dataGridViewCustomers.Rows[key].Selected = true;

                }
                if (cus.Phone.Contains(txt_Search.Text))
                {
                    dataGridViewCustomers.Rows[key].Selected = true;

                }
                if (cus.Email.Contains(txt_Search.Text))
                {
                    dataGridViewCustomers.Rows[key].Selected = true;

                }
                key++;
            }
        }
        private void btn_NewCustomer_Click(object sender, EventArgs e)
        {
            txt_Name.Enabled = true;
            txt_Name.ResetText();
            txt_Document.ResetText();
            txt_Address.ResetText();
            txt_Phone.ResetText();
            txt_Email.ResetText();
            txt_Name.Focus();
        }
        private void txt_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {   // Verifica se preencheu o campo Name.
                if (txt_Name.Text.Length == 0)
                {

                    MessageBox.Show("Insert the customer Name!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Name.Focus();
                    return;

                }
                // Lê e Valida podendo aceitar todo o tipo de letra.
                if (!Regex.IsMatch(txt_Name.Text, @"^[a-zà-úA-ZÀ-Ú-'\s]+$"))
                {
                    MessageBox.Show("Only letter", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Name.ResetText();
                    txt_Name.Focus();
                    return;
                }
                txt_Document.Enabled = true;
                txt_Document.Focus();
                e.Handled = true;
            }
        }
        private void txt_Address_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {   // Verifica se preencheu o campo Address.
                if (txt_Address.Text.Length == 0)
                {

                    MessageBox.Show("Insert the address Name!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Address.ResetText();
                    txt_Address.Focus();
                    return;
                }
                txt_Phone.Enabled = true;
                txt_Phone.Focus();
                e.Handled = true;
            }

        }
        private void txt_Document_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {   // Verifica se preencheu o campo Document. 
                if (txt_Document.Text.Length == 0)
                {
                    MessageBox.Show("Insert the Document!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Document.Focus();
                    return;
                }
                // Lê e Valida podendo aceitar somente números.
                if (!Regex.IsMatch(txt_Document.Text, @"[0-9]"))
                {
                    MessageBox.Show("Only Numbers", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                    txt_Document.ResetText();
                    txt_Document.Focus();
                    return;
                }
                txt_Address.Enabled = true;
                txt_Address.Focus();
                e.Handled = true;
            }
        }
        private void txt_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {   // Verifica se preencheu o campo Phone.
                if (txt_Phone.Text.Length == 0)
                {
                    MessageBox.Show("Insert the Phone Number!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Phone.ResetText();
                    txt_Phone.Focus();
                    return;
                }
                txt_Email.Enabled = true;
                txt_Email.Focus();
                e.Handled = true;
            }
        }
        private void txt_Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {   // Verifica se preencheu o campo Email.
                if (txt_Email.Text.Length == 0)
                {

                    MessageBox.Show("Insert the customer Email!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Email.ResetText();
                    txt_Email.Focus();
                    return;

                }

            }

        }
        private void ClientsInfo_Load(object sender, EventArgs e)
        {



        }


    }
}





