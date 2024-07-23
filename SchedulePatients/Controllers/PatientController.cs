using Microsoft.AspNetCore.Mvc;
using SchedulePatients.DTOs;
using SchedulePatients.Domain.Contracts;
using SchedulePatients.ViewModels;
using SchedulePatients.Domain.Models;
using MediatR;
using SchedulePatients.Application.Authentication.PatientRequest.Queries;
using SchedulePatients.Application.Authentication.PatientRequest.Handlers;
using SchedulePatients.Application.Authentication.PatientRequest.Commands;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchedulePatients.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController(IMediator mediatR) : ControllerBase
    {
        // GET: api/<PatientController>
        [HttpGet]
        public async Task<PatientViewModel[]> GetAll()
        {
            GetAllPatientsQuery getAllPatientsQuery = new();
            return await mediatR.Send(getAllPatientsQuery);
        }

        //GET api/<PatientController>/5
        [HttpGet("{id}")]
        public async Task<PatientViewModel?> GetById(int id)
        {
            GetPatientByIdQuery query = new(id);
            return await mediatR.Send(query);
        }

        // POST api/<PatientController>
        [HttpPost]
        public async Task Create([FromBody] CreatePatientCommand model)
        {
            await mediatR.Send(model);
        }

        // PUT api/<PatientController>/5
        [HttpPut("{id}")]
        public void Update(int id, [FromBody] UpdatePatientViewModel model)
        {
            mediatR.Send(new UpdatePatientCommand(id,model));
        }

        // DELETE api/<PatientController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await mediatR.Send(new DeletePatientCommand( id));
        }
    }
}