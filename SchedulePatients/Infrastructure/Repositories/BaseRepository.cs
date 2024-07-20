using Microsoft.EntityFrameworkCore;
using SchedulePatients.Domain.Contracts;
using SchedulePatients.Infrastructure.DatabaseContext;

namespace SchedulePatients.Infrastructure.Repositories
{
    public abstract class BaseRepository<TEntity>(ScheduelServiceContext dbContext) : IRepository<TEntity>
            where TEntity : class
    {
        protected ScheduelServiceContext _dbContext = dbContext;
        protected DbSet<TEntity> Table = dbContext.Set<TEntity>();

        public void Create(TEntity entity)
        {
            Table.Add(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Table;
        }

        public TEntity? GetById(int id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }

        public void Update(TEntity entity)
        {
            Table.Update(entity);
        }
        public void Delete(int id)
        {
            var entity = Table.Find(id);
            Table.Remove(entity!);
        }
    }
}
