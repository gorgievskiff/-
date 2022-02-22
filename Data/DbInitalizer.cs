using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using МојТермин.Models;

namespace МојТермин.Data
{
    public class DbInitalizer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Patient.Any())
            {
                return;
            }

            var doctors = new Doctor[]
            {
                new Doctor {Name = "Филип", Surname = "Ѓорѓиевски"},
                new Doctor {Name = "Мартин", Surname = "Ѓорѓиевски"},
                new Doctor {Name = "Дарио", Surname = "Ѓорѓиевски"},
            };

            foreach (var doctor in doctors)
            {
                context.Doctor.Add(doctor);
            }

            context.SaveChanges();

            var patients = new Patient[]
            {
                new Patient {DoctorId = doctors.Single(s => s.Name == "Филип").Id, Name = "John", Surname = "Smith"},
                new Patient {DoctorId = 4, Name = "Mark", Surname = "Smith"},
                new Patient {DoctorId = 5, Name = "Mosh", Surname = "Smith"},
            };

            foreach (var patient in patients)
            {
                context.Patient.Add(patient);
            }

            context.SaveChanges();



        }
    }
}
