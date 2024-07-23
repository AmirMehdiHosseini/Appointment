using MediatR;
using SchedulePatients.Application.Authentication.AppointmentRequests.Queries;
using SchedulePatients.Domain.Contracts;
using SchedulePatients.ViewModels;

namespace SchedulePatients.Application.Authentication.AppointmentRequests.Handlers
{
    public class GetAllAppointmentsHandler(IAppointmentService appointmentService) : IRequestHandler<GetAllAppointmentsQuery, AppointmentViewModel[]>
    {
        public async Task<AppointmentViewModel[]> Handle(GetAllAppointmentsQuery request, CancellationToken cancellationToken)
        {
            return appointmentService.GetAll();
        }
    }
}
