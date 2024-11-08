using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MyApi;

[Route("api/[controller]")]
[ApiController]
public class TestController : ControllerBase
{
    private readonly AppDbContext _context;

    public TestController(AppDbContext context)
    {
        _context = context;
    }

    // GET: api/test/check
    [HttpGet("check")]
    public async Task<IActionResult> CheckDatabaseConnection()
    {
        try
        {
            // Attempt to fetch data from the database
            var testItems = await _context.TestItems.ToListAsync();
            return Ok(new { message = "Connection successful!", data = testItems });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Connection failed.", error = ex.Message });
        }
    }
}