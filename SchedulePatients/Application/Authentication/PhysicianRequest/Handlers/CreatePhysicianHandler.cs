using MediatR;
using SchedulePatients.Application.Authentication.PhysicianRequest.Commands;
using SchedulePatients.Domain.Contracts;

namespace SchedulePatients.Application.Authentication.PhysicianRequest.Handlers
{
    public class CreatePhysicianHandler(IPhysicianService physicianService) : IRequestHandler<CreatePhysicianCommand>
    {
        public async Task Handle(CreatePhysicianCommand request, CancellationToken cancellationToken)
        {
            physicianService.Create(request);
        }
    }
}
