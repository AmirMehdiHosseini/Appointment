using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchedulePatients.Domain.Models
{
    //public class Appointment(DateTime appointmentDateTime, Patient patient, Physician physician)
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //    public int Id { get; private set; }
    //    public static TimeSpan Duration { get; private set; } = new(0, 30, 0); 
    //    public DateTime? AppointmentDateTime { get; set; } = appointmentDateTime;
    //    public Patient Patient { get; set; } = patient;
    //    public int PatientId { get; private set; } = patient.Id;
    //    public Physician Physician { get; set; } = physician;
    //    public int PhysicianId { get; private set; } = physician.Id;
    //}
    public class Appointment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }

        public static TimeSpan Duration { get; private set; } = new TimeSpan(0, 30, 0);

        public DateTime? AppointmentDateTime { get; set; }

        public Patient? Patient { get; set; }

        public Physician? Physician { get; set; }

        public Appointment() { } // Parameterless constructor required by Entity Framework

        public Appointment(DateTime appointmentDateTime, Patient patient, Physician physician)
        {
            AppointmentDateTime = appointmentDateTime;
            Patient = patient;
            Physician = physician;
        }
    }
}
