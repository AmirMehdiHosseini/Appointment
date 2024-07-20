using Microsoft.EntityFrameworkCore;
using SchedulePatients.Domain.Models;
using SchedulePatients.DTOs;

namespace SchedulePatients.Domain.Contracts
{
    public interface IPatientRepository:IRepository<Patient>
    {

    }
}
