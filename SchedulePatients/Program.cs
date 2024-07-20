using Microsoft.EntityFrameworkCore;
using SchedulePatients.Domain.Contracts;
using SchedulePatients.Infrastructure.Repositories;
using SchedulePatients.Infrastructure;
using SchedulePatients.Infrastructure.DatabaseContext;
using SchedulePatients.Services;


namespace SchedulePatients
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddScoped<IPatientRepository, PatientRepository>();
            builder.Services.AddScoped<IPhysicianRepository, PhysicianRepository>();
            builder.Services.AddScoped<IAppointmentRepository, AppointmentRepository>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped<ScheduelServiceContext>();
            builder.Services.AddScoped<IPatientService, PatientService>();
            builder.Services.AddScoped<IPhysicianService , PhysicianService>();
            builder.Services.AddScoped<IAppointmentService, AppointmentService>();


            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Connection string
            builder.Services.AddDbContext<ScheduelServiceContext>(option => option.UseSqlServer("Data source=NC-AM-HOSSEINI;" + "initial catalog=clinic;"+
              "Integrated Security=true;" + "MultipleActiveResultSets=true;" + "TrustServerCertificate=true;"));




            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
