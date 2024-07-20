using SchedulePatients.Domain.Models;

namespace SchedulePatients.ViewModels
{
    public class PhysicianViewModel(string? firstName, string? lastName, string? medicalCouncilNumber, string? fieldOfExpertise)
    {
        public string? FirstName { get; set; } = firstName;
        public string? LastName { get; set; } = lastName;
        public string? MedicalCouncilNumber { get; set; } = medicalCouncilNumber; // شماره نظام پزشکی
        public string? FieldOfExpertise { get; set; } = fieldOfExpertise;
    }
}
