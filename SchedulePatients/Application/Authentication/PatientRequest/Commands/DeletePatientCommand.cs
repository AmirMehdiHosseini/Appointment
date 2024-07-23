using MediatR;

namespace SchedulePatients.Application.Authentication.PatientRequest.Commands
{
    public record DeletePatientCommand(int Id) : IRequest;
}
