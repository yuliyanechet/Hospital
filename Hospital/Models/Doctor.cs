using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital.Models
{
    public class Doctor
    {
        public Doctor()
        {
            this.Patients = new HashSet<Patient>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string Specialization { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }
    }
}