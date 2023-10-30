using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ClassLibrary1
{
    public class Appointment
    {
        public int IdAppointment { get; set; }

        public DateTime Date { get; set; }

        public Pet Pet { get; set; }

        public Vet Vet{ get; set; }


        public override string ToString()
        {
            return $"{IdAppointment} - {Date} - {Pet} - {Vet}";
        }
       

    }
}
