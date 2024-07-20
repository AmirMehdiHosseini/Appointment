using System.Xml.Serialization;

namespace SchedulePatients.Domain.Contracts
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
