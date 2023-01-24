using System;
using System.Collections.Generic;

namespace dal.Models
{
    public partial class Payment
    {
        public DateTime PayDay { get; set; }
        public string Method { get; set; } = null!;
        public int StaffId { get; set; }
        public int PaymentId { get; set; }

        public virtual staff Staff { get; set; } = null!;
    }
}
