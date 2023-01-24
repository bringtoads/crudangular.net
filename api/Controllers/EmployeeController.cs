using dal.Models;
using dal.RequestModels;
using dal.staffContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly staffManagementDBContext _context;
        public EmployeeController(staffManagementDBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public  async Task<IActionResult> GetAllEmployees()
        {
            var employee = await _context.staff.ToListAsync();
            return Ok(employee);
        }
        [HttpPost]
        public async Task<IActionResult> AddEmployee([FromBody] staff employeeRequest)
        {
            await _context.staff.AddAsync(employeeRequest);
            await _context.SaveChangesAsync();
            return Ok(employeeRequest);
        }
    }
}
