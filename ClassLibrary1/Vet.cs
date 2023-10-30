using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Linq;

namespace ClassLibrary1
{
    public class Vet
    {
        public int IdVet{ get; set; }

        public string NameVet { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public int Room { get; set; }

        public List<Appointment> Appointment { get; set; }


        public override string ToString()
        {
            return $"{IdVet} - {NameVet}";
        }
     
       
    }
}
