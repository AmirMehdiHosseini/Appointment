using Microsoft.EntityFrameworkCore;
using SchedulePatients.Domain.Models;
using System.Reflection;
namespace SchedulePatients.Infrastructure.DatabaseContext
{
    public class ScheduelServiceContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Physician> Physicians { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        public ScheduelServiceContext(DbContextOptions<ScheduelServiceContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}

