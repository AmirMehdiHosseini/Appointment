
using MediatR;

namespace SchedulePatients.Application.Authentication.AppointmentRequests.Commands
{
    public record CreateAppointmentCommand(DateTime AppointmentDateTime, int PatientID, int PhysicianID) : IRequest;

}
