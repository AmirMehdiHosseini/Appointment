namespace SchedulePatients.ViewModels
{
    public class PatientViewModel(string? firstName, string? lastName, string? nationalNumber)
    {
        public string? FirstName { get; set; } = firstName;
        public string? LastName { get; set; } = lastName;
        public string? NationalNumber { get; set; } = nationalNumber;
    }
}
