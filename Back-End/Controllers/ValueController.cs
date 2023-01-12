using Back_End.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Back_End.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValueController : ControllerBase
    {
        private readonly DataContext _context;
        public ValueController(DataContext context) 
        {
            _context = context;
        }
        // Get all
        [HttpGet]
        public async Task<ActionResult> GetValues()
        {
            var values = await _context.values.ToListAsync();
            return Ok(values);
        }

        // Get one
        [HttpGet("{id}")]
        public async Task<ActionResult> GetValue(int id)
        {
            var value = await _context.values.FirstOrDefaultAsync(value => value.Id == id);
            return Ok(value);
        }
    }
}
