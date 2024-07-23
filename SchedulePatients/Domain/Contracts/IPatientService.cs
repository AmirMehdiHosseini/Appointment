using Microsoft.AspNetCore.Mvc;
using SchedulePatients.Domain.Models;
using SchedulePatients.Infrastructure.Repositories;
using SchedulePatients.Infrastructure;
using SchedulePatients.ViewModels;
using SchedulePatients.Application.Authentication.PatientRequest.Commands;

namespace SchedulePatients.Domain.Contracts
{
    public interface IPatientService
    {
        PatientViewModel[] GetAll();
        PatientViewModel? GetById(int id);
        void Create([FromBody] CreatePatientCommand model);
        void Update(int id, UpdatePatientViewModel model);
        void Delete(int id);
    }
}
