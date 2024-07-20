using SchedulePatients.Domain.Models;

namespace SchedulePatients.DTOs
{
    public record UpdateAppointmentDTO(DateTime appointmentDateTime, Physician physician);
}
