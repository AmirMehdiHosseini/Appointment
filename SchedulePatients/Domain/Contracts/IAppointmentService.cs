using Microsoft.AspNetCore.Mvc;
using SchedulePatients.Application.Authentication.AppointmentRequests.Commands;
using SchedulePatients.ViewModels;

namespace SchedulePatients.Domain.Contracts
{
    public interface IAppointmentService
    {
        AppointmentViewModel[] GetAll();
        AppointmentViewModel GetById(int id);
        void Craete(CreateAppointmentCommand model);
        void Update(int id, UpdateAppointmentViewModel model);
        void Delete(int id);
    }
}
