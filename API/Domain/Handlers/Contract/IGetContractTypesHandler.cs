using Domain.Entities;

namespace Domain.Handlers.Contract
{
    public interface IGetContractTypesHandler
    {
        public Task<IEnumerable<ContractType>> GetContractTypesAsync();
    }
}
