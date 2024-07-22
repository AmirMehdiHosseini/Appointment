using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SchedulePatients.Domain.Models;

namespace SchedulePatients.Infrastructure.EntityTypeConfiguration
{
    public class PhysicianConfiguration : IEntityTypeConfiguration<Physician>
    {
        public void Configure(EntityTypeBuilder<Physician> builder)
        {
            builder.HasKey(entity => entity.Id);
            builder.Property(entity => entity.Id).ValueGeneratedOnAdd();
        }
    }
}
