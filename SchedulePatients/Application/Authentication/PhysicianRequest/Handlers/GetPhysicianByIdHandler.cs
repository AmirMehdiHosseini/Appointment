using MediatR;
using SchedulePatients.Application.Authentication.PhysicianRequest.Queries;
using SchedulePatients.Domain.Contracts;
using SchedulePatients.ViewModels;

namespace SchedulePatients.Application.Authentication.PhysicianRequest.Handlers
{
    public class GetPhysicianByIdHandler(IPhysicianService physicianService) : IRequestHandler<GetPhysicianByIdQuery, PhysicianViewModel>
    {
        public async Task<PhysicianViewModel?> Handle(GetPhysicianByIdQuery request, CancellationToken cancellationToken)
        {
            return physicianService.GetById(request.Id);
        }
    }
}
