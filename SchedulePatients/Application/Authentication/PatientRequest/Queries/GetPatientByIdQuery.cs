using MediatR;
using SchedulePatients.ViewModels;

namespace SchedulePatients.Application.Authentication.PatientRequest.Queries
{
    public record GetPatientByIdQuery(int Id) : IRequest<PatientViewModel>; 
}
