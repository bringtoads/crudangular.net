using System;
using System.Collections.Generic;

namespace dal.Models
{
    public partial class Salary
    {
        public int SalaryId { get; set; }
        public int StaffId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int Salary1 { get; set; }

        public virtual staff Staff { get; set; } = null!;
    }
}
