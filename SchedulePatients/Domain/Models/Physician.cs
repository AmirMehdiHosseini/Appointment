using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace SchedulePatients.Domain.Models
{
    public class Physician(string? firstName, string? lastName, string? medicalCouncilNumber, string? fieldOfExpertise)
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }
        public string? FirstName { get; set; } = firstName;
        public string? LastName { get; set; } = lastName;
        public string? MedicalCouncilNumber { get; set; } = medicalCouncilNumber;
        public string? FieldOfExpertise { get; set; } = fieldOfExpertise;
    }
}
