using Microsoft.AspNetCore.Mvc;
using SchedulePatients.Domain.Contracts;
using SchedulePatients.Domain.Models;
using SchedulePatients.DTOs;
using SchedulePatients.ViewModels;

namespace SchedulePatients.Services
{
    public class AppointmentService (IAppointmentRepository appointmentRepository, IUnitOfWork unitOfWork): IAppointmentService
    {        
        public AppointmentViewModel[] GetAll()
        {
            return appointmentRepository.GetAll().Select(X => new AppointmentViewModel(X.AppointmentDateTime, X.Patient, X.Physician, Appointment.Duration)).ToArray();
        }

        public AppointmentViewModel GetById(int id)
        {
            var entity = appointmentRepository.GetById(id);
            return new AppointmentViewModel(entity!.AppointmentDateTime, entity.Patient,entity.Physician, Appointment.Duration);
        }
        public void Craete(CreateAppointmentDTO model)
        { 
            var entity = new Appointment(model.appointmentDateTime, model.patient, model.physician);
            appointmentRepository.Create(entity);
            unitOfWork.Commit();
        }

        public void Delete(int id)
        {
            appointmentRepository.Delete(id);
            unitOfWork.Commit();
        }



        public void Update(int id, UpdateAppointmentDTO model)
        {
            var entity = appointmentRepository.GetById(id);
            entity!.AppointmentDateTime = model.appointmentDateTime;
            entity.Physician = model.physician;
            unitOfWork.Commit();
        }
    }
}
