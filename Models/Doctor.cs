using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace МојТермин.Models
{
    public class Doctor
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }

        public ICollection<Patient> Patients { get; set; }
        public ICollection<Term> Terms { get; set; }    


    }
}
