using Microsoft.AspNetCore.Mvc;
using SchedulePatients.DTOs;
using SchedulePatients.Domain.Contracts;
using SchedulePatients.ViewModels;
using SchedulePatients.Domain.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchedulePatients.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController(IPatientService patientService) : ControllerBase 
    {
        // GET: api/<PatientController>
        [HttpGet]
        public PatientViewModel[] GetAll()
        {
            return patientService.GetAll();
        }

        // GET api/<PatientController>/5
        [HttpGet("{id}")]
        public PatientViewModel? GetById(int id)
        {
            return patientService.GetById(id);
        }

        // POST api/<PatientController>
        [HttpPost]
        public void Create([FromBody] CreatePatientDTO model)
        {
            patientService.Create(model);
        }

        // PUT api/<PatientController>/5
        [HttpPut("{id}")]
        public void Update(int id , [FromBody] UpdatePatientDTO model)
        {
            patientService.Update(id, model);
        }

        // DELETE api/<PatientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            patientService.Delete(id);
        }
    }
}
