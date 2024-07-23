using MediatR;
using SchedulePatients.Application.Authentication.PatientRequest.Commands;
using SchedulePatients.Domain.Contracts;

namespace SchedulePatients.Application.Authentication.PatientRequest.Handlers
{
    public class DeletePatientHandler(IPatientService patientService) : IRequestHandler<DeletePatientCommand>
    {
        public async Task Handle(DeletePatientCommand request, CancellationToken cancellationToken)
        {
            patientService.Delete(request.Id);
        }
    }
}
