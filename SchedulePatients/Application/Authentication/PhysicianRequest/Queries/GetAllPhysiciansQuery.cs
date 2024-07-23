using MediatR;
using SchedulePatients.ViewModels;

namespace SchedulePatients.Application.Authentication.PhysicianRequest.Queries
{
    public record GetAllPhysiciansQuery() : IRequest<PhysicianViewModel[]>;

}
