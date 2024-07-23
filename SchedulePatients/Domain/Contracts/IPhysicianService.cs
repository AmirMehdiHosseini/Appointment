using Microsoft.AspNetCore.Mvc;
using SchedulePatients.Application.Authentication.PhysicianRequest.Commands;
using SchedulePatients.DTOs;
using SchedulePatients.ViewModels;

namespace SchedulePatients.Domain.Contracts
{
    public interface IPhysicianService
    {
        PhysicianViewModel[] GetAll();
        PhysicianViewModel? GetById(int id);
        void Create([FromBody] CreatePhysicianCommand model);
        void Update(int id, UpdatePhysicianViewModel model);
        void Delete(int id);
    }
}
