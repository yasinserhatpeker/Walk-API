using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApp.Data;
using MyApp.Models;

namespace MyApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        private readonly NZWalkDbContext _context;

        public RegionController(NZWalkDbContext context)
        {
             _context = context;
        }

         [HttpGet]
        public IActionResult GetAll()
        {
            var regions = _context.Regions.ToList();
            return Ok(regions);
           
        }
    }
}
