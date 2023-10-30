using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Bill
    {
        public int IdBill { get; set; }

        public double Cost { get; set; }

        public DateTime Date { get; set; }

        public Appointment Appointment { get; set; }

      

        public override string ToString()
        {
            return $"{IdBill} - {Cost} - {Date} - {Appointment} ";
        }


    }
}

