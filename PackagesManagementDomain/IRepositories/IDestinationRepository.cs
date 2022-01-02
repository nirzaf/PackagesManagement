using System.Threading.Tasks;
using DDD.DomainLayer;
using PackagesManagementDomain.Aggregates;

namespace PackagesManagementDomain.IRepositories
{
    public interface IDestinationRepository : IRepository<IDestination>
    {
        Task<IDestination> Get(int id);
        IDestination New();
    }
}