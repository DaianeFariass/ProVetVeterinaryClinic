using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Linq;

namespace ClassLibrary1
{
    public class Customers
    {

        public int IdCustomer { get; set; }

        public string NameCustomer { get; set; }

        public string Document { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public List<Pet> Pets{ get; set; }

        public List<Appointment> Appointments { get; set; }   
        public override string ToString()
        {
            return $"{IdCustomer}-{NameCustomer}-{Email}";
        }



       
    }

}

