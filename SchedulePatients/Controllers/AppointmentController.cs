using MediatR;
using Microsoft.AspNetCore.Mvc;
using SchedulePatients.Application.Authentication.AppointmentRequests.Commands;
using SchedulePatients.Application.Authentication.AppointmentRequests.Queries;
using SchedulePatients.Domain.Contracts;
using SchedulePatients.Domain.Models;
using SchedulePatients.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchedulePatients.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController (IMediator mediatR) : ControllerBase
    {
        //// GET: api/<AppointmentController>
        [HttpGet]
        public async Task<AppointmentViewModel[]> GetAll()
        {
            return await mediatR.Send(new GetAllAppointmentsQuery());
        }

        // GET api/<AppointmentController>/5
        [HttpGet("{id}")]
        public async Task<AppointmentViewModel> GetById(int id)
        {
            return await mediatR.Send(new GetAppointmentByIdQuery(id));
        }

        // POST api/<AppointmentController>
        [HttpPost]
        public void Craete([FromBody] CreateAppointmentCommand model)
        {
            mediatR.Send(model);
        }

        // PUT api/<AppointmentController>/5
        [HttpPut("{id}")]
        public void Update(int id, [FromBody] UpdateAppointmentViewModel model)
        {
            mediatR.Send(new UpdateAppointmentCommand(id,model));
        }

        // DELETE api/<AppointmentController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await mediatR.Send(new DeleteAppointmentCommand(id));
        }
    }
}
