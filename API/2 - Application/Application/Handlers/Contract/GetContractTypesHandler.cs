using Domain.Entities;
using Domain.Handlers.Contract;

namespace Application.Handlers.Contract
{
    public class GetContractTypesHandler : IGetContractTypesHandler
    {
        public async Task<IEnumerable<ContractType>> GetContractTypesAsync()
        {
            // TODO: implement real query, this one is just a test

            List<ContractType> types = new()
            {
                new()
                {
                    Type = Domain.Enums.EContractType.CAR_SALE,
                    Name = "CAR SALE"
                },
                new()
                {
                    Type = Domain.Enums.EContractType.TRUCK_SALE,
                    Name = "TRUCK SALE"
                },
                new()
                {
                    Type = Domain.Enums.EContractType.MOTORCYCLE_SALE,
                    Name = "MOTORCYCLE SALE"
                },
            };

            return types;
        }
    }
}
