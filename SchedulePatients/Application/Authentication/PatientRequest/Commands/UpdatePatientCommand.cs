using MediatR;
using SchedulePatients.ViewModels;

namespace SchedulePatients.Application.Authentication.PatientRequest.Commands
{
    public record UpdatePatientCommand(int Id, UpdatePatientViewModel Command) : IRequest;

}
