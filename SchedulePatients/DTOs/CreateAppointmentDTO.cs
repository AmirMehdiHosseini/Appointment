using SchedulePatients.Domain.Models;

namespace SchedulePatients.DTOs
{
    public record CreateAppointmentDTO(DateTime appointmentDateTime, Patient patient, Physician physician);

}
