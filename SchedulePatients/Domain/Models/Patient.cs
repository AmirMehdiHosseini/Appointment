using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchedulePatients.Domain.Models
{
    public class Patient(string? firstName, string? lastName, string? nationalNumber)
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }
        public string? FirstName { get; set; } = firstName;
        public string? LastName { get; set; } = lastName;
        public string? NationalNumber { get; set; } = nationalNumber;
    }
}
