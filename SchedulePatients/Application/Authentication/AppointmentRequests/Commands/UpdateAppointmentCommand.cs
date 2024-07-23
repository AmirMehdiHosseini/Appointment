using MediatR;
using SchedulePatients.Domain.Models;
using SchedulePatients.ViewModels;

namespace SchedulePatients.Application.Authentication.AppointmentRequests.Commands
{
    public record UpdateAppointmentCommand(int Id, UpdateAppointmentViewModel Command) : IRequest;
}
