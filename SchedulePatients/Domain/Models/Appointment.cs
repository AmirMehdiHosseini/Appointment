using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchedulePatients.Domain.Models
{
    public class Appointment
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }
        public static TimeSpan Duration { get; private set; } = new(0, 30, 0);
        public DateTime? AppointmentDateTime { get; set; }
        public Patient? Patient { get; set; }
        public Physician? Physician { get; set; }

        public Appointment(DateTime appointmentDateTime, Patient patient, Physician physician)
        {
            AppointmentDateTime = appointmentDateTime;
            Patient = patient;
            Physician = physician;
        }
        protected Appointment() { }
    }
}
