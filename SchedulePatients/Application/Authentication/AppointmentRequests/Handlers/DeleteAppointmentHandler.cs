using MediatR;
using SchedulePatients.Application.Authentication.AppointmentRequests.Commands;
using SchedulePatients.Domain.Contracts;

namespace SchedulePatients.Application.Authentication.AppointmentRequests.Handlers
{
    public class DeleteAppointmentHandler(IAppointmentService appointmentService) : IRequestHandler<DeleteAppointmentCommand>
    {
        public async Task Handle(DeleteAppointmentCommand request, CancellationToken cancellationToken)
        {
            appointmentService.Delete(request.Id);
        }
    }
}
