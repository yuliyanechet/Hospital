using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital.Models
{
    public enum Status { Arrived, Sick, Healthy };
    public class Patient
    {
        public Patient()
        {
            this.Doctors = new HashSet<Doctor>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public Status Status { get; set; }

        public DateTime DayOfBirth { get; set; }

        public string TaxCode { get; set; }

        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}