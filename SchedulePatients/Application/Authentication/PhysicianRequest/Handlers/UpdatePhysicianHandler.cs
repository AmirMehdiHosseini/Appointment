using MediatR;
using SchedulePatients.Application.Authentication.PhysicianRequest.Commands;
using SchedulePatients.Domain.Contracts;

namespace SchedulePatients.Application.Authentication.PhysicianRequest.Handlers
{
    public class UpdatePhysicianHandler(IPhysicianService physicianService) : IRequestHandler<UpdatePhysicianCommand>
    {
        public async Task Handle(UpdatePhysicianCommand request, CancellationToken cancellationToken)
        {
            physicianService.Update(request.Id, request.Command);
        }
    }
}
