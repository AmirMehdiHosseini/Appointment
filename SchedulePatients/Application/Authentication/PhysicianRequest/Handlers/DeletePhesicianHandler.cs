using MediatR;
using SchedulePatients.Application.Authentication.PhysicianRequest.Commands;
using SchedulePatients.Domain.Contracts;

namespace SchedulePatients.Application.Authentication.PhysicianRequest.Handlers
{
    public class DeletePhesicianHandler(IPhysicianService physicianService) : IRequestHandler<DeletePhysicianCommand>
    {
        public async Task Handle(DeletePhysicianCommand request, CancellationToken cancellationToken)
        {
            physicianService.Delete(request.Id);
        }
    }
}
