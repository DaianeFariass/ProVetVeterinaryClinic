using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Xml.Linq;

namespace ClassLibrary1
{
    public class Connections
    {
        /// <summary>
        /// Método para salvar a lista dos Customers na txt customersinfo.txt.
        /// </summary>
        /// <param name="customers">Lista de Customers</param>
        public void SaveInfoCustomers(List<Customers> customers)
        {
            string file = @"customersinfo.txt";
            StreamWriter sw = new StreamWriter(file, false);
            if (!File.Exists(file))
            {
                sw = File.CreateText(file);

            }
            foreach (Customers cus in customers)
            {
                string row = $"{cus.IdCustomer.ToString()};{cus.NameCustomer};{cus.Document};{cus.Address};{cus.Phone};{cus.Email}";
                sw.WriteLine(row);
            }
            sw.Close();


        }
        /// <summary>
        /// Método que retorna a lista de Customers.
        /// </summary>
        /// <returns>Lista de Customers</returns>
        public List<Customers> ReadInfoCustomers()
        {

            string file = @"customersinfo.txt";
            StreamReader sr;
            List<Customers> customers = new List<Customers>();
            if (File.Exists(file))
            {
                sr = File.OpenText(file);

                string row = "";

                while ((row = sr.ReadLine()) != null)
                {
                    string[] cp = row.Split(';');
                    Customers cus = new Customers();
                    cus.IdCustomer = Convert.ToInt32(cp[0]);
                    cus.NameCustomer = cp[1];
                    cus.Document = cp[2];
                    cus.Address = cp[3];
                    cus.Phone = cp[4];
                    cus.Email = cp[5];
                    cus.Pets = new List<Pet>();
                    cus.Appointments = new List<Appointment>();
                    customers.Add(cus);
                }
                sr.Close();
            }
            return customers;
        }
        /// <summary>
        /// Método que salva a lista dos pets na txt petinfo.txt.
        /// </summary>
        /// <param name="pets">Lista de pets</param>
        public void SaveInfoPet(List<Pet> pets)
        {
            string file = @"petinfo.txt";
            StreamWriter sw = new StreamWriter(file, false);
            if (!File.Exists(file))
            {
                sw = File.CreateText(file);
            }
            foreach (Pet pet in pets)
            {
                string row = $"{pet.IdPet.ToString()};{pet.NamePet};{pet.Dob};{pet.Type};{pet.Specie};{pet.Gender};{pet.Customer.IdCustomer.ToString()};{pet.Customer.NameCustomer};{pet.Customer.Email}";
                sw.WriteLine(row);
            }
            sw.Close();

        }
        /// <summary>
        /// Método que retorna a lista de pets.
        /// </summary>
        /// <returns>Lista de pets</returns>
        public List<Pet> ReadInfoPet()
        {
            string file = @"petinfo.txt";
            StreamReader sr;
            List<Pet> pets = new List<Pet>();
            if (File.Exists(file))
            {
                sr = File.OpenText(file);

                string row = "";

                while ((row = sr.ReadLine()) != null)
                {
                    string[] cp = row.Split(';');
                    Pet pet = new Pet();
                    pet.IdPet = Convert.ToInt32(cp[0]);
                    pet.NamePet = cp[1];
                    pet.Dob = Convert.ToDateTime(cp[2]);
                    pet.Type = cp[3];
                    pet.Specie = cp[4];
                    pet.Gender = cp[5];
                    Customers cus = new Customers();
                    cus.IdCustomer = Convert.ToInt32(cp[6]);
                    cus.NameCustomer = cp[7];
                    if(cp.Length > 8)
                    {
                        cus.Email = cp[8];
                    }                  
                    pet.Customer = cus;
                    pets.Add(pet);

                }
                sr.Close();

            }
            return pets;
        }
        /// <summary>
        /// Método que salva a lista dos vets na txt vetinfo.txt.
        /// </summary>
        /// <param name="vets"></param>
        public void SaveInfoVet(List<Vet> vets)
        {
            string file = @"vetinfo.txt";
            StreamWriter sw = new StreamWriter(file, false);
            if (!File.Exists(file))
            {
                sw = File.CreateText(file);
            }
            foreach (Vet vet in vets)
            {
                string row = $"{vet.IdVet.ToString()};{vet.NameVet};{vet.Address};{vet.Phone};{vet.Email};{vet.Room}";
                sw.WriteLine(row);
            }
            sw.Close();

        }
        /// <summary>
        /// Método que retorna a lista dos vets. 
        /// </summary>
        /// <returns></returns>
        public List<Vet> ReadInfoVet()
        {
            string file = @"vetinfo.txt";
            StreamReader sr;
            List<Vet> vets = new List<Vet>();
            if (File.Exists(file))
            {
                sr = File.OpenText(file);

                string row = "";

                while ((row = sr.ReadLine()) != null)
                {
                    string[] cp = row.Split(';');
                    Vet vet = new Vet();
                    vet.IdVet = Convert.ToInt32(cp[0]);
                    vet.NameVet = cp[1];
                    vet.Address = cp[2];
                    vet.Phone = cp[3];
                    vet.Email = cp[4];
                    vet.Room = Convert.ToInt32(cp[5]);
                    vets.Add(vet);

                }
                sr.Close();

            }
            return vets;
        }
        /// <summary>
        /// Método que salva a lista de appointments na txt appinfo.txt.
        /// </summary>
        /// <param name="apps">Lista de appointments</param>
        public void SaveInfoAppointment(List<Appointment> apps)
        {
            string file = @"appinfo.txt";
            StreamWriter sw = new StreamWriter(file, false);
            if (!File.Exists(file))
            {
                sw = File.CreateText(file);
            }
            foreach (Appointment app in apps)
            {
                string row = $"{app.IdAppointment.ToString()};{app.Date};{app.Pet.IdPet.ToString()};{app.Pet.NamePet};{app.Pet.Customer.IdCustomer.ToString()};{app.Pet.Customer.NameCustomer};{app.Pet.Customer.Email};{app.Vet.IdVet.ToString()};{app.Vet.NameVet}";
                sw.WriteLine(row);
            }
            sw.Close();

        }
        /// <summary>
        /// Método que retorna a Lista de appointments.
        /// </summary>
        /// <returns>Lista de Appointments</returns>
        public List<Appointment> ReadInfoAppointment()
        {
            string file = @"appinfo.txt";
            StreamReader sr;
            List<Appointment> apps = new List<Appointment>();
            if (File.Exists(file))
            {
                sr = File.OpenText(file);

                string row = "";

                while ((row = sr.ReadLine()) != null)
                {
                    string[] cp = row.Split(';');
                    Appointment app = new Appointment();
                    app.IdAppointment = Convert.ToInt32(cp[0]);
                    app.Date = Convert.ToDateTime(cp[1]);
                    Pet pet = new Pet();
                    pet.IdPet = Convert.ToInt32(cp[2]);
                    pet.NamePet = cp[3];
                    Customers cus = new Customers();
                    cus.IdCustomer = Convert.ToInt32(cp[4]);
                    cus.NameCustomer = cp[5];
                    cus.Email = cp[6];
                    Vet vet = new Vet();
                    vet.IdVet = Convert.ToInt32(cp[7]);
                    vet.NameVet = cp[8];
                    pet.Customer = cus;
                    app.Pet = pet;
                    app.Vet = vet;
                    apps.Add(app);

                }
                sr.Close();

            }
            return apps;
        }
        /// <summary>
        /// Lista que salva a lista da bill na txt billinfo.txt.
        /// </summary>
        /// <param name="bills">Lista de bills</param>
        public void SaveInfoBill(List<Bill> bills)
        {
            string file = @"billinfo.txt";
            StreamWriter sw = new StreamWriter(file, false);
            if (!File.Exists(file))
            {
                sw = File.CreateText(file);
            }
            foreach (Bill bill in bills)
            {
                string row = $"{bill.IdBill.ToString()};{bill.Cost};{bill.Date};{bill.Appointment.Pet.Customer.NameCustomer};{bill.Appointment.IdAppointment.ToString()}";
                sw.WriteLine(row);
            }
            sw.Close();

        }
        /// <summary>
        /// Lista que retorna a lista de bills.
        /// </summary>
        /// <returns>Lista de bills</returns>
        public List<Bill> ReadInfoBill()
        {
            string file = @"billinfo.txt";
            StreamReader sr;
            List<Bill> bills = new List<Bill>();
            if (File.Exists(file))
            {
                sr = File.OpenText(file);

                string row = "";

                while ((row = sr.ReadLine()) != null)
                {
                    string[] cp = row.Split(';');
                    Bill bill = new Bill();
                    bill.IdBill = Convert.ToInt32(cp[0]);
                    bill.Cost = Convert.ToDouble(cp[1]);
                    bill.Date = Convert.ToDateTime(cp[2]);
                    Customers cus = new Customers();
                    cus.NameCustomer = cp[3];
                    Pet pet = new Pet();
                    pet.Customer = cus;
                    Appointment app = new Appointment();
                    app.IdAppointment = Convert.ToInt32(cp[4]);
                    app.Pet = pet;
                    bill.Appointment = app;                 
                    bills.Add(bill);

                }
                sr.Close();

            }
            return bills;
        }
        /// <summary>
        /// Método para salvar a lista de logins.
        /// </summary>
        /// <param name="logs">Lista de logs</param>
        public void SaveInfoLogin(List<Login> logs)
        {
            string file = @"logininfo.txt";
            StreamWriter sw = new StreamWriter(file);
            if (!File.Exists(file))
            {
                sw = File.CreateText(file);

            }
            foreach (Login login in logs)
            {
                string row = $"{login.Email};{login.Password}";
                sw.WriteLine(row);
            }
            sw.Close();


        }
        /// <summary>
        /// Método que retorna a Lista de Logins.
        /// </summary>
        /// <returns></returns>
        public List<Login> ReadInfoLogin()
        {
            string file = @"logininfo.txt";
            StreamReader sr;
            List<Login> logs = new List<Login>();
            if (File.Exists(file))
            {
                sr = File.OpenText(file);

                string row = "";

                while ((row = sr.ReadLine()) != null)
                {
                    string[] cp = row.Split(';');
                    Login log = new Login();
                    log.Email = cp[0];
                    log.Password = cp[1];
                    logs.Add(log);

                }
                sr.Close();

            }
            return logs;


        }
    }
}





