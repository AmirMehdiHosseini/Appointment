using MediatR;
using SchedulePatients.Application.Authentication.PatientRequest.Queries;
using SchedulePatients.Domain.Contracts;
using SchedulePatients.ViewModels;

namespace SchedulePatients.Application.Authentication.PatientRequest.Handlers
{
    public class GetAllPatientsHandler(IPatientService patientService) : IRequestHandler<GetAllPatientsQuery, PatientViewModel[]>
    {
        public async Task<PatientViewModel[]> Handle(GetAllPatientsQuery request, CancellationToken cancellationToken)
        {
            var allPatients = patientService.GetAll();
            return allPatients;
        }
    }
}
