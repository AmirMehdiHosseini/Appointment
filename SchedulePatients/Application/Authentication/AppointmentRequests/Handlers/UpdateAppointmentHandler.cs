using MediatR;
using SchedulePatients.Application.Authentication.AppointmentRequests.Commands;
using SchedulePatients.Domain.Contracts;

namespace SchedulePatients.Application.Authentication.AppointmentRequests.Handlers
{
    public class UpdateAppointmentHandler(IAppointmentService appointmentService) : IRequestHandler<UpdateAppointmentCommand>
    {
        public async Task Handle(UpdateAppointmentCommand request, CancellationToken cancellationToken)
        {
            appointmentService.Update(request.Id, request.Command);
        }
    }
}
