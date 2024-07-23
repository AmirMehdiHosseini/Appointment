using MediatR;

namespace SchedulePatients.Application.Authentication.AppointmentRequests.Commands
{
    public record DeleteAppointmentCommand(int Id) : IRequest;
}
