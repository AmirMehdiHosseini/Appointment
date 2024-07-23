using MediatR;
using SchedulePatients.Application.Authentication.PatientRequest.Queries;
using SchedulePatients.Application.Authentication.PhysicianRequest.Queries;
using SchedulePatients.Domain.Contracts;
using SchedulePatients.ViewModels;

namespace SchedulePatients.Application.Authentication.PhysicianRequest.Handlers
{
    public class GetAllPhysiciansHandler(IPhysicianService physicianService) : IRequestHandler<GetAllPhysiciansQuery, PhysicianViewModel[]>
    {
        public async Task<PhysicianViewModel[]> Handle(GetAllPhysiciansQuery request, CancellationToken cancellationToken)
        {
            return physicianService.GetAll();
        }
    }
}
