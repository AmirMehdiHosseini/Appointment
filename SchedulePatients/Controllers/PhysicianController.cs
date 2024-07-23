using Microsoft.AspNetCore.Mvc;
using SchedulePatients.Domain.Contracts;
using SchedulePatients.Domain.Models;
using SchedulePatients.DTOs;
using SchedulePatients.Application.Services;
using SchedulePatients.ViewModels;
using MediatR;
using SchedulePatients.Application.Authentication.PhysicianRequest.Commands;
using SchedulePatients.Application.Authentication.PatientRequest.Queries;
using SchedulePatients.Application.Authentication.PhysicianRequest.Queries;
using SchedulePatients.Application.Authentication.PhysicianRequest.Handlers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchedulePatients.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhysicianController(IMediator mediatR) : ControllerBase
    {

        // GET: api/<PatientController>
        [HttpGet]
        public async Task<PhysicianViewModel[]> GetAll()
        {
            var query = new GetAllPhysiciansQuery();
            return await mediatR.Send(query);
        }

        // GET api/<PhysicianController>/5
        [HttpGet("{id}")]
        public async Task<PhysicianViewModel?> GetById(int id)
        {
            var query = new GetPhysicianByIdQuery(id);
            return await mediatR.Send(query);
        }

        //// POST api/<PhysicianController>
        [HttpPost]
        public void Create([FromBody] CreatePhysicianCommand model)
        {
            mediatR.Send(model);
        }

        // PUT api/<PhysicianController>/5
        [HttpPut("{id}")]
        public void Update(int id, [FromBody] UpdatePhysicianViewModel model)
        {
            mediatR.Send(new UpdatePhysicianCommand(id, model));
        }

        // DELETE api/<PhysicianController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            mediatR.Send(new DeletePhysicianCommand(id));
        }
    }
}
