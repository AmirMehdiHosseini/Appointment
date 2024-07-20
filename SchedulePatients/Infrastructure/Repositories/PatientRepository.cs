using Microsoft.EntityFrameworkCore;
using SchedulePatients.Domain.Contracts;
using SchedulePatients.Domain.Models;
using SchedulePatients.DTOs;
using SchedulePatients.Infrastructure.DatabaseContext;

namespace SchedulePatients.Infrastructure.Repositories
{
    
    public class PatientRepository(ScheduelServiceContext dbContext) : BaseRepository<Patient>(dbContext), IPatientRepository
    {
    }
}
