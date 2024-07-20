using Microsoft.AspNetCore.Mvc;
using SchedulePatients.Domain.Models;
using SchedulePatients.DTOs;
using SchedulePatients.Infrastructure.Repositories;
using SchedulePatients.Infrastructure;
using SchedulePatients.ViewModels;

namespace SchedulePatients.Domain.Contracts
{
    public interface IPatientService
    {
        PatientViewModel[] GetAll();
        PatientViewModel? GetById(int id);
        void Create([FromBody] CreatePatientDTO model);
        void Update(int id, UpdatePatientDTO model);
        void Delete(int id);
    }
}
