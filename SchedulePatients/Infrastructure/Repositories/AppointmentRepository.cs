using SchedulePatients.Domain.Contracts;
using SchedulePatients.Domain.Models;
using SchedulePatients.Infrastructure.DatabaseContext;

namespace SchedulePatients.Infrastructure.Repositories
{
    public class AppointmentRepository(ScheduelServiceContext dbContext) : BaseRepository<Appointment> (dbContext), IAppointmentRepository
    {
    }
}
