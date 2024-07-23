using MediatR;

namespace SchedulePatients.Application.Authentication.PhysicianRequest.Commands
{
    public record DeletePhysicianCommand(int Id) : IRequest;
}
