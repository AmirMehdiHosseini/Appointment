
using Microsoft.AspNetCore.Mvc;
using SchedulePatients.Domain.Contracts;
using SchedulePatients.Domain.Models;
using SchedulePatients.DTOs;
using SchedulePatients.Infrastructure.Repositories;
using SchedulePatients.ViewModels;

namespace SchedulePatients.Services
{
    public class PatientService(IPatientRepository patientRepository, IUnitOfWork unitOfWork) :IPatientService
    {
        public PatientViewModel[] GetAll()
        {
            return patientRepository!.GetAll().Select(x => new PatientViewModel(x.FirstName, x.LastName, x.NationalNumber)).ToArray();
        }
        public PatientViewModel? GetById(int id)
        {
            Patient? patient = patientRepository!.GetById(id);
            return new PatientViewModel(patient!.FirstName, patient.LastName, patient.NationalNumber);
        }
        public void Create([FromBody] CreatePatientDTO model)
        {
            var entity = new Patient(model.FirstName, model.LastName, model.NationalNumber);
            patientRepository!.Create(entity);
            unitOfWork?.Commit();
        }
        public void Update(int id, UpdatePatientDTO model)
        {
            var entity = patientRepository.GetById(id);
            entity!.FirstName = model.FirstName;
            entity.LastName = model.LastName;
            entity.NationalNumber = model.NationalNumber;
            unitOfWork.Commit();
        }

        public void Delete(int id)
        {
            patientRepository.Delete(id);
            unitOfWork?.Commit();
        }
    }
}
