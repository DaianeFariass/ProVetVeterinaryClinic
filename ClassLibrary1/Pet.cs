using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Security.Cryptography;

namespace ClassLibrary1
{
    
    public class Pet
    {

        public int IdPet { get; set; }

        public string NamePet { get; set; }

        public DateTime Dob { get; set; }

        public string Type { get; set; }

        public string Specie { get; set; }

        public string Gender { get; set; }

        public Customers Customer { get; set; }
       

        public override string ToString()
        {
            return $"{IdPet} - {NamePet} - {Customer}";
        }

      

    }
}
