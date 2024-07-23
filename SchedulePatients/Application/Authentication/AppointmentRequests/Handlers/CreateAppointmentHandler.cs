using MediatR;
using SchedulePatients.Application.Authentication.AppointmentRequests.Commands;
using SchedulePatients.Domain.Contracts;

namespace SchedulePatients.Application.Authentication.AppointmentRequests.Handlers
{
    public class CreateAppointmentHandler(IAppointmentService appointmentService) : IRequestHandler<CreateAppointmentCommand>
    {
        public async Task Handle(CreateAppointmentCommand request, CancellationToken cancellationToken)
        {
            appointmentService.Craete(request);
        }
    }
}
