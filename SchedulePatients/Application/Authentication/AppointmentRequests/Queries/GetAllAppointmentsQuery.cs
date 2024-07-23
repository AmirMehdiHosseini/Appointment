using MediatR;
using SchedulePatients.ViewModels;

namespace SchedulePatients.Application.Authentication.AppointmentRequests.Queries
{
    public record GetAllAppointmentsQuery : IRequest<AppointmentViewModel[]>;
}
