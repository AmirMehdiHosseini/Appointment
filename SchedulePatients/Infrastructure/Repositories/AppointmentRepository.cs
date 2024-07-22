using Microsoft.EntityFrameworkCore;
using SchedulePatients.Domain.Contracts;
using SchedulePatients.Domain.Models;
using SchedulePatients.Infrastructure.DatabaseContext;

namespace SchedulePatients.Infrastructure.Repositories
{
    public class AppointmentRepository(ScheduelServiceContext dbContext) : BaseRepository<Appointment> (dbContext), IAppointmentRepository
    {
        public IEnumerable<Appointment> GetAll()
        {
            return Table.Include(entity => entity.Patient).Include(entity => entity.Physician).ToList();
        }

        public Appointment? GetById(int id)
        {
            return GetAll().FirstOrDefault(x => x.Id == id);
        }
    }
}
