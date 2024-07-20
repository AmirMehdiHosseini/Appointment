using Microsoft.AspNetCore.Mvc;
using SchedulePatients.DTOs;
using SchedulePatients.ViewModels;

namespace SchedulePatients.Domain.Contracts
{
    public interface IPhysicianService
    {
        PhysicianViewModel[] GetAll();
        PhysicianViewModel? GetById(int id);
        void Create([FromBody] CreatePhysicianDTO model);
        void Update(int id, UpdatePhysicianDTO model);
        void Delete(int id);
    }
}
