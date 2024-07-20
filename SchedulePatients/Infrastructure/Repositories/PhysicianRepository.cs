using Microsoft.EntityFrameworkCore;
using SchedulePatients.Domain.Contracts;
using SchedulePatients.Domain.Models;
using SchedulePatients.DTOs;
using SchedulePatients.Infrastructure.DatabaseContext;


namespace SchedulePatients.Infrastructure.Repositories

{
    public class PhysicianRepository(ScheduelServiceContext dbContext) :   BaseRepository<Physician>(dbContext) ,IPhysicianRepository
    {

    }
}
