using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class PetInfoForm : Form
    {
        List<Customers> _customers;
        List<Pet> _pets;
        List<Appointment> _appointments;
        Connections _connect;
        int countPets = 0;
        int indexRow = -1;
        public PetInfoForm(ref List<Pet> pet, ref List<Customers> cus, ref List<Appointment> apps)
        {
            InitializeComponent();
            _connect = new Connections();
            _customers = cus;
            _pets = pet;
            _appointments = apps;
            countPets = _pets.Count + 1;
            lbl_ID.Text = countPets.ToString();
            PopulateDataGridPet();
        }
        /// <summary>
        /// Método que preenche a combobox com o nome dos customers.
        /// </summary>
        private void FillCustomer()
        {
            foreach (Customers customer in _customers)
            {
                comboBox_NameCustomer.Items.Add(customer);
                comboBox_NameCustomer.DisplayMember = "NameCustomer";
            }

        }
        /// <summary>
        /// Método que preenche a combobox com os tipos de animais.
        /// </summary>
        private void FillType()
        {
            comboBox_Type.Items.Add("Cão");
            comboBox_Type.Items.Add("Gato");
            comboBox_Type.Items.Add("Roedores");
            comboBox_Type.Items.Add("Coelho");
        }
        /// <summary>
        /// Método que preenche a combobox com as Espécies dos animais.
        /// </summary>
        private void FillSpecie()
        {
            comboBox_Specie.Items.Add("Akita");
            comboBox_Specie.Items.Add("Boxer");
            comboBox_Specie.Items.Add("Collie");
            comboBox_Specie.Items.Add("Dálmata");
            comboBox_Specie.Items.Add("Angorá");
            comboBox_Specie.Items.Add("Burmes");
            comboBox_Specie.Items.Add("Persa");
            comboBox_Specie.Items.Add("Siamês");
            comboBox_Specie.Items.Add("Hamster");
            comboBox_Specie.Items.Add("Porquinho da Índia");
            comboBox_Specie.Items.Add("Chinchilla");
            comboBox_Specie.Items.Add("Cherbil");
            comboBox_Specie.Items.Add("Rex");
            comboBox_Specie.Items.Add("Rolland");
            comboBox_Specie.Items.Add("Anão Holandês");
            comboBox_Specie.Items.Add("Cabeça de Leão");

        }
        private void PetInfoForm_Load(object sender, EventArgs e)
        {
            FillCustomer();
            FillSpecie();
            FillType();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            // Valida se a data atual que foi selecionada na datetimepicker é maior que o dia de hoje não podendo aceitar datas futuras.
            DateTime date = (DateTime)dateTimePicker_Pet.Value;
            if (date > DateTime.Now)
            {
                MessageBox.Show("This Date is unvailable");
                return;
            }
            Pet pet = new Pet();
            try
            {
                pet.IdPet = countPets;
                pet.NamePet = txt_NamePet.Text;
                pet.Dob = dateTimePicker_Pet.Value.Date;
                pet.Type = comboBox_Type.SelectedItem.ToString();
                pet.Specie = comboBox_Specie.SelectedItem.ToString();
                pet.Gender = comboBox_Sex.SelectedItem.ToString();
                pet.Customer = new Customers();
                pet.Customer = (Customers)comboBox_NameCustomer.SelectedItem;
                _pets.Add(pet);
                _connect.SaveInfoPet(_pets);
                MessageBox.Show("Pet Successfully Added!");
                countPets++;
                lbl_ID.Text = countPets.ToString();
                PopulateDataGridPet();
                CleanControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
       

        }
        /// <summary>
        /// Método que preenche a datagrid com os dados dos Pets que estão na lista.
        /// </summary>
        public void PopulateDataGridPet()
        {
            dataGridViewPet.DataSource = null;
            dataGridViewPet.DataSource = _pets;
            for (int i = 0; i < _pets.Count; i++)
            {
                dataGridViewPet.Rows[i].Selected = false;

            }
        }
        /// <summary>
        /// Evento que ao clicar na linha da datagridviewpet os dados de cada célula retornam separadamente para as labels e txts.
        /// </summary>        
        private void dataGridViewPet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridViewPet.Rows[indexRow];
            lbl_ID.Text = row.Cells[0].Value.ToString();
            txt_NamePet.Text = row.Cells[1].Value.ToString();
            dateTimePicker_Pet.Text = row.Cells[2].Value.ToString();
            comboBox_Type.SelectedItem = row.Cells[3].Value.ToString();
            comboBox_Specie.SelectedItem = row.Cells[4].Value.ToString();
            comboBox_Sex.SelectedItem = row.Cells[5].Value.ToString();
            comboBox_NameCustomer.Text = row.Cells[6].Value.ToString();
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
         
            if (dataGridViewPet.CurrentCell == null || dataGridViewPet.CurrentCell.RowIndex < 0)
            {
                MessageBox.Show("Please select the Pet to Delete!!!");
                return;

            }
            else
            {
                // Guarda na variável indexrow a linha selecionada corrente.
                indexRow = dataGridViewPet.CurrentCell.RowIndex;
                // Percorre a Lista de pets.
                for (int i = 0; i < _pets.Count; i++)
                {
                    // Se a linha na posição i estiver selecionada é removida da lista e da datagridview.
                    if (dataGridViewPet.Rows[i].Selected == true)
                    {
                        _pets.RemoveAt(indexRow);
                        _connect.SaveInfoPet(_pets);
                        MessageBox.Show("Pet Successfully Deleted!");
                        PopulateDataGridPet();
                        CleanControls();
                    }

                }
            }

          
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
           
            if (dataGridViewPet.CurrentCell == null || dataGridViewPet.CurrentCell.RowIndex < 0)
            {
                MessageBox.Show("Please select the Pet to Update!!!");
                return;
            }
            else
            {
                // Guarda na variável indexrow a linha selecionada corrente.
                indexRow = dataGridViewPet.CurrentCell.RowIndex;
                try
                {
                    // Tenta fazer o update da linha na datagridview e na lista.
                    Pet pet = _pets[indexRow];
                    pet.NamePet = txt_NamePet.Text;
                    pet.Dob = dateTimePicker_Pet.Value.Date;
                    pet.Type = comboBox_Type.SelectedItem.ToString();
                    pet.Specie = comboBox_Specie.SelectedItem.ToString();
                    pet.Gender = comboBox_Sex.SelectedItem.ToString();
                    _pets[indexRow] = pet;
                    _connect.SaveInfoPet(_pets);
                    MessageBox.Show("Pet Successfully Updated!");
                    PopulateDataGridPet();
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
            //  Percorre a lista _pets e verifica se na lista contém o mesmo dados que o usúario digitou na txt_search.
            dataGridViewPet.Rows[indexRow].Selected = false;
            foreach (Pet pet in _pets)
            {
                dataGridViewPet.Rows[indexRow].Selected = false;
                if (pet.IdPet.ToString().Contains(txt_Search.Text))
                {
                    dataGridViewPet.Rows[indexRow].Selected = true;

                }

                if (pet.NamePet.Contains(txt_Search.Text))
                {
                    dataGridViewPet.Rows[indexRow].Selected = true;

                }
                if (pet.Type.Contains(txt_Search.Text))
                {
                    dataGridViewPet.Rows[indexRow].Selected = true;

                }
                if (pet.Specie.Contains(txt_Search.Text))
                {
                    dataGridViewPet.Rows[indexRow].Selected = true;

                }
                if (pet.Gender.Contains(txt_Search.Text))
                {
                    dataGridViewPet.Rows[indexRow].Selected = true;

                }
                if (pet.Customer.NameCustomer.Contains(txt_Search.Text))
                {
                    dataGridViewPet.Rows[indexRow].Selected = true;

                }
                indexRow++;
            }
            indexRow = -1;

        }
        private void CleanControls()
        {
            txt_NamePet.ResetText();
            dateTimePicker_Pet.ResetText();
            comboBox_Type.ResetText();
            comboBox_Specie.ResetText();
            comboBox_Sex.ResetText();
            comboBox_NameCustomer.ResetText();
            txt_NamePet.Focus();
            indexRow = -1;
        }
        /// <summary>
        /// Valida caso o usúario não tenha cadastrado o dono primeiro mostra uma mensagem para cria-lo primeiro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_NewCustomer_Click(object sender, EventArgs e)
        {
           
            if (_customers.Count == 0)
            {
                MessageBox.Show("Please criate the customer first");
                return;

            }
            else
                panel3.Enabled = true;
               CleanControls();

        }
    }
}
