using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PermissionApi.Data;
using PermissionApi.Models;

namespace PermissionApi.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class OfficeController : ControllerBase
    {
        private AppDbContext _context;

        public OfficeController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Office>>> GetOffices()
        {
            var offices = await _context.Offices.ToListAsync();
            return Ok(offices);
        }


        [HttpPost]
        public async Task<ActionResult<Office>> AddOffice(Office office)
        {
            _context.Offices.Add(office);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetOffices), new {id = office.Id}, office);
        }
    }
}
