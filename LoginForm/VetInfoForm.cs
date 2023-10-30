using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class VetInfoForm : Form
    {
        List<Vet> _vets;
        List<Appointment> _apps;
        Connections _connection;
        int countVet = 0;
        int indexRow = -1;
        public VetInfoForm(ref List<Vet> vet, ref List<Appointment> apps)
        {
            InitializeComponent();
            _vets = vet;
            _apps = apps;
            _connection = new Connections();
            countVet = vet.Count + 1;
            lbl_ID.Text = countVet.ToString();
            PopulateDataGridVet();

        }
        /// <summary>
        /// Método que vaalida as texts box e caso esteja nulo mostra uma mensagem para preencher. 
        /// </summary>
        /// <returns></returns>
        private bool ValidaForm()
        {
            bool output = true;
            if (string.IsNullOrEmpty(txt_NameVet.Text))
            {
                MessageBox.Show("Insert the Veterinary Name!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            if (string.IsNullOrEmpty(txt_Address.Text))
            {
                MessageBox.Show("Insert the Veterinary Name!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            if (string.IsNullOrEmpty(txt_Phone.Text))
            {
                MessageBox.Show("Insert the Veterinary Name!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            if (string.IsNullOrEmpty(txt_Email.Text))
            {
                MessageBox.Show("Insert the Veterinary Name!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            if (string.IsNullOrEmpty(txt_Room.Text))
            {
                MessageBox.Show("Insert the Veterinary Name!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }


            return output;
        }
        private bool ValidRoom()
        {
            // Verifica se a txt room está vazia e solicita que preencha o número da sala.
            if (txt_Room.Text == null)
            {
                MessageBox.Show("Number room is required");
                txt_Room.ResetText();
                txt_Room.Focus();
                return false;
            }
            foreach (DataGridViewRow dgvd in dataGridViewVet.Rows)
            {
                //Percorre a datagridviewVet e verifica se a célula na posição 5 é igual ao que o usúario digitou na txt_Room.
                if (dgvd.Cells[5].Value == null)
                    continue;
                if (dgvd.Cells[5].Value.ToString().Equals(txt_Room.Text))
                {
                    MessageBox.Show("The room is ocuppied");
                    txt_Room.ResetText();
                    txt_Room.Focus();
                    return false;
                }

            }
            return true;

        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            _vets = _connection.ReadInfoVet();
            _apps = _connection.ReadInfoAppointment();

            if (!ValidRoom())
                return;

            Vet vet = new Vet();

            try
            {
                vet.IdVet = countVet;
                vet.NameVet = txt_NameVet.Text;
                vet.Address = txt_Address.Text;
                vet.Phone = txt_Phone.Text;
                vet.Email = txt_Email.Text;
                vet.Room = Convert.ToInt32(txt_Room.Text);
                vet.Appointment = new List<Appointment>();
                _vets.Add(vet);
                _connection.SaveInfoVet(_vets);
                MessageBox.Show("Veterinary Successfully Added!");
                countVet++;
                lbl_ID.Text = countVet.ToString();
                PopulateDataGridVet();
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
            txt_NameVet.ResetText();
            txt_Address.ResetText();
            txt_Phone.ResetText();
            txt_Email.ResetText();
            txt_Room.ResetText();
            txt_NameVet.Focus();
            indexRow = -1;
        }     
        /// <summary>
        /// Método que preenche a datagridviewvet com os dados da lista _vets.
        /// </summary>
        public void PopulateDataGridVet()
        {
            dataGridViewVet.DataSource = null;
            dataGridViewVet.DataSource = _vets;

            for (int i = 0; i < _vets.Count; i++)
            {
                dataGridViewVet.Rows[i].Selected = false;

            }
        }
        /// <summary>
        /// Evento que ao clicar na linha da datagridviewcustomers os dados de cada célula retornam separadamente para as labels e txts.
        /// </summary>        
        private void dataGridViewVet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridViewVet.Rows[indexRow];
            lbl_ID.Text = row.Cells[0].Value.ToString();
            txt_NameVet.Text = row.Cells[1].Value.ToString();
            txt_Address.Text = row.Cells[2].Value.ToString();
            txt_Phone.Text = row.Cells[3].Value.ToString();
            txt_Email.Text = row.Cells[4].Value.ToString();
            txt_Room.Text = row.Cells[5].Value.ToString();
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {

            if (dataGridViewVet.CurrentCell == null || dataGridViewVet.CurrentCell.RowIndex < 0)                
            {
                MessageBox.Show("Please select the Veterinary to Delete!!!");
                return;
            }
            else
            {
                // Guarda na variável indexrow a linha selecionada corrente.
                indexRow = dataGridViewVet.CurrentCell.RowIndex;
                // Percorre a Lista de vets.
                for (int i = 0; i < _vets.Count; i++)
                {
                    // Se a linha na posição i estiver selecionada é removida da lista e da datagridviewcustomers.
                    if (dataGridViewVet.Rows[i].Selected == true)
                    {
                        _vets.RemoveAt(indexRow);
                        _connection.SaveInfoVet(_vets);
                        MessageBox.Show("Veterinary Successfully Deleted!");
                        PopulateDataGridVet();
                        CleanControls();
                    }
                }
            }
                       
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {

            if (dataGridViewVet.CurrentCell == null || dataGridViewVet.CurrentCell.RowIndex < 0)
            {
                MessageBox.Show("Please select The Veterinary to Update!!!");
                return;
               
            }
            else
            {
                // Guarda na variável indexrow a linha selecionada corrente.
                indexRow = dataGridViewVet.CurrentCell.RowIndex;
                // Tenta fazer o update da linha na datagridview e na lista.
                try
                {
                    Vet vet = _vets[indexRow];
                    vet.NameVet = txt_NameVet.Text;
                    vet.Address = txt_Address.Text;
                    vet.Phone = txt_Phone.Text;
                    vet.Email = txt_Email.Text;
                    vet.Room = Convert.ToInt32(txt_Room.Text);
                    _vets[indexRow] = vet;
                    _connection.SaveInfoVet(_vets);
                    MessageBox.Show("Vet Successfully Updated!");
                    PopulateDataGridVet();
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
            //  Percorre a lista _vets e verifica se na lista contém o mesmo dados que o usúario digitou na txt_search.
            int key = 0;
            dataGridViewVet.Rows[key].Selected = false;
            foreach (Vet vet in _vets)
            {
                dataGridViewVet.Rows[key].Selected = false;
                if (vet.IdVet.ToString().Contains(txt_Search.Text))
                {
                    dataGridViewVet.Rows[key].Selected = true;

                }
                if (vet.NameVet.Contains(txt_Search.Text))
                {
                    dataGridViewVet.Rows[key].Selected = true;

                }
                if (vet.Address.Contains(txt_Search.Text))
                {
                    dataGridViewVet.Rows[key].Selected = true;

                }
                if (vet.Phone.Contains(txt_Search.Text))
                {
                    dataGridViewVet.Rows[key].Selected = true;

                }
                if (vet.Email.Contains(txt_Search.Text))
                {
                    dataGridViewVet.Rows[key].Selected = true;

                }
                if (vet.Room.Equals(txt_Search.Text))
                {
                    dataGridViewVet.Rows[key].Selected = true;
                }
                key++;
            }
        }

        private void txt_NameVet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {   // Verifica se preencheu o campo Name.
                if (txt_NameVet.Text.Length == 0)
                {

                    MessageBox.Show("Insert the Vet Name!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_NameVet.Focus();
                    return;

                }
                // Lê e Valida podendo aceitar somente letras mas de diversos tipos.
                if (!Regex.IsMatch(txt_NameVet.Text, @"^[a-zà-úA-ZÀ-Ú-'\s]+$"))
                {
                    MessageBox.Show("Only letter", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_NameVet.ResetText();
                    txt_NameVet.Focus();
                    return;
                }
                txt_Address.Enabled = true;
                txt_Address.Focus();
                e.Handled = true;

            }

        }

        private void txt_Address_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {   // Verifica se preencheu o campo Address.
                if (txt_Address.Text.Length == 0)
                {

                    MessageBox.Show("Insert the Vet address!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Address.ResetText();
                    txt_Address.Focus();
                    return;

                }
                txt_Phone.Enabled = true;
                txt_Phone.Focus();
                e.Handled = true;

            }
        }
        private void txt_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {   // Verifica se preencheu o campo phone.
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

                    MessageBox.Show("Insert the Vet Email!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Email.ResetText();
                    txt_Email.Focus();
                    return;
                }
                txt_Room.Enabled = true;
                txt_Room.Focus();
                e.Handled = true;

            }

        }

        private void txt_Room_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {   // Verifica se preencheu o campo Room.
                if (txt_Room.Text.Length == 0)
                {

                    MessageBox.Show("Insert the Vet Room!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Room.ResetText();
                    txt_Room.Focus();
                    return;

                }
                // Lê e Valida o campo Room podendo aceitar somente números. 
                if (!Regex.IsMatch(txt_Room.Text, @"[0-9]"))
                {

                    MessageBox.Show("Entrada Inválida...");
                    txt_Room.ResetText();
                    txt_Room.Focus();
                    return;

                }

            }

        }

        private void btn_NewCustomer_Click(object sender, EventArgs e)
        {
            txt_NameVet.Enabled = true;
            CleanControls();
        }
        private void VetInfoForm_Load(object sender, EventArgs e)
        {



        }
    }
}

