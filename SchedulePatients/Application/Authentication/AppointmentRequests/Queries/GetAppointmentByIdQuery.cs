using MediatR;
using SchedulePatients.ViewModels;

namespace SchedulePatients.Application.Authentication.AppointmentRequests.Queries
{
    public record GetAppointmentByIdQuery(int Id) : IRequest<AppointmentViewModel>;
}
