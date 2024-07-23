using MediatR;

namespace SchedulePatients.ViewModels
{
    public record UpdatePhysicianViewModel(string? FirstName, string? LastName, string? MedicalCouncilNumber, string? FieldOfExpertise);
}
