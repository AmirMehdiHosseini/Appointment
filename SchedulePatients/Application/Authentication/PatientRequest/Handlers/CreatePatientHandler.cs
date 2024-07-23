using MediatR;
using SchedulePatients.Application.Authentication.PatientRequest.Commands;
using SchedulePatients.Domain.Contracts;

namespace SchedulePatients.Application.Authentication.PatientRequest.Handlers
{
    public class CreatePatientHandler(IPatientService patientService) : IRequestHandler<CreatePatientCommand>
    {
        public async Task Handle(CreatePatientCommand request, CancellationToken cancellationToken)
        {
            patientService.Create(request);
        }
    }
}
