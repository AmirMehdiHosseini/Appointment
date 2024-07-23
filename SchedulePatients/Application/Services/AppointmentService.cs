using Microsoft.AspNetCore.Mvc;
using SchedulePatients.Application.Authentication.AppointmentRequests.Commands;
using SchedulePatients.Domain.Contracts;
using SchedulePatients.Domain.Models;
using SchedulePatients.ViewModels;

namespace SchedulePatients.Application.Services
{
    public class AppointmentService(IPatientRepository patientRepository, IPhysicianRepository physicianRepository, IAppointmentRepository appointmentRepository, IUnitOfWork unitOfWork) : IAppointmentService
    {
        public AppointmentViewModel[] GetAll()
        {
            return appointmentRepository.GetAll().Select(X => new AppointmentViewModel(X.AppointmentDateTime, X.Patient!, X.Physician!, Appointment.Duration)).ToArray();
        }

        public AppointmentViewModel GetById(int id)
        {
            var entity = appointmentRepository.GetById(id);
            return new AppointmentViewModel(entity!.AppointmentDateTime, entity.Patient!, entity.Physician!, Appointment.Duration);
        }
        public void Craete(CreateAppointmentCommand model)
        {
            var entity = new Appointment(model.AppointmentDateTime, patientRepository.GetById(model.PatientID)!, physicianRepository.GetById(model.PhysicianID)!);
            appointmentRepository.Create(entity);
            unitOfWork.Commit();
        }

        public void Delete(int id)
        {
            appointmentRepository.Delete(id);
            unitOfWork.Commit();
        }

        public void Update(int id, UpdateAppointmentViewModel model)
        {
            var entity = appointmentRepository.GetById(id);
            entity!.AppointmentDateTime = model.AppointmentDateTime;
            entity.Physician = physicianRepository.GetById(model.PhysicianID);
            entity.Patient = patientRepository.GetById(model.PatientID);
            unitOfWork.Commit();
        }
    }
}
