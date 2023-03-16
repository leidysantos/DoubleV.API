using DoubleV.API.Data;
using DoubleV.API.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoubleV.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [DisableCors]
    public class PersonsController : Controller
    {
        private readonly DoubleVDbContext _doubleVDbContext;

        public PersonsController(DoubleVDbContext doubleVDbContext)  
        {
            _doubleVDbContext = doubleVDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPersons()
        {
           var persons = await _doubleVDbContext.Personas.ToListAsync();

            return Ok(persons);
            
        }

        [HttpPost]

        public async Task<IActionResult> AddPerson([FromBody] Person personRequest) 
        { 
            personRequest.Id = Guid.NewGuid();
            await _doubleVDbContext.Personas.AddAsync(personRequest);
            await _doubleVDbContext.SaveChangesAsync();

            return Ok(personRequest);
        }

    }
}
