using Microsoft.AspNetCore.Mvc;
using SchedulePatients.Domain.Contracts;
using SchedulePatients.Domain.Models;
using SchedulePatients.DTOs;
using SchedulePatients.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchedulePatients.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController (IAppointmentService appointmentService) : ControllerBase
    {
        // GET: api/<AppointmentController>
        [HttpGet]
        public AppointmentViewModel[] GetAll()
        {
            return appointmentService.GetAll();
        }

        // GET api/<AppointmentController>/5
        [HttpGet("{id}")]
        public AppointmentViewModel GetById(int id)
        {
            return appointmentService.GetById(id);
        }

        // POST api/<AppointmentController>
        [HttpPost]
        public void Craete([FromBody] CreateAppointmentDTO model )
        {
            appointmentService.Craete(model);
        }

        // PUT api/<AppointmentController>/5
        [HttpPut("{id}")]
        public void Update(int id, [FromBody] UpdateAppointmentDTO model)
        {
            appointmentService.Update(id, model);
        }

        // DELETE api/<AppointmentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            appointmentService.Delete(id);
        }
    }
}
