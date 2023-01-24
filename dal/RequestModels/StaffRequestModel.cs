using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.RequestModels
{
    public class StaffRequestModel
    {
        public int StaffId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public DateTime HireDate { get; set; }
        public string Position { get; set; } = null!;
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; } = null!;
    }
}
