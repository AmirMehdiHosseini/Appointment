using MediatR;

namespace SchedulePatients.ViewModels
{
    public record UpdatePatientViewModel(string? FirstName, string? LastName, string? NationalNumber);
}
