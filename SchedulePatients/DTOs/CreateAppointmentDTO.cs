using SchedulePatients.Domain.Models;

namespace SchedulePatients.DTOs
{
    public record CreateAppointmentDTO(DateTime appointmentDateTime, int patientID, int physicianID);
}
