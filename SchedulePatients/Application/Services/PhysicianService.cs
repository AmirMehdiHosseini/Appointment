using Microsoft.AspNetCore.Mvc;
using SchedulePatients.Application.Authentication.PhysicianRequest.Commands;
using SchedulePatients.Domain.Contracts;
using SchedulePatients.Domain.Models;
using SchedulePatients.DTOs;
using SchedulePatients.ViewModels;

namespace SchedulePatients.Application.Services
{
    public class PhysicianService(IPhysicianRepository physicianRepository, IUnitOfWork unitOfWork) : IPhysicianService
    {
        public PhysicianViewModel[] GetAll()
        {
            return physicianRepository!.GetAll().Select(x => new PhysicianViewModel(x.FirstName, x.LastName, x.MedicalCouncilNumber, x.FieldOfExpertise)).ToArray();
        }

        public PhysicianViewModel? GetById(int id)
        {
            Physician? physician = physicianRepository!.GetById(id);
            return new PhysicianViewModel(physician!.FirstName, physician.LastName, physician.MedicalCouncilNumber, physician.FieldOfExpertise);
        }
        public void Create([FromBody] CreatePhysicianCommand model)
        {
            var entity = new Physician(model.FirstName, model.LastName, model.MedicalCouncilNumber, model.FieldOfExpertise);
            physicianRepository!.Create(entity);
            unitOfWork?.Commit();
        }
        public void Update(int id, UpdatePhysicianViewModel model)
        {
            var entity = physicianRepository.GetById(id);
            entity!.FirstName = model.FirstName;
            entity.LastName = model.LastName;
            entity.MedicalCouncilNumber = model.MedicalCouncilNumber;
            entity.FieldOfExpertise = model.FieldOfExpertise;
            unitOfWork.Commit();
        }
        public void Delete(int id)
        {
            physicianRepository.Delete(id);
            unitOfWork?.Commit();
        }
    }
}
