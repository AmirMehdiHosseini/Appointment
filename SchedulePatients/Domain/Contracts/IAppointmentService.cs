using Microsoft.AspNetCore.Mvc;
using SchedulePatients.DTOs;
using SchedulePatients.ViewModels;

namespace SchedulePatients.Domain.Contracts
{
    public interface IAppointmentService
    {
        AppointmentViewModel[] GetAll();
        AppointmentViewModel GetById(int id);
        void Craete(CreateAppointmentDTO model);
        void Update(int id, UpdateAppointmentDTO model);
        void Delete(int id);
    }
}
