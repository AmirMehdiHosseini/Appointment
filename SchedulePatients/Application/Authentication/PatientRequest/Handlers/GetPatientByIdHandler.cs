using MediatR;
using SchedulePatients.Application.Authentication.PatientRequest.Queries;
using SchedulePatients.Domain.Contracts;
using SchedulePatients.ViewModels;

namespace SchedulePatients.Application.Authentication.PatientRequest.Handlers
{
    public class GetPatientByIdHandler (IPatientService patientService): IRequestHandler<GetPatientByIdQuery, PatientViewModel>
    {
        public async Task<PatientViewModel?> Handle(GetPatientByIdQuery request, CancellationToken cancellationToken)
        {
            return patientService.GetById(request.Id);
        }
    }
}
