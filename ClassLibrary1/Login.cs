using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Login
    {
        
        public string Email { get; set; }

        public string Password { get; set; }

        public override string ToString()
        {
            return $"{Email} - {Password}";
        }


    }   

}

