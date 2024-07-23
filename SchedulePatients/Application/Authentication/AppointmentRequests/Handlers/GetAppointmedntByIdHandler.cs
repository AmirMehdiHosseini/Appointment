using MediatR;
using SchedulePatients.Application.Authentication.AppointmentRequests.Queries;
using SchedulePatients.Domain.Contracts;
using SchedulePatients.ViewModels;

namespace SchedulePatients.Application.Authentication.AppointmentRequests.Handlers
{
    public class GetAppointmedntByIdHandler(IAppointmentService appointmentService) : IRequestHandler<GetAppointmentByIdQuery, AppointmentViewModel>
    {
        public async Task<AppointmentViewModel> Handle(GetAppointmentByIdQuery request, CancellationToken cancellationToken)
        {
            return appointmentService.GetById(request.Id);
        }
    }
}
