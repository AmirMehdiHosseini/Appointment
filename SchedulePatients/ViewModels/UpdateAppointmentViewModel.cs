using MediatR;

namespace SchedulePatients.ViewModels
{
    public record UpdateAppointmentViewModel(DateTime AppointmentDateTime, int PatientID, int PhysicianID);
}
