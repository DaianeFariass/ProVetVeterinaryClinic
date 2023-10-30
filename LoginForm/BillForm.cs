using ClassLibrary1;
using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Image = iText.Layout.Element.Image;

namespace LoginForm
{
    public partial class BillForm : Form
    {
        List<Bill> _bills;   
        List<Appointment> _apps;
        Connections _connection;
        int countBills = 0;
        int indexRow = -1;
        public BillForm(ref List<Bill> bills, ref List<Appointment> apps)
        {
            InitializeComponent();
            _bills = bills;
            _apps = apps;     
            _connection = new Connections();
            countBills = bills.Count + 1;
            lbl_IDBills.Text = countBills.ToString();
        }
        /// <summary>
        /// Método que preenche a combobox com os dados do PET.
        /// </summary>
        private void FillPetInfo()
        {
            _apps = _connection.ReadInfoAppointment();
            foreach (Appointment app in _apps)
            {
                comboBoxNamePet.Items.Add(app);
                comboBoxNamePet.DisplayMember = "Pet";

            }

        }
        /// <summary>
        /// Metódo que seleciona o ítem na comboboxNamePet e em simutâneo mostra o id da consulta e o nome do dono nas labels.
        /// </summary>
        /// <param name="sender">objeto sender</param>
        /// <param name="e">EventoArgs e</param>
        private void comboBoxNameCustomerSelectedIndexChanged(object sender, EventArgs e)
        {
            Appointment select = (Appointment)comboBoxNamePet.SelectedItem;
            lbl_IdAppointment.Text = select.IdAppointment.ToString();
            lbl_NameCustomer.Text = select.Pet.Customer.NameCustomer;

        }
        /// <summary>
        /// Método que preenche a comboboxcost com os valores do appointment.
        /// </summary>
        private void FillCost()
        {
            comboBoxCost.Items.Add("60.00");
            comboBoxCost.Items.Add("80.00");
            comboBoxCost.Items.Add("100.00");
            comboBoxCost.Items.Add("120.00");
            comboBoxCost.Items.Add("150.00");
        }
        private void BillForm_Load(object sender, EventArgs e)
        {
            FillPetInfo();
            FillCost();
            PopulateDataGridBill();

        }
        private void btn_Save_Click(object sender, EventArgs e)
        {

            _apps = _connection.ReadInfoAppointment();
            DateTime date = (DateTime)dateTimePicker1.Value;
            if (date > DateTime.Now)
            {
                MessageBox.Show("This Date is unvailable");
                return;
            }
            Bill bill = new Bill();
            try
            {
                bill.IdBill = countBills;
                bill.Cost = Convert.ToDouble(comboBoxCost.SelectedItem);
                bill.Date = date;
                bill.Appointment = (Appointment)comboBoxNamePet.SelectedItem;
                _bills.Add(bill);
                _connection.SaveInfoBill(_bills);
                MessageBox.Show("Bill Successfully Added!");
                countBills++;
                PopulateDataGridBill();
                CleanControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
           

        }
        private void CleanControls()
        {
            comboBoxNamePet.ResetText();
            lbl_NameCustomer.ResetText();
            lbl_IdAppointment.ResetText();
            dateTimePicker1.ResetText();
            comboBoxCost.ResetText();
            indexRow = -1;

        }
        /// <summary>
        /// Método que preenche a DataGridBill com os dados da Bill.
        /// </summary>
        public void PopulateDataGridBill()
        {
           
            dataGridViewBill.DataSource = null;
            dataGridViewBill.DataSource = _bills;
            for (int i = 0; i < _bills.Count; i++)
            {
                dataGridViewBill.Rows[i].Selected = false;

            }

        }
        /// <summary>
        /// Evento que ao clicar na linha da datagridviewappointments os dados de cada célula retorna separadamente para as labels e txts.
        /// </summary>        
        private void dataGridViewAppointment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            lbl_IdAppointment.Text = dataGridViewBill.SelectedRows[0].Cells[0].Value.ToString();
            comboBoxCost.Text = dataGridViewBill.SelectedRows[0].Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridViewBill.SelectedRows[0].Cells[2].Value.ToString();
            lbl_IdAppointment.Text = dataGridViewBill.SelectedRows[0].Cells[3].Value.ToString();

        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {

            if (dataGridViewBill.CurrentCell == null || dataGridViewBill.CurrentCell.RowIndex < 0)
            {
                MessageBox.Show("Select The Bill to Delete!");
                return;

            }
            else
            {
                indexRow = dataGridViewBill.CurrentCell.RowIndex;
                for (int i = 0; i < _bills.Count; i++)
                {

                    if (dataGridViewBill.Rows[i].Selected == true)
                    {
                        _bills.RemoveAt(indexRow);
                        _connection.SaveInfoBill(_bills);
                        MessageBox.Show("Bill Successfully Deleted!");
                        PopulateDataGridBill();
                        CleanControls();
                    }
                }
            }

        }
        private void btn_Update_Click(object sender, EventArgs e)
        {

            if (dataGridViewBill.CurrentCell == null || dataGridViewBill.CurrentCell.RowIndex < 0)
            {
                MessageBox.Show("Please select the Bill to Update!!!");
                return;
             
            }
            else
            {
                //dataGridViewBill.Rows[indexRow].Selected = true;
                indexRow = dataGridViewBill.CurrentCell.RowIndex;
                try
                {

                    Bill bill = _bills[indexRow];
                    bill.Appointment = (Appointment)comboBoxNamePet.SelectedItem;
                    bill.Date = dateTimePicker1.Value.Date;
                    bill.Cost = Convert.ToDouble(comboBoxCost.SelectedItem.ToString());
                    _bills[indexRow] = bill;
                    _connection.SaveInfoBill(_bills);
                    MessageBox.Show("Bill Successfully Updated!");
                    PopulateDataGridBill();
                    CleanControls();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
         
        }
        int key = 0;
        private void btn_Search_Click(object sender, EventArgs e)
        {
            foreach (Bill bill in _bills)
            {
                dataGridViewBill.Rows[key].Selected = false;
                if (bill.IdBill.ToString().Contains(txt_Search.Text))
                {
                    dataGridViewBill.Rows[key].Selected = true;

                }
                key++;
            }

        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            dataGridViewBill.Rows[key].Selected = false;
            indexRow = dataGridViewBill.CurrentCell.RowIndex;
            GeneratePdf();

        }
        /// <summary>
        /// Método que gera um PDF com os dados da Bill.
        /// </summary>
        private void GeneratePdf()
        {
            var path = @"C:\Users\daia_\Desktop\TRABALHOS DAIANE - CINEL\POO\Bill.pdf";
            var text = "ProVet Veterinary Clinic";
            var text2 = $"Nome:\t {lbl_NameCustomer.Text} ";
            var text3 = $"Id Appointment:\t {lbl_IdAppointment.Text}";
            var text4 = $"Cost:\t {comboBoxCost.Text}";
            var data = dateTimePicker1.Value.Date.ToString();
            var signature = "_______________________________";
            using (PdfWriter wpdf = new PdfWriter(path, new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0)))
            {
                var pdfDocument = new PdfDocument(wpdf);
                var document = new Document(pdfDocument, PageSize.A4);
                document.SetFontSize(14);
                document.SetMargins(50, 50, 50, 50);
                document.SetCharacterSpacing((float)0.5);
                document.Add(new Paragraph("ProVet\n\n").SetFirstLineIndent(60).SetFontSize(20));
                var logo = @"C:\Users\daia_\Desktop\Clinica Veterinária\logo.png";
                Image img = new Image(iText.IO.Image.ImageDataFactory.Create(logo));
                img.ScaleAbsolute(60, 60);
                img.SetFixedPosition(50f, 750f);
                document.Add(img);
                var timesNewRoman = PdfFontFactory.CreateFont(StandardFonts.TIMES_BOLD);
                var p1 = new Paragraph();
                p1.SetFont(timesNewRoman);
                p1.SetFontSize(30);
                p1.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                p1.SetFontColor(ColorConstants.BLUE);
                p1.SetBackgroundColor(ColorConstants.LIGHT_GRAY);
                p1.Add("Bill");
                document.Add(p1);
                document.Add(new Paragraph("\n\n"));
                document.Add(new Paragraph(text).SetFirstLineIndent(20).SetFixedLeading(26));
                document.Add(new Paragraph("\n"));
                document.Add(new Paragraph(text2).SetFirstLineIndent(20).SetFixedLeading(26));
                document.Add(new Paragraph("\n"));
                document.Add(new Paragraph(text3).SetFirstLineIndent(20).SetFixedLeading(26));
                document.Add(new Paragraph("\n"));
                document.Add(new Paragraph(text4).SetFirstLineIndent(20).SetFixedLeading(26));
                document.Add(new Paragraph("\n\n\n"));
                document.Add(new Paragraph(data).SetTextAlignment(TextAlignment.CENTER));
                document.Add(new Paragraph(signature).SetTextAlignment(TextAlignment.CENTER));
                document.Add(new Paragraph("ProVet Veterinary Clinic").SetTextAlignment(TextAlignment.CENTER));
                pdfDocument.Close();
                MessageBox.Show("Arquivo PDF gerado em " + path);

            }
        }
    }
}