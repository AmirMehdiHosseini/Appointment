using MediatR;
using SchedulePatients.Application.Authentication.PatientRequest.Commands;
using SchedulePatients.Domain.Contracts;

namespace SchedulePatients.Application.Authentication.PatientRequest.Handlers
{
    public class UpdatePatientHandler(IPatientService patientService) : IRequestHandler<UpdatePatientCommand>
    {
        public async Task Handle(UpdatePatientCommand request, CancellationToken cancellationToken)
        {
            patientService.Update(request.Id , request.Command);
        }
    }
}
