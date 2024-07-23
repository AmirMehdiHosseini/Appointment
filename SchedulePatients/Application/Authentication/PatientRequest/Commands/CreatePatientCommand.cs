using MediatR;

namespace SchedulePatients.Application.Authentication.PatientRequest.Commands
{
    public record CreatePatientCommand(string? FirstName, string? LastName, string? NationalNumber) : IRequest;
}
