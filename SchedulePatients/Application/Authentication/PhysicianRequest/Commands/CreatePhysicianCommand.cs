using MediatR;

namespace SchedulePatients.Application.Authentication.PhysicianRequest.Commands
{
    public record CreatePhysicianCommand(string? FirstName, string? LastName, string? MedicalCouncilNumber, string? FieldOfExpertise) : IRequest;
       
}
