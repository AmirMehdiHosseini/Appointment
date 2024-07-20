using SchedulePatients.Domain.Models;

namespace SchedulePatients.ViewModels
{
    public class AppointmentViewModel(DateTime? appointmentDateTime, Patient patient, Physician physician, TimeSpan duration)
    {
        public TimeSpan Duration { get; set; } = duration;
        public DateTime? AppointmentDateTime { get; set; } = appointmentDateTime;
        public Patient Patient { get; set; } = patient;
        public Physician Physician { get; set; } = physician;
    }
}
