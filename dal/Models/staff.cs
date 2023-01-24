using System;
using System.Collections.Generic;

namespace dal.Models
{
    public partial class staff
    {
        public staff()
        {
            Payments = new HashSet<Payment>();
            Salaries = new HashSet<Salary>();
        }

        public int StaffId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public DateTime HireDate { get; set; }
        public string Position { get; set; } = null!;
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; } = null!;

        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Salary> Salaries { get; set; }
    }
}
