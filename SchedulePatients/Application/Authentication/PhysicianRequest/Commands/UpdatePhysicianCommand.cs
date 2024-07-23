using MediatR;
using SchedulePatients.ViewModels;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SchedulePatients.Application.Authentication.PhysicianRequest.Commands
{
    public record UpdatePhysicianCommand(int Id, UpdatePhysicianViewModel Command) : IRequest;

}
