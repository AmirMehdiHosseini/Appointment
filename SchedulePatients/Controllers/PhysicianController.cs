using Microsoft.AspNetCore.Mvc;
using SchedulePatients.Domain.Contracts;
using SchedulePatients.Domain.Models;
using SchedulePatients.DTOs;
using SchedulePatients.Services;
using SchedulePatients.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchedulePatients.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhysicianController(IPhysicianService physicianService) : ControllerBase
    {

        // GET: api/<PatientController>
        [HttpGet]
        public PhysicianViewModel[] GetAll ()
        {
            return physicianService!.GetAll();
        }

        // GET api/<PhysicianController>/5
        [HttpGet("{id}")]
        public PhysicianViewModel? GetById(int id)
        {
            return physicianService!.GetById(id); ;
        }
         
        // POST api/<PhysicianController>
        [HttpPost]
        public void Create([FromBody] CreatePhysicianDTO model)
        {
            physicianService.Create(model);
        }

        // PUT api/<PhysicianController>/5
        [HttpPut("{id}")]
        public void Update(int id, [FromBody] UpdatePhysicianDTO model)
        {
            physicianService!.Update(id, model);
        }

        // DELETE api/<PhysicianController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            physicianService!.Delete(id);
        }
    }
}
