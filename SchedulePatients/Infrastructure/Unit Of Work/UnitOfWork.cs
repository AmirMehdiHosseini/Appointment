using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using SchedulePatients.Domain.Contracts;
using SchedulePatients.Infrastructure.DatabaseContext;

namespace SchedulePatients.Infrastructure
{
    public class UnitOfWork(ScheduelServiceContext dbContext) : IUnitOfWork
    {

        public void Commit()
        {
            dbContext.SaveChanges();
        }
    }
}
